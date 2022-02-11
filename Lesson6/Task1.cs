using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson6
{
    public delegate double Fun(double x);

    /// <summary>
    /// Делегат, который принимает параметр и константу для преобразования
    /// </summary>
    /// <param name="a">Константа для функции</param>
    /// <param name="x">Параметр</param>
    /// <returns>Результат работы функции</returns>
    public delegate double FunFor2(double a, double x);

    //1. Изменить программу вывода таблицы функции так, чтобы можно было передавать функции типа double (double, double).
    //Продемонстрировать работу на функции с функцией a* x^2 и функцией a* sin(x).
    internal class Task1
    {
        // Создаем метод, который принимает делегат
        // На практике этот метод сможет принимать любой метод
        // с такой же сигнатурой, как у делегата
        public static void Table(Fun F, double x, double b)
        {
            Console.WriteLine("----- X ----- Y -----");
            while (x <= b)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, F(x));
                x += 1;
            }
            Console.WriteLine("---------------------");
        }

        /// <summary>
        /// Отображает таблицу изменения значений переменный от x до b после работы функции с константой a
        /// </summary>
        /// <param name="function">Функция-преобразователь</param>
        /// <param name="a">Константа</param>
        /// <param name="x">Нижний порог</param>
        /// <param name="b">Верхний порог</param>
        public static void Table(FunFor2 function, double a, double x, double b)
        {

            Console.WriteLine("----- X ----- Y -----");
            while (x <= b)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, function(a, x));
                x += 1;
            }
            Console.WriteLine("---------------------");
        }

        // Создаем метод для передачи его в качестве параметра в Table
        public static double MyFunc(double x)
        {
            return x * x * x;
        }

    }
}