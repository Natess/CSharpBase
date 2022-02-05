using System;
using System.IO;

namespace Lesson4
{
    //    Реализуйте задачу 1 в виде статического класса StaticClass;
    //а) Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1;
    //б) Добавьте статический метод для считывания массива из текстового файла.Метод должен возвращать массив целых чисел;
    //    в)* Добавьте обработку ситуации отсутствия файла на диске.
    internal static class StaticClass
    {
        //    1. Дан целочисленный массив из 20 элементов.Элементы массива могут принимать целые значения от –10 000 до 10 000 включительно.
        //    Заполнить случайными числами.Написать программу, позволяющую найти и вывести количество пар элементов массива,
        //    в которых только одно число делится на 3. В данной задаче под парой подразумевается два подряд идущих элемента массива.
        //Например, для массива из пяти элементов: 6; 2; 9; –3; 6 ответ — 2.
        internal static int FindPairsDividedBy3(int[] array)
        {
            var result = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if ((array[i] % 3 == 0 && array[i + 1] % 3 != 0) || (array[i] % 3 != 0 && array[i + 1] % 3 == 0))
                    result++;
            }
            return result;
        }

        //б) Добавьте статический метод для считывания массива из текстового файла.Метод должен возвращать массив целых чисел;
        //    в)* Добавьте обработку ситуации отсутствия файла на диске.
        internal static int[] ReadArrayFromFile(string fileName, string path = "")
        {
            var filePath = Path.Combine(path, fileName);
            if (!File.Exists(filePath))
            {
                Console.WriteLine($"Файл {fileName} не найден по указанному пути!");
                return null;
            }

            try
            {
                var lines = File.ReadAllLines(filePath);
                var arr = new int[lines.Length];
                for (int i = 0; i < lines.Length; i++)
                {
                    arr[i] = int.Parse(lines[i]);
                }
                return arr;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Было поймано исключение: {ex.Message}");
                return null;

            }
        }
    }
}