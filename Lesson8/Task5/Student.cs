using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson8.Task5
{
    public class Student : IParser<Student>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Univercity { get; set; }
        public string Faculty { get; set; }
        public string Department { get; set; }
        public int Age { get; set; }
        public int Course { get; set; }
        public int Group { get; set; }
        public string City { get; set; }

        public Student Parse(string line, char separator)
        {
            var values = line.Split(separator);
            Name = values[0];
            Surname = values[1];
            Univercity = values[2];
            Faculty = values[3];
            Department = values[4];
            Age = int.Parse(values[5]);
            Course = int.Parse(values[6]);
            Group = int.Parse(values[7]);
            City = values[8];
            return this;
        }

        public override string ToString()
        {
            return String.Format("{0, -13} {1}|{2, 10}|{3,20}|{4, 30} | {5}.{6}. Возраст - {7}.| Город - {8, -40}",
                Surname, Name, Univercity, Faculty, Department, Course, Group, Age, City);
            //    //$"{Surname} {Name,-30} {Univercity}|{Faculty}|{Department}|{Course}.{Group}. Возраст - {Age}.| Город - {City}";

            //return $"{Surname, -20} {Name, 20} | {Univercity, 10} | {Faculty, 20} |{Department}|{Course}.{Group}. Возраст - {Age}.| Город - {City}";
        }
    }
}
