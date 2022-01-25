using System;

namespace Lesson1
{
    internal class Task3
    {

        //а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2).
        //Вывести результат, используя спецификатор формата .2f(с двумя знаками после запятой);
        //б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.
        internal static void CalcPointsDistance()
        {
            try
            {
                Console.WriteLine("Введите координаты первой точки. Координата x:");
                var x1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Координата y:");
                var y1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите координаты второй точки. Координата x:");
                var x2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Координата y:");
                var y2 = int.Parse(Console.ReadLine());
                var res = Calc(x1, y1, x2, y2);
                Console.WriteLine($"Результат: {res:f2}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Введено некорректное значение. {ex.Message}");
            }
        }

        private static double Calc(int x1, int y1, int x2, int y2) =>
             Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    }
}