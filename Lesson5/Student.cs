using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson5
{
    internal class Student
    {
        public string Name { get; set; }
        public int FirstExamResult { get; set; }
        public int SecondExamResult { get; set; }
        public int ThirdExamResult { get; set; }

        public Student(string name, int result1, int result2, int result3)
        {
            Name = name;
            FirstExamResult = result1;
            SecondExamResult = result2;
            ThirdExamResult = result3;
        }

        public Student()
        {
        }

        public double AverageScore { get
            {
                return Math.Round((FirstExamResult + SecondExamResult + ThirdExamResult) / 3.0, 2);
            }
        }

        public Student Parse(string input)
        {
            var words = input.Split(' ');
            Name = $"{words[0]} {words[1]}";
            FirstExamResult = int.Parse(words[2]);
            SecondExamResult = int.Parse(words[3]);
            ThirdExamResult = int.Parse(words[4]);
            return this;
        } 
    }
}
