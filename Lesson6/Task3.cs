using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Lesson6
{
    internal class Task3
    {
        public static List<Student> LoadFromFile(string filenName)
        {
            var res = new List<Student>();

            StreamReader sr = new StreamReader(filenName);
            while (!sr.EndOfStream)
            {
                try
                {
                    res.Add(new Student().Parse(sr.ReadLine(),';'));
                }
                catch
                {
                }
            }
            sr.Close();
            return res;
        }

        /// <summary>
        /// Подсчитать количество студентов учащихся на 5 и 6 курсах;
        /// </summary>
        /// <param name="students"></param>
        /// <returns></returns>
        public static int CountStudentFrom5And6Courses(List<Student> students) =>
            students.Where(x => x.Course == 5 || x.Course == 6).Count();

        /// <summary>
        /// Подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся 
        /// </summary>
        /// <param name="students"></param>
        /// <returns></returns>
        public static int[] AnalysStudentsCountForCourse(List<Student> students)
        {
            var res = new int[6];
            students.Where(x=>17 < x.Age && x.Age < 21)
                .ToList()
                .ForEach(x => res[x.Course-1]++);
            return res;
        }

        /// <summary>
        /// Отсортировать список по возрасту студента;
        /// </summary>
        /// <param name="students"></param>
        /// <returns></returns>
        public static List<Student> SortByAge(List<Student> students)
        {
            return students.OrderBy(x => x.Age).ToList();
        }

        /// <summary>
        /// Отсортировать список по курсу и возрасту студента
        /// </summary>
        /// <param name="students"></param>
        /// <returns></returns>
        public static List<Student> SortByCourseAndAge(List<Student> students)
        {
            return students.OrderBy(x => x.Course).ThenBy(x=>x.Age).ToList();
        }

    }
}
