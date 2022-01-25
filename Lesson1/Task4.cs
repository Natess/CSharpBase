using System;

namespace Lesson1
{
    internal class Task4
    {
        //        Написать программу обмена значениями двух переменных типа int без использования вспомогательных методов.
        //          а) с использованием третьей переменной;
        internal static void SwapWithThirdVariable(ref int a, ref int b)
        {
            var c = a;
            a = b;
            b = c;
        }

        //        Написать программу обмена значениями двух переменных типа int без использования вспомогательных методов.
        //        б) *без использования третьей переменной.
        internal static void SwapWithoutThirdVariable(ref int a, ref int b)
        {
            a += b;
            b = a - b;
            a = a - b;
        }
    }
}