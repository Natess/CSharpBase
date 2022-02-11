using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Lesson5
{
    //4. Задача ЕГЭ.
    //На вход программе подаются сведения о сдаче экзаменов учениками 9-х классов некоторой средней школы.
    //В первой строке сообщается количество учеников N, которое не меньше 10, но не превосходит 100, каждая из следующих N строк имеет следующий формат:
    //<Фамилия> <Имя> <оценки>,
    //где<Фамилия> — строка, состоящая не более чем из 20 символов, <Имя> — строка, состоящая не более чем из 15 символов,
    //<оценки> — через пробел три целых числа, соответствующие оценкам по пятибалльной системе.
    //<Фамилия> и<Имя>, а также <Имя> и<оценки> разделены одним пробелом. Пример входной строки:
    //Иванов Петр 4 5 3
    //Требуется написать как можно более эффективную программу, которая будет выводить на экран фамилии и имена трёх худших по среднему баллу учеников.
    //Если среди остальных есть ученики, набравшие тот же средний балл, что и один из трёх худших, следует вывести и их фамилии и имена.
    internal class Task4
    {
        internal static string ExamAnalysWorstStudents(string fileName)
        {
            try
            {
                if (!File.Exists(fileName))
                    return null;

                var student1 = new Student("", 5, 5, 5);
                var student2 = new Student("", 5, 5, 5);
                var student3 = new Student("", 5, 5, 5);
                var sameStudents1 = new StringBuilder();
                var sameStudents2 = new StringBuilder();
                var sameStudents3 = new StringBuilder();

                var lines = File.ReadAllLines(fileName);
                foreach (var line in lines)
                {
                    var currStudent = new Student().Parse(line);
                    if (currStudent.AverageScore < student1.AverageScore)
                    {
                        // Сдвигаем студента со второго места на третье (и учеников с таким же балом тоже)
                        student3 = student2;
                        sameStudents3 = sameStudents2;

                        // Сдвигаем студента со первого места на второе(и учеников с таким же балом тоже)
                        student2 = student1;
                        sameStudents2 = sameStudents1;

                        // Запоминаем нвого худшего студента
                        student1 = currStudent;
                        sameStudents1 = new StringBuilder(currStudent.Name + "| ");
                    }
                    // Если баллы равны добавляем к выводу
                    else if (currStudent.AverageScore == student1.AverageScore)
                        sameStudents1.Append(currStudent.Name + "| ");
                    else if (currStudent.AverageScore < student2.AverageScore)
                    {
                        // Сдвигаем студента со второго места на третье (и учеников с таким же балом тоже)
                        student3 = student2;
                        sameStudents3 = sameStudents2;

                        student2 = currStudent;
                        sameStudents2 = new StringBuilder(currStudent.Name + "| ");
                    }
                    else if (currStudent.AverageScore == student2.AverageScore)
                        sameStudents2.Append(currStudent.Name + "| ");
                    else if (currStudent.AverageScore < student3.AverageScore)
                    {
                        student3 = currStudent;
                        sameStudents3 = new StringBuilder(currStudent.Name + "| ");
                    }
                    else if (currStudent.AverageScore == student3.AverageScore)
                        sameStudents3.Append(currStudent.Name + "| ");
                }

                return $"Ученики со средним балом {student1.AverageScore}: {sameStudents1}\n" +
                    $"Ученики со средним балом {student2.AverageScore}: {sameStudents2}\n" +
                    $"Ученики со средним балом {student3.AverageScore}: {sameStudents3}\n";
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        internal static string ForCheck(string fileName)
        {
            try
            {
                if (!File.Exists(fileName))
                    return null;
                var result = new StringBuilder();
                var lines = File.ReadAllLines(fileName);
                foreach (var line in lines)
                {
                    var currStudent = new Student().Parse(line); 
                    result.AppendLine($"{line, -70} {currStudent.AverageScore, 10}");
                }
                return result.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
