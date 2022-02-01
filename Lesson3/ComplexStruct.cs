using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson3
{
    /// Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры.
    public struct ComplexStruct
    {
        double im;
        double re; 

        public ComplexStruct(double re, double im)
        {
            this.im = im;
            this.re = re;
        }

        public static ComplexStruct operator+(ComplexStruct x1, ComplexStruct x2)
        {
            ComplexStruct x3 = new ComplexStruct();
            x3.im = x2.im + x1.im;
            x3.re = x2.re + x1.re;
            return x3;
        }

        public static ComplexStruct operator*(ComplexStruct x1, ComplexStruct x2)
        {
            ComplexStruct x3 = new ComplexStruct();
            x3.re = x1.re * x1.re - x1.im * x2.im;
            x3.im = x1.re * x2.im + x1.im * x2.re;
            return x3;
        }

        public static ComplexStruct operator-(ComplexStruct x1, ComplexStruct x2)
        {
            ComplexStruct x3 = new ComplexStruct();
            x3.im = x1.im - x2.im;
            x3.re = x1.re - x2.re;
            return x3;
        }

        public override string ToString()
        {
            // Нет мнимой части
            if (im == 0)
                return re.ToString();
            // Нет действительной части
            if (re == 0)
                return
                    // Если множитель мнимой части равен 1, то не пишем его
                    // А если множитель равен -1, то пишем только знак
                    (im == 1 ? "" : (im == -1 ? "-" : im.ToString()))
                    + "i";
            return re
                + (im > 0 ? "+" : "-")
                // Если множитель мнимой части равен 1/-1, то не пишем его
                + (Math.Abs(im) == 1 ? "" : Math.Abs(im).ToString())
                + "i";
        }

    }
}
