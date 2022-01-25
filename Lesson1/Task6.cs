using System;

namespace Lesson1
{
    internal class Task6
    {
        //Создать класс с методами, которые могут пригодиться в вашей учебе(Print, Pause).
        internal static void Print(string message, int x, int y)
        {
            if (x >= Console.WindowWidth)
                x = Console.WindowWidth - 1;

            if (x < 0)
                x = 0;

            if (y < 0)
                y = 0;

            Console.SetCursorPosition(x, y);
            Console.WriteLine(message);
        }

        internal static void Pause()
        {
            Console.ReadKey();
        }
    }
}