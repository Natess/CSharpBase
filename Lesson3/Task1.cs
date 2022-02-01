using System;

namespace Lesson3
{
    internal class Task1
    {
        static Random randomizer = new Random();

        //а) Дописать структуру Complex, добавив метод вычитания комплексных чисел.Продемонстрировать работу структуры.
        //б) Дописать класс Complex, добавив методы вычитания и произведения чисел.Проверить работу класса.
        //в) Добавить диалог с использованием switch демонстрирующий работу класса.
        internal static void Demonstration()
        {
            Console.WriteLine("Демонстрация работы структуры:");
            var a = new ComplexStruct(randomizer.Next(-10, 10), randomizer.Next(-10, 10));
            var b = new ComplexStruct(randomizer.Next(-10, 10), randomizer.Next(-10, 10));

            Console.WriteLine($"Входные значения: a = {a}, b = {b}");
            Console.WriteLine($"Результат сложения: {a + b}");
            Console.WriteLine($"Результат вычитания: {a - b}");

            ClassDemonstration();
        }

        private static void ClassDemonstration()
        {
            Console.WriteLine("\nДемонстрация работы класса:");
            var a1 = new Complex(randomizer.Next(-10, 10), randomizer.Next(-10, 10));
            var b1 = new Complex(randomizer.Next(-10, 10), randomizer.Next(-10, 10));
            a1 = new Complex(2, 3);
            b1 = new Complex(-1, 1);
            var f = true;
            while (f)
            {
                Console.WriteLine("\n====================================");
                Console.WriteLine($"Входные значения: a = {a1}, b = {b1}");
                Console.WriteLine("1, + => +");
                Console.WriteLine("2, - => -");
                Console.WriteLine("3, * => *");
                Console.WriteLine("4 => Обновить переменные");
                Console.WriteLine("0 => Выход");
                Console.WriteLine("====================================");
                Console.WriteLine("Выберите операцию:");

                var choiсe = Console.ReadLine();
                switch (choiсe)
                {
                    case "0":
                        Console.WriteLine("Выход");
                        f = false;
                        break;
                    case "+":
                    case "1":
                        Console.WriteLine($"Входные значения: a = {a1}, b = {b1}");
                        Console.WriteLine($"\tРезультат сложения: {a1 + b1}");
                        break;
                    case "-":
                    case "2":
                        Console.WriteLine($"Входные значения: a = {a1}, b = {b1}");
                        Console.WriteLine($"\tРезультат вычитания: {a1 - b1}");
                        break;
                    case "*":
                    case "3":
                        Console.WriteLine($"Входные значения: a = {a1}, b = {b1}");
                        Console.WriteLine($"\tРезультат произведения: {a1 * b1}");
                        break;
                    case "4":
                        a1 = new Complex(randomizer.Next(-10, 10), randomizer.Next(-10, 10));
                        b1 = new Complex(randomizer.Next(-10, 10), randomizer.Next(-10, 10));
                        break;
                    default:
                        Console.WriteLine("Некорректный номер операции.\nПовторите попытку ввода.");
                        break;
                }
            }
        }
    }
}