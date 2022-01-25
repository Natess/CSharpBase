using System;

namespace Lesson1
{
    class Program
    {
        //Кузнецова Анастасия
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");
            Task1.Quiz();
            Console.WriteLine();


            Console.WriteLine("Задание 2");
            Task2.CalcIMT();
            Console.WriteLine();


            Console.WriteLine("Задание 3");
            Task3.CalcPointsDistance();
            Console.WriteLine();


            Console.WriteLine("Задание 4");
            int a = 1, b = 2;
            Console.WriteLine($"Начальные значения: a = {a}, b = {b}");
            Task4.SwapWithThirdVariable(ref a, ref b);
            Console.WriteLine($"Результат: a = {a}, b = {b}");
            Console.WriteLine();

            Console.WriteLine($"Начальные значения: a = {a}, b = {b}");
            Task4.SwapWithoutThirdVariable(ref a, ref b);
            Console.WriteLine($"Результат: a = {a}, b = {b}");
            Console.WriteLine();
            Console.WriteLine("Нажмите Enter");
            Task6.Pause();
            Console.Clear();


            Console.WriteLine("Задание 5");
            var mes = "Кузнецова Анастасия, г. Москва";
            //а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
            Console.WriteLine(mes);

            //б) Сделать задание, только вывод организовать в центре экрана.
            Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2);
            Console.WriteLine(mes);
            Console.WriteLine("Нажмите Enter");
            Task6.Pause();
            Console.Clear();

            //в) *Сделать задание б с использованием собственных методов(например, Print(string ms, int x, int y).
            Task6.Print(mes, 50, 50);
            Console.WriteLine("Нажмите Enter");
            Task6.Pause();
            Console.Clear();


            Console.WriteLine("Задание 6");
            Task6.Print("Hello, world!", 100, 100);
            Task6.Pause();
        }
    }
}
