using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Lesson6
{
    internal class Task2
    {
        public static double F(double x)
        {
            return x * x - 50 * x + 10;
        }

        public static void SaveFunc(string fileName, Func<double, double> func,  double a, double b, double h)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            double x = a;
            while (x <= b)
            {
                bw.Write(func(x));
                x += h;// x=x+h;
            }
            bw.Close();
            fs.Close();
        }

        public static List<double> Load(string fileName, out double min)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            min = double.MaxValue;
            var values = new List<double>();
            double d;
            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {
                // Считываем значение и переходим к следующему
                d = bw.ReadDouble();
                if (d < min) min = d;
                values.Add(d);
            }
            bw.Close();
            fs.Close();
            return values;
        }

        //static void Main(string[] args)
        //{
        //    SaveFunc("data.bin", -100, 100, 0.5);
        //    Console.WriteLine(Load("data.bin"));
        //    Console.ReadKey();
        //}
    }
}
