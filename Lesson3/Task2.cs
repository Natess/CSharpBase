using System;

namespace Lesson3
{
    internal class Task2
    {


        //а) С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке). 
        //Требуется подсчитать сумму всех нечётных положительных чисел.
        //Сами числа и сумму вывести на экран, используя tryParse.
        internal static int SumOddPositiveNumbers()
        {
            var current = -1;
            var sum = 0;
            Console.WriteLine("Вводите числа (введите 0 для остановки):");
            while (current != 0)
            {
                if (!int.TryParse(Console.ReadLine(), out current))
                {
                    Console.WriteLine("Ошибка ввода. Попробуйте еще раз.");
                    current = -1;
                    continue;
                }
                if (current % 2 == 1 && current > 0)
                {
                    Console.WriteLine(current + "- нечётное положительное");
                    sum += current;
                }
            }
            return sum;
        }
    }
}