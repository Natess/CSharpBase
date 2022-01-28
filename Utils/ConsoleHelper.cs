using System;

namespace Utils
{
    public class ConsoleHelper
    {
        public static void Print(string message, int x, int y)
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

        public static void PrintInCentre(string message)
        {
            Console.SetCursorPosition(Console.WindowWidth / 2, Console.CursorTop);
            Console.WriteLine(message);
        }

        public static void Pause()
        {
            Console.ReadKey();
        }
    }
}
