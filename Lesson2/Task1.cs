using System;

namespace Lesson2
{
    internal class Task1
    {
        //Написать метод, возвращающий минимальное из трёх чисел.
        internal static int Min1st(int a, int b, int c)
        {
            return a < b ? (a < c ? a : c) : (b < c ? b : c);
        }
        internal static int Min2nd(int a, int b, int c)
        {
            return Math.Min(a, Math.Min(b, c));
        }
    }
}