using System;
using System.Collections.Generic;
using System.IO;

namespace ArraysLib
{ 
    //а) Дописать класс для работы с одномерным массивом.
    //        Реализовать конструктор, создающий массив определенного размера и заполняющий массив числами от начального значения с заданным шагом.
    //        Создать свойство Sum, которое возвращает сумму элементов массива, 
    //        метод Inverse, возвращающий новый массив с измененными знаками у всех элементов массива(старый массив, остается без изменений), 
    //        метод Multi, умножающий каждый элемент массива на определённое число,
    //        свойство MaxCount, возвращающее количество максимальных элементов.
    //б)** Создать библиотеку содержащую класс для работы с массивом.Продемонстрировать работу библиотеки
    //в) *** Подсчитать частоту вхождения каждого элемента в массив(коллекция Dictionary<int, int>)
    public class MyArray
    {
        #region Поля

        private int[] arr;

        #endregion

        #region Свойства

        public int this[int index]
        {
            get
            {
                return arr[index];
            }

            set
            {
                arr[index] = value;
            }
        }

        /// <summary>
        /// Возвращает сумму элементов массива
        /// </summary>
        public int Sum
        {
            get
            {
                var sum = 0;
                foreach (var a in arr)
                    sum += a;
                return sum;
            }
        }

        /// <summary>
        /// Возвращает количество максимальных элементов
        /// </summary>
        public int MaxCount
        {
            get
            {
                int max = int.MinValue;
                int maxCount = 0;
                foreach (var a in arr)
                {
                    if (a > max)
                    {
                        max = a;
                        maxCount = 1;
                    }
                    else if (a == max)
                        maxCount++;
                }
                return maxCount;
            }
        }

        #endregion

        #region Конструкторы

        public MyArray(int[] arr)
        {
            this.arr = arr;
        }

        public MyArray(string fileName)
        {
            arr = LoadArrayFromFile(fileName);
        }

        /// <summary>
        /// Конструктор, создающий массив определенного размера и заполняющий массив числами от начального значения с заданным шагом.
        /// </summary>
        /// <param name="length">Длина массива</param>
        /// <param name="startValue">Начальное значение</param>
        /// <param name="step">Шаг</param>
        public MyArray(int length, int startValue, int step)
        {
            arr = new int[length];
            for (int i = 0; i < length; i++, startValue+=step)
                arr[i] = startValue;
        }

        #endregion

        #region Скрытые методы

        private int[] LoadArrayFromFile(string fileName)
        {
            if (!File.Exists(fileName))
                return null;

            int[] arr = new int[1000];
            int counter = 0;

            StreamReader sr = new StreamReader(fileName);

            while (!sr.EndOfStream)
            {
                int number = int.Parse(sr.ReadLine());
                arr[counter] = number;
                counter++;
            }

            int[] buf = new int[counter];

            Array.Copy(arr, buf, counter);

            sr.Close();
            return buf;
        }

        #endregion

        #region Публичные методы 

        public int GetElement(int index)
        {
            return arr[index];
        }

        public void SetElement(int index, int value)
        {
            arr[index] = value;
        }

        public void PrintArray()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]}\t");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Создает массив с измененными знаками у всех элементов исходного массива
        /// </summary>

        public MyArray Inverse()
        {
            var resArr = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                resArr[i] = -arr[i];
            }
            return new MyArray(resArr);
        }

        /// <summary>
        /// Уиножает каждый элемент массива на заданное число
        /// </summary>
        /// <param name="multiplier">Множитель</param>

        public void Multi(int multiplier)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] *= multiplier;
            }
        }

        /// <summary>
        /// Подсчитывает частоту вхождения каждого элемента 
        /// </summary>
        /// <returns></returns>
        public Dictionary<int, int> CountFrequencyEachElement()
        {
            var res = new Dictionary<int, int>();
            foreach (var a in arr)
            {
                if (res.ContainsKey(a))
                    res[a]++;
                else
                    res[a] = 1;
            }
            return res;
        }

        #endregion
    }
}
