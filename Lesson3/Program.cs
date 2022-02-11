using System;
using Utils;

namespace Lesson3
{
    internal class Program
    {

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
                Console.WriteLine("0 => Выход");
                Console.WriteLine("====================================");

                Console.WriteLine("Выберите задачу:");


                if (!int.TryParse(Console.ReadLine(), out int number))
                    number = -1;
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
                    default:
                        Console.WriteLine("Некорректный номер задачи.\nПовторите попытку ввода.");
                        break;
                }
            }

            ConsoleHelper.Pause();
        } 
        
        //3. *Описать класс дробей — рациональных чисел, являющихся отношением двух целых чисел.
        //            Предусмотреть методы сложения, вычитания, умножения и деления дробей. 
        //            Написать программу, демонстрирующую все разработанные элементы класса.
        //            Добавить свойства типа int для доступа к числителю и знаменателю;
        //        Добавить свойство типа double только на чтение, чтобы получить десятичную дробь числа; 
        //        ** Добавить проверку, чтобы знаменатель не равнялся 0. Выбрасывать исключение ArgumentException("Знаменатель не может быть равен 0"); 
        //        *** Добавить упрощение дробей.
        private static void RunTask3()
        {
            ConsoleHelper.PrintInCentre("Задание 3");
            Task3.Demonstration();
            Console.WriteLine();
        }

        //а) С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке). 
        //Требуется подсчитать сумму всех нечётных положительных чисел.
        //Сами числа и сумму вывести на экран, используя tryParse.
        private static void RunTask2()
        {
            ConsoleHelper.PrintInCentre("Задание 2");
            Console.WriteLine($"Результат (сумма всех нечётных положительных чисел): {Task2.SumOddPositiveNumbers()}");
            Console.WriteLine();
        }

        //а) Дописать структуру Complex, добавив метод вычитания комплексных чисел.Продемонстрировать работу структуры.
        //б) Дописать класс Complex, добавив методы вычитания и произведения чисел.Проверить работу класса.
        //в) Добавить диалог с использованием switch демонстрирующий работу класса.
        private static void RunTask1()
        {
            ConsoleHelper.PrintInCentre("Задание 1");
            Task1.Demonstration();
            Console.WriteLine();
        }
    }
}
