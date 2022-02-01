using System;

namespace Lesson2
{
    internal class Task3
    {
        //С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
        internal static int SumOddPositiveNumbers()
        {
            try
            {
                var current = -1;
                var sum = 0;
                Console.WriteLine("Вводите числа (введите 0 для остановки):");
                while (current != 0)
                {
                    current = int.Parse(Console.ReadLine());
                    if (current % 2 == 1 && current > 0)
                        sum += current;
                }
                return sum;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка. {ex.Message}");
                return 0;
            }
        }
    }
}