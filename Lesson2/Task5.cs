using System;

namespace Lesson2
{
    internal class Task5
    {

        //а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, 
        //    набрать вес или всё в норме.
        //б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
        internal static void GetIMTRecommendation()
        {
            try
            {
                Console.WriteLine("Введите вес (в кг.):");
                var weight = double.Parse(Console.ReadLine().Replace('.', ','));
                Console.WriteLine("Введите рост (в м.):");
                var height = double.Parse(Console.ReadLine().Replace('.', ','));
             
                GetRecommendation(weight, height);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка. {ex.Message}");
            }
        }

        private static void GetRecommendation(double weight, double height)
        {
            var imt = CalcImt(weight, height);
            Console.WriteLine($"\nРассчитанный ИМТ: {imt}");

            string msg;
            if (imt <= 16)
                msg = "Выраженный дефицит массы тела";
            else if (imt > 16 && imt <= 18.5)
                msg = "Недостаточная(дефицит) масса тела";
            else if (imt > 18.5 && imt <= 25)
                msg = "Норма";
            else if (imt > 25 && imt <= 30)
                msg = "Избыточная масса тела(предожирение)";
            else if (imt < 30 && imt <= 35)
                msg = "Ожирение первой степени";
            else if (imt < 35 && imt <= 40)
                msg = "Ожирение второй степени";
            else msg = "Ожирение третьей степени(морбидное)";

            if (imt <= 18.5)
                msg += $"\nВам нужно набрать {((18.6 * height * height) - weight):F1} кг.";
            else if (imt > 25)
                msg += $"\nВам нужно сбросить {(weight - (25 * height * height)):F1} кг.";

            Console.WriteLine(msg);
        }

        private static double CalcImt(double weight, double height) => Math.Round(weight / (height * height), 1);
    }
}