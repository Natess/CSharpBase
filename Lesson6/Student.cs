using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson6
{
    internal class Student
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
            return $"{Surname} {Name}. {Univercity}|{Faculty}|{Department}|{Course}.{Group}. Возраст - {Age}.| Город - {City}";
        }
    }
}
