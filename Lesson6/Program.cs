using System;
using System.Collections.Generic;
using System.IO;
using Utils;

namespace Lesson6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Кузнецова Анастасия");
            var f = true;
            while (f)
            {
                Console.WriteLine("\n====================================");
                Console.WriteLine("1 => Задача 1");
                Console.WriteLine("2 => Задача 2");
                Console.WriteLine("3 => Задача 3"); 
                Console.WriteLine("0 => Выход");
                Console.WriteLine("====================================");

                Console.WriteLine("Выберите задачу:");


                if (!int.TryParse(Console.ReadLine(), out int number))
                    number = -1;
                switch (number)
                {
                    case 0:
                        Console.WriteLine("Завершение работы приложения ...");
                        f = false;
                        break;
                    case 1:
                        RunTask1();
                        break;
                    case 2:
                        RunTask2();
                        break;
                    case 3:
                        RunTask3();
                        break; 
                    default:
                        Console.WriteLine("Некорректный номер задачи.\nПовторите попытку ввода.");
                        break;
                }
            }

            ConsoleHelper.Pause();
        }
          
        
        //3. Переделать программу Пример использования коллекций для решения следующих задач:
        //  а) Подсчитать количество студентов учащихся на 5 и 6 курсах;
        //  б) подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся(*частотный массив);
        //  в) отсортировать список по возрасту студента;
        //г) *отсортировать список по курсу и возрасту студента;
        private static void RunTask3()
        {
            ConsoleHelper.PrintInCentre("Задание 3");
            var students = Task3.LoadFromFile(Path.Combine(AppContext.BaseDirectory, "students.csv"));
            Console.WriteLine("Количество студентов учащихся на 5 и 6 курсах:");
            Console.WriteLine(Task3.CountStudentFrom5And6Courses(students));
            Console.WriteLine();

            Console.WriteLine("Анализ сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся:");
            var fArr = Task3.AnalysStudentsCountForCourse(students);
            for (int i = 0; i < fArr.Length; i++)
                Console.WriteLine($"Курс {i+1}: {fArr[i]}");
            Console.WriteLine();

            Console.WriteLine("Отсортированный по возрасту список студентов:");
            Task3.SortByAge(students).ForEach(x => Console.WriteLine(x));
            Console.WriteLine();

            Console.WriteLine("Отсортированный по курсу и возрасту список студентов:");
            Task3.SortByCourseAndAge(students).ForEach(x => Console.WriteLine(x));
            Console.WriteLine();

            Console.WriteLine("\n====================================");
        }

        //2. Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию в виде делегата.
        //а) Сделать меню с различными функциями и представить пользователю выбор, для какой функции и на каком отрезке находить минимум.
        //Использовать массив(или список) делегатов, в котором хранятся различные функции.
        //б) *Переделать функцию Load, чтобы она возвращала массив считанных значений.Пусть она возвращает минимум через параметр (с использованием модификатора out).
        private static void RunTask2()
        {
            ConsoleHelper.PrintInCentre("Задание 2");

            var funcs = new List<Func<double, double>>
            {
                x => x*x - 50*x + 10,
                x => -x*x + 15*x,
                x => Math.Sin(x) + 2*Math.Cos(x),
            };

            Console.WriteLine("\n====================================");
            Console.WriteLine("1 => x^2 - 50x + 10");
            Console.WriteLine("2 => -x^2 + 15x");
            Console.WriteLine("3 => sin(x) + 2cox(x)");
            Console.WriteLine("====================================");
            Console.WriteLine("Выберите функцию:");
            if (!int.TryParse(Console.ReadLine(), out int number))
                number = -1;
            if (number < 1 || number > 3)
            {
                Console.WriteLine("Неверный ввод.");
                return;
            }

            Console.Write("Задайте отрезок:\na = ");
            if (!double.TryParse(Console.ReadLine().Replace(".", ","), out double a))
            {
                Console.WriteLine("Неверный ввод.");
                return;
            }    
            Console.Write("b = ");
            if (!double.TryParse(Console.ReadLine().Replace(".", ","), out double b))
            {
                Console.WriteLine("Неверный ввод.");
                return;
            }
            Console.Write("Задайте шаг:\nh = ");
            if (!double.TryParse(Console.ReadLine().Replace(".", ","), out double h))
            {
                Console.WriteLine("Неверный ввод.");
                return;
            }

            Task2.SaveFunc(Path.Combine(AppContext.BaseDirectory,"function_value.bin"), funcs[number - 1], a, b, h);
            var funcResult = Task2.Load(Path.Combine(AppContext.BaseDirectory, "function_value.bin"), out double min);
            Console.WriteLine("Значения функции:");
            foreach (var item in funcResult)
            {
                Console.WriteLine(item.ToString("0.000"));
            }
            Console.WriteLine($"\nМинимум = {min:f3}");
            Console.WriteLine("\n====================================");
        }

        //1. Изменить программу вывода таблицы функции так, чтобы можно было передавать функции типа double (double, double).
        //Продемонстрировать работу на функции с функцией a* x^2 и функцией a* sin(x).
        private static void RunTask1()
        {
            ConsoleHelper.PrintInCentre("Задание 1");
            Console.WriteLine("Таблица для функции a*x^2, где a = 2, x = от -5 до 5:");
            Task1.Table((a, x) => a * x * x, 2, -5, 5);
            Console.WriteLine("\n====================================");

            Console.WriteLine("Таблица для функции a*sin(x), где a = 2, x = от -5 до 5:");
            Task1.Table((a, x) => a * Math.Sin(x), 2, -5, 5);
            Console.WriteLine("\n====================================");
        }
    }
}
