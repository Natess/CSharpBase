using System;
using System.IO;
using System.Text;

namespace MatrixLib
{
    //5.а) Реализовать библиотеку с классом для работы с двумерным массивом.
    //  Реализовать конструктор, заполняющий массив случайными числами.
    //  Создать методы, которые возвращают сумму всех элементов массива,
    //  сумму всех элементов массива больше заданного,
    //  свойство, возвращающее минимальный элемент массива,
    //  свойство, возвращающее максимальный элемент массива,
    //  метод, возвращающий номер максимального элемента массива(через параметры, используя модификатор ref или out).
    //*б) Добавить конструктор и методы, которые загружают данные из файла и записывают данные в файл.
    //** в) Обработать возможные исключительные ситуации при работе с файлами.
    public class MyMatrix
    {
        #region Поля и свойства

        private int[,] matrix;
        private int rowsCount = -1;
        private int columnsCount = -1;

        /// <summary>
        /// Максимальный элемент массива
        /// </summary>
        public int Max
        {
            get
            {
                var max = int.MinValue;
                for (int i = 0; i < rowsCount; i++)
                {
                    for (int j = 0; j < columnsCount; j++)
                    {
                        if (matrix[i, j] > max)
                            max = matrix[i, j];
                    }
                }
                return max;
            }
        }

        /// <summary>
        /// Минимальный элемент массива
        /// </summary>
        public int Min
        {
            get
            {
                var min = int.MaxValue;
                for (int i = 0; i < rowsCount; i++)
                {
                    for (int j = 0; j < columnsCount; j++)
                    {
                        if (matrix[i, j] < min)
                            min = matrix[i, j];
                    }
                }
                return min;
            }
        }

        #endregion

        #region Конструкторы

        /// <summary>
        /// Конструктор, заполняющий массив случайными числами.
        /// </summary>
        /// <param name="rowsCount">Кол-во строк</param>
        /// <param name="columnsCount">Кол-во столбцов</param>
        public MyMatrix(int rowsCount, int columnsCount)
        {
            Random r = new Random();
            matrix = new int[rowsCount, columnsCount];
            this.columnsCount = columnsCount;
            this.rowsCount = rowsCount;

            for (int i = 0; i < rowsCount; i++)
            {
                for (int j = 0; j < columnsCount; j++)
                {
                    matrix[i, j] = r.Next(-100, 101);
                }
            }
        }

        /// <summary>
        /// Конструктор загружает данные из файла
        /// </summary>
        /// <param name="filePath">Путь к файлу с именем</param>
        public MyMatrix(string filePath)
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine($"Файл {filePath} не найден!");
                return;
            }

            try
            {
                var lines = File.ReadAllLines(filePath);
                rowsCount = lines.Length;
                columnsCount = lines[0].Split().Length;
                matrix = new int[rowsCount, columnsCount];

                for (int i = 0; i < lines.Length; i++)
                {
                    var arr = lines[i].Split();
                    for (int j = 0; j < arr.Length; j++)
                    {
                        matrix[i, j] = int.Parse(arr[j]);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Было поймано исключение: {ex.Message}");
            }
        }

        #endregion

        #region Методы

        /// <summary>
        /// Возвращает сумму всех элементов массива
        /// </summary>
        /// <returns></returns>
        public int SumAllElements()
        {
            var sum = 0;
            for (int i = 0; i < rowsCount; i++)
            {
                for (int j = 0; j < columnsCount; j++)
                {
                    sum += matrix[i, j];
                }
            }
            return sum;
        }

        /// <summary>
        /// Возвращает сумму всех элементов массива больше заданного
        /// </summary>

        public int SumAllElementsGreaterN(int limit)
        {
            var sum = 0;
            for (int i = 0; i < rowsCount; i++)
            {
                for (int j = 0; j < columnsCount; j++)
                {
                    if (matrix[i, j] > limit)
                        sum += matrix[i, j];
                }
            }
            return sum;
        }

        /// <summary>
        /// Возвращающает номер максимального элемента массива
        /// </summary>
        /// <param name="row">Номер строки максимального элемента</param>
        /// <param name="column">Номер столбца максимального элемента</param>
        /// <returns></returns>
        public void FindIndexsMaxElement(out int row, out int column)
        {
            var max = int.MinValue;
            row = -1; column = -1;
            for (int i = 0; i < rowsCount; i++)
            {
                for (int j = 0; j < columnsCount; j++)
                {
                    if (matrix[i, j] > max)
                    {
                        max = matrix[i, j];
                        row = i;
                        column = j;
                    }
                }
            }
        }

        public void Print()
        {
            Console.WriteLine(ToString());
            //    for (int i = 0; i < matrix.GetLength(0); i++)
            //    {
            //        for (int j = 0; j < matrix.GetLength(1); j++)
            //        {
            //            Console.Write($"{matrix[i, j]}\t");
            //        }
            //        Console.WriteLine();
            //    }
        }

        public override string ToString()
        {
            var str = new StringBuilder();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    str.Append($"{matrix[i, j]}\t");
                }
                str.Append("\n");
            }
            return str.ToString();
        }

        /// <summary>
        /// Запись матрицы в файл
        /// </summary>
        /// <param name="filePath">Имя файла</param>
        public void WriteToFile(string filePath)
        {
            File.WriteAllText(filePath, ToString());
        }

        #endregion

    }
}
