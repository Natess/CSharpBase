using System;
using Utils;

namespace Lesson2
{
    class Program
    {
        static Random Randomizer = new Random();

        static void Main(string[] args)
        {
            Console.WriteLine("Кузнецова Анастасия");
            var f = true;
            while (f)
            {
                Console.WriteLine("\n====================================");
                Console.WriteLine("1 => Задача 1");
                Console.WriteLine("2 => Задача 2");
                Console.WriteLine("3 => Задача 3");
                Console.WriteLine("4 => Задача 4");
                Console.WriteLine("5 => Задача 5");
                Console.WriteLine("6 => Задача 6");
                Console.WriteLine("0 => Выход");
                Console.WriteLine("====================================");

                Console.WriteLine("Выберите задачу:");

                int number = -1;
                try
                {
                    number = int.Parse(Console.ReadLine());
                }
                catch 
                {
                }
                switch (number)
                {
                    case 0:
                        Console.WriteLine("Завершение работы приложения ...");
                        f = false;
                        break;
                    case 1:
                        RunTask1();
                        break;
                    case 2:
                        RunTask2();
                        break;
                    case 3:
                        RunTask3();
                        break;
                    case 4:
                        RunTask4();
                        break;
                    case 5:
                        RunTask5();
                        break;
                    case 6:
                        RunTask6();
                        break;
                    case 7:
                        RunTask7();
                        break;
                    default:
                        Console.WriteLine("Некорректный номер задачи.\nПовторите попытку ввода.");
                        break;
                }
            }

            ConsoleHelper.Pause();
        }

        private static void RunTask7()
        {
            ConsoleHelper.PrintInCentre("Задание 7");
            int a = Randomizer.Next(0, 100), b = Randomizer.Next(0, 100);
            if (a > b)
                ElmentsHelper.Swap(ref a,ref b);
            Console.WriteLine($"Входные значения: a - {a}, b - {b}");
            Task7.PrintNumberFromAToB(a, b);
            Console.WriteLine($"\nРезультат сумирования: { Task7.SumNumberFromAToB(a, b)}");
            Console.WriteLine();
        }

        private static void RunTask6()
        {
            ConsoleHelper.PrintInCentre("Задание 6");
            Task6.CountGoodNumbers();
            Console.WriteLine();
        }

        private static void RunTask5()
        {
            ConsoleHelper.PrintInCentre("Задание 5");
            Task5.GetIMTRecommendation();
            Console.WriteLine();
        }

        private static void RunTask4()
        {
            ConsoleHelper.PrintInCentre("Задание 4");
            Task4.Authorization();
            Console.WriteLine();
        }

        private static void RunTask3()
        {
            ConsoleHelper.PrintInCentre("Задание 3");
            Console.WriteLine($"Результат: {Task3.SumOddPositiveNumbers()}");
            Console.WriteLine();
        }

        private static void RunTask2()
        {
            ConsoleHelper.PrintInCentre("Задание 2");
            int a2 = Randomizer.Next(-1000, 1000);
            Console.WriteLine($"Входные значения: a - {a2}");
            Console.WriteLine($"Результат: {Task2.DigitsCount(a2)}");
            Console.WriteLine();
        }

        private static void RunTask1()
        {
            ConsoleHelper.PrintInCentre("Задание 1");
            int a = Randomizer.Next(-1000, 1000), b = Randomizer.Next(-1000, 1000), c = Randomizer.Next(-1000, 1000);
            Console.WriteLine($"Входные значения: a - {a}, b - {b}, c - {c}");
            Console.WriteLine($"Результат: {Task1.Min1st(a, b, c)}");
            Console.WriteLine($"Результат: {Task1.Min2nd(a, b, c)}");
            Console.WriteLine();
        }
    }
}
