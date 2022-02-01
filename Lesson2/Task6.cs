using System;

namespace Lesson2
{
    internal class Task6
    {
        //Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000. 
        //«Хорошим» называется число, которое делится на сумму своих цифр.Реализовать подсчёт времени выполнения программы, используя структуру DateTime.
        internal static void CountGoodNumbers()
        {
            var start = DateTime.Now;
            var res = 10;
            for (int i = 11; i <= 1000000000; i++)
            {
                var cur = i;
                var digitsSum = 0;
                while (cur!= 0)
                {
                    digitsSum += cur % 10;
                    cur /= 10;
                }
                if (i % digitsSum == 0)
                    res++;
            }
            var end = DateTime.Now;
            Console.WriteLine($"Найдено чисел: {res}. Потрачено времени:{end-start}");
        }
    }
}