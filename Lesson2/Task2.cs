using System;

namespace Lesson2
{
    internal class Task2
    {
        //Написать метод подсчета количества цифр числа.
        internal static int DigitsCount(int a)
        {
            var res = 0;

            do
            {
                res++;
                a /= 10;
            } while (a != 0);

            return res;
        }
    }
}