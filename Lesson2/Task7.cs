using System;

namespace Lesson2
{
    internal class Task7
    {

        //a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b).
        internal static void PrintNumberFromAToB(int a, int b)
        {
            if(a <= b)
            {
                Console.Write($"{a} ");
                PrintNumberFromAToB(a + 1, b);
            }
        }

        //б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.
        internal static int SumNumberFromAToB(int a, int b)
        {
            if (a <= b)
                return a + SumNumberFromAToB(a + 1, b);
            return 0;
        }
    }
}