using System;

namespace Lesson3
{
    internal class Task3
    {
        static Random randomizer = new Random();
        //3. *Описать класс дробей — рациональных чисел, являющихся отношением двух целых чисел.
        //            Предусмотреть методы сложения, вычитания, умножения и деления дробей. 
        //            Написать программу, демонстрирующую все разработанные элементы класса.
        //            Добавить свойства типа int для доступа к числителю и знаменателю;
        //        Добавить свойство типа double только на чтение, чтобы получить десятичную дробь числа; 
        //        ** Добавить проверку, чтобы знаменатель не равнялся 0. Выбрасывать исключение ArgumentException("Знаменатель не может быть равен 0"); 
        //        *** Добавить упрощение дробей.
        internal static void Demonstration()
        {
            var a = new Fraction(randomizer.Next(-10, 10), randomizer.Next(1, 10));
            var b = new Fraction(GenerateNumeratorWithoutZero(), randomizer.Next(1, 10));
            Console.WriteLine($"Входные значения: a = {a}, b = {b}");
            Console.WriteLine($"Результат сложения: {a + b}");
            Console.WriteLine($"Результат вычитания: {a - b}");
            Console.WriteLine($"Результат умножения: {a * b}");
            Console.WriteLine($"Результат деления: {a / b}");
            Console.WriteLine($"Десятичный вид: a = {a.DecimalValue}, b = {b.DecimalValue}");
            Console.WriteLine($"Упрощение дробей: a = {a.Simplification()}, b = {b.Simplification()}");
            Console.WriteLine($"Упрощение дробей (c = 24/96): {new Fraction(24, 96).Simplification()}");
            Console.WriteLine("Проверка на присваивание знаменателю 0:");
            try
            {
                a.Denominator = 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        // Исключаем нулевой числитель у второй переменной, чтобы можно было выполнить деление
        private static int GenerateNumeratorWithoutZero()
        {
            var cur = 0;
            while(cur == 0)
            {
                cur = randomizer.Next(-10, 10);
            }
            return cur;
        }
    }
}