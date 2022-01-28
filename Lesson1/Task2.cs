using System;

namespace Lesson1
{
    internal class Task2
    {
        //Ввести вес и рост человека.Рассчитать и вывести индекс массы тела(ИМТ) по формуле I=m/(h* h); 
        //    где m — масса тела в килограммах, h — рост в метрах.
        internal static void CalcIMT()
        {
            try
            {
                Console.WriteLine("Введите рост (в м.):");
                var h = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите вес (в кг.):");
                var m = int.Parse(Console.ReadLine());
                Console.WriteLine($"Рассчитанный ИМТ: {m / (h * h):F1}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Введено некорректное значение. {ex.Message}");
            }
        }
    }
}