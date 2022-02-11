using ArraysLib;
using MatrixLib;
using System;
using System.IO;
using Utils;

namespace Lesson4
{
    internal class Program
    {
        static Random randomizer = new Random();

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
                Console.WriteLine("4 => Задача 4");
                Console.WriteLine("5 => Задача 5");
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
                    case 4:
                        RunTask4();
                        break;
                    case 5:
                        RunTask5();
                        break;
                    default:
                        Console.WriteLine("Некорректный номер задачи.\nПовторите попытку ввода.");
                        break;
                }
            }

            ConsoleHelper.Pause();
        }

        

        //5.а) Реализовать библиотеку с классом для работы с двумерным массивом.
        //  Реализовать конструктор, заполняющий массив случайными числами.
        //  Создать методы, которые возвращают сумму всех элементов массива,
        //  сумму всех элементов массива больше заданного,
        //  свойство, возвращающее минимальный элемент массива,
        //  свойство, возвращающее максимальный элемент массива,
        //  метод, возвращающий номер максимального элемента массива(через параметры, используя модификатор ref или out).
        //*б) Добавить конструктор и методы, которые загружают данные из файла и записывают данные в файл.
        //** в) Обработать возможные исключительные ситуации при работе с файлами.

        private static void RunTask5()
        {
            ConsoleHelper.PrintInCentre("Задание 5");
            Console.WriteLine("Матрица, заполненная случайными числами:");
            var matrix = new MyMatrix(5, 6);
            matrix.Print();
            Console.WriteLine($"Суммма всех элементов матрицы: {matrix.SumAllElements()}");
            Console.WriteLine($"Суммма всех элементов, больше 30: {matrix.SumAllElementsGreaterN(30)}");
            Console.WriteLine($"Минимальный элемент матрицы: {matrix.Min}");
            Console.WriteLine($"Максимальный элемент матрицы: {matrix.Max}");
            matrix.FindIndexsMaxElement(out int row, out int column);
            Console.WriteLine($"Номер максимального элемента матрицы: ({row}, {column})");
            Console.WriteLine();

            Console.WriteLine("Матрица, заполненная из файла \"matrixRead.txt\":");
            var fileMatrix = new MyMatrix(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "matrixRead.txt"));
            fileMatrix.Print();
            Console.WriteLine("Первая матрица была записана в файл \"matrixWrite.txt\"");
            matrix.WriteToFile("matrixWrite.txt");
        }

        /// <summary>
        /// 4. Решить задачу с логинами из урока 2, только логины и пароли считать из файла в массив. Создайте структуру Account, содержащую Login и Password.
        /// </summary>

        private static void RunTask4()
        {
            ConsoleHelper.PrintInCentre("Задание 4");
            var accounts = Task4.ReadAuthorizationData("accounts.txt", AppDomain.CurrentDomain.BaseDirectory);
            Console.WriteLine("Считанны данные:");
            for (int i = 0; i < accounts.Length; i++)
            {
                Console.WriteLine(accounts[i].ToString());
            }
            Task4.LogIn(accounts);
            Console.WriteLine();
        }

        //а) Дописать класс для работы с одномерным массивом.
        //        Реализовать конструктор, создающий массив определенного размера и заполняющий массив числами от начального значения с заданным шагом.
        //        Создать свойство Sum, которое возвращает сумму элементов массива, 
        //        метод Inverse, возвращающий новый массив с измененными знаками у всех элементов массива(старый массив, остается без изменений), 
        //        метод Multi, умножающий каждый элемент массива на определённое число,
        //        свойство MaxCount, возвращающее количество максимальных элементов.
        //б)** Создать библиотеку содержащую класс для работы с массивом.Продемонстрировать работу библиотеки
        //в) *** Подсчитать частоту вхождения каждого элемента в массив(коллекция Dictionary<int, int>)
        private static void RunTask3()
        {
            ConsoleHelper.PrintInCentre("Задание 3");
            Console.WriteLine("Массив, созданный с помощью конструктора от начального значения -10 и с шагом 3:");
            var arr = new MyArray(10, -10, 3);
            arr.PrintArray();
            Console.WriteLine($"Сумма элементов этого массива: {arr.Sum}");
            Console.WriteLine("Инверсированный массив:");
            var inverseArr = arr.Inverse();
            inverseArr.PrintArray();
            Console.WriteLine("Начальный массив, все элементы которого умножены на 2:");
            arr.Multi(2);
            arr.PrintArray();
            Console.WriteLine();

            var arr2 = new MyArray(new int []{ 10, -3, 23, 23, 45, 23, 1, 3, 45, 3, 10, 45, 45, -43 });
            Console.WriteLine("Новый массив:");
            arr2.PrintArray();
            Console.WriteLine($"Количество вхождений максимального элемента в масиве: {arr2.MaxCount}");
            Console.WriteLine("Частота вхождения каждого элемента в массив:");
            foreach (var f in arr2.CountFrequencyEachElement())
            {
                Console.WriteLine($"\"{f.Key}\"={f.Value}");
            }
            Console.WriteLine();
        }

        //    Реализуйте задачу 1 в виде статического класса StaticClass;
        //      а) Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1;
        //      б) Добавьте статический метод для считывания массива из текстового файла.Метод должен возвращать массив целых чисел;
        //      в)* Добавьте обработку ситуации отсутствия файла на диске.
        private static void RunTask2()
        {
            ConsoleHelper.PrintInCentre("Задание 2");
            Console.WriteLine("Попытка обратиться к несуществующему файлу...");
            StaticClass.ReadArrayFromFile("not_exists.txt");

            Console.Write("Считанный массив из файла \"arr.txt\":");
            var arr = StaticClass.ReadArrayFromFile("arr.txt", AppDomain.CurrentDomain.BaseDirectory);
            for (int i = 0; i < arr.Length; i++)
            {
                if (i%10 == 0)
                    Console.WriteLine();
                Console.Write($"{arr[i]}\t");
            }
            Console.WriteLine();
        }

        //    1. Дан целочисленный массив из 20 элементов.Элементы массива могут принимать целые значения от –10 000 до 10 000 включительно.
        //    Заполнить случайными числами.Написать программу, позволяющую найти и вывести количество пар элементов массива,
        //    в которых только одно число делится на 3. В данной задаче под парой подразумевается два подряд идущих элемента массива.
        //    Например, для массива из пяти элементов: 6; 2; 9; –3; 6 ответ — 2.
        private static void RunTask1()
        {
            ConsoleHelper.PrintInCentre("Задание 1");
            var array = new int[20];
            Console.WriteLine("Начальный массив:");
            for (int i = 0; i < array.Length; i++)
            {
                if (i == 10)
                    Console.WriteLine();
                array[i] = randomizer.Next(-10000, 10001);
                Console.Write($"{array[i]}\t");
            }
            Console.Write($"\nКоличество пар элементов массива, в которых только одно число делится на 3: {StaticClass.FindPairsDividedBy3(array)}");
            Console.WriteLine();
        }
    }
}
