using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson1
{
    public static class Task1
    {
        //        1. Написать программу «Анкета». Последовательно задаются вопросы(имя, фамилия, возраст, рост, вес).
        //          В результате вся информация выводится в одну строчку:
        //          а) используя склеивание;
        //          б) используя форматированный вывод;
        //          в) используя вывод со знаком $.
        public static void Quiz()
        {
            try
            {
                Console.WriteLine("Введите ваше имя:");
                var name = Console.ReadLine();
                Console.WriteLine("Введите вашу фамилию:");
                var surname = Console.ReadLine();
                Console.WriteLine("Введите ваш возраст:");
                var age = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите ваш рост (в см.):");
                var height = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите ваш вес (в кг.):");
                var weight = int.Parse(Console.ReadLine());

                Print(name, surname, age, height, weight);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Введено некорректное значение. {ex.Message}");
            }
        }

        private static void Print(string name, string surname, int age, int height, int weight)
        {
            Console.WriteLine(name + " " + surname + ". Возраст - " + age + ", рост - " + height + ", вес - " + weight);
            Console.WriteLine("{0} {1}. Возраст - {2}, рост - {3}, вес - {4}", name, surname, age, height, weight);
            Console.WriteLine($"{name} {surname}. Возраст - {age}, рост - {height}, вес - {weight}");
        }
    }
}
