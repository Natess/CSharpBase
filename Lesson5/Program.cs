using System;
using System.IO;
using Utils;

namespace Lesson5
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
                Console.WriteLine("4 => Задача 4");
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
                    default:
                        Console.WriteLine("Некорректный номер задачи.\nПовторите попытку ввода.");
                        break;
                }
            }

            ConsoleHelper.Pause();
        }


        //4. Задача ЕГЭ.
        //На вход программе подаются сведения о сдаче экзаменов учениками 9-х классов некоторой средней школы.
        //В первой строке сообщается количество учеников N, которое не меньше 10, но не превосходит 100, каждая из следующих N строк имеет следующий формат:
        //<Фамилия> <Имя> <оценки>,
        //где<Фамилия> — строка, состоящая не более чем из 20 символов, <Имя> — строка, состоящая не более чем из 15 символов,
        //<оценки> — через пробел три целых числа, соответствующие оценкам по пятибалльной системе.
        //<Фамилия> и<Имя>, а также <Имя> и<оценки> разделены одним пробелом. Пример входной строки:
        //Иванов Петр 4 5 3
        //Требуется написать как можно более эффективную программу, которая будет выводить на экран фамилии и имена трёх худших по среднему баллу учеников.
        //Если среди остальных есть ученики, набравшие тот же средний балл, что и один из трёх худших, следует вывести и их фамилии и имена.
        private static void RunTask4()
        {
            ConsoleHelper.PrintInCentre("Задание 4");
            Console.WriteLine("Худшие ученики и их средний бал:");
            Console.WriteLine(Task4.ExamAnalysWorstStudents(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "students_result.txt")));
            Console.WriteLine("Список всех учеников, с вычисленным средним баллом (для проверки):");
            Console.WriteLine(Task4.ForCheck(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "students_result.txt")));
            Console.WriteLine("\n====================================");
        }

        //3. *Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой.
        private static void RunTask3()
        {
            ConsoleHelper.PrintInCentre("Задание 3");
            Console.WriteLine($"Проверка является ли слово \"adda\" перестановкой слова \"dada\": {Message.IsPermutation("adda", "dada")}");
            Console.WriteLine($"Проверка является ли слово \"adda\" перестановкой слова \"ada\": {Message.IsPermutation("adda", "ada")}");
            Console.WriteLine($"Проверка является ли слово \"adda\" перестановкой слова \"adad\": {Message.IsPermutation("adda", "adad")}");
            Console.WriteLine($"Проверка является ли слово \"adda\" перестановкой слова \"\": {Message.IsPermutation("adda", "")}");
            Console.WriteLine($"Проверка является ли слово \"adda\" перестановкой слова \"abba\": {Message.IsPermutation("adda", "abba")}");

            Console.WriteLine("\n====================================");
        }

        //2. Разработать статический класс Message, содержащий следующие статические методы для обработки текста:
        //    а) Вывести только те слова сообщения, которые содержат не более n букв.
        //    б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
        //    в) Найти самое длинное слово сообщения.
        //    г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
        //    д) ***Создать метод, который производит частотный анализ текста.В качестве параметра в него передается массив слов и текст, 
        //        в качестве результата метод возвращает сколько раз каждое из слов массива входит в этот текст.
        //        Здесь требуется использовать класс Dictionary.
        private static void RunTask2()
        {
            ConsoleHelper.PrintInCentre("Задание 2");
            var message = @"У лукоморья дуб зелёный;
Златая цепь на дубе том:
И днём и ночью кот учёный
Всё ходит по цепи кругом;
Идёт направо — песнь заводит,
Налево — сказку говорит.
Там чудеса: там леший бродит,
Русалка на ветвях сидит;
Там на неведомых дорожках
Следы невиданных зверей;
Избушка там на курьих ножках
Стоит без окон, без дверей;...";
            
            Console.WriteLine($"Обработка \"{message}\"...");
            Console.WriteLine();
            Console.WriteLine($"Слова, которые содержат не более 5 букв:");
            Message.PrintWordsWithLessThanNLetters(message, 5);
            Console.WriteLine();

            Console.WriteLine($"Удалить из сообщения все слова, которые заканчиваются на заданный символ \"м\":");
            Console.WriteLine(Message.RemoveAllWordsWitnEndCharacter(message, 'м'));
            Console.WriteLine();

            Console.WriteLine($"Найти самое длинное слово сообщения:");
            Console.WriteLine(Message.FindTheLongestWord(message));
            Console.WriteLine();

            Console.WriteLine($"Сформировать строку с помощью StringBuilder из самых длинных слов сообщения:");
            Console.WriteLine(Message.LongestWordsOfMessage(message));
            Console.WriteLine();

            Console.WriteLine($"Частотный анализ слов \"и\", \"цепь\", \"собака\", \"без\":");
            var dictionary = Message.TextFrequencyAnalysis(new string[] { "и", "цепь", "собака", "без" }, message);
            foreach (var d in dictionary)
            {
                Console.WriteLine($"{d.Key}={d.Value}");
            }
            Console.WriteLine("\n====================================");
        }

        // 1. Создать программу, которая будет проверять корректность ввода логина.Корректным логином будет строка от 2 до 10 символов,
        //  содержащая только буквы латинского алфавита или цифры, при этом цифра не может быть первой:
        //        а) без использования регулярных выражений;
        //        б) **с использованием регулярных выражений.
        private static void RunTask1()
        {
            ConsoleHelper.PrintInCentre("Задание 1");
            var logins = new string[] { "a", "a0123456789", "1ada", "ada1!", "!ada", "password", "qwerty123" };
            foreach (var login in logins)
            {
                Console.WriteLine($"Проверка \"{login}\"...");
                Console.WriteLine($"Результат проверки метода без регулярных выражений:{Task1.LoginIsValid(login)}");
                Console.WriteLine($"Результат проверки метода с регулярными выражениями:{Task1.LoginIsValidWithRegex(login)}");
                Console.WriteLine();
            }
            Console.WriteLine("\n====================================");
        }
    }
}
