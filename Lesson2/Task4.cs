using System;

namespace Lesson2
{
    internal class Task4
    {
        //Реализовать метод проверки логина и пароля.На вход метода подается логин и пароль. 
        //На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). 
        //Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает.
        // С помощью цикла do while ограничить ввод пароля тремя попытками.
        internal static void Authorization()
        {
            var counter = 1;
            bool access;
            do
            {
                Console.WriteLine("Введите логин:");
                var login = Console.ReadLine();
                Console.WriteLine("Введите пароль:");
                var password = Console.ReadLine();

                access = Attempt(login, password);
                if (!access)
                {
                    Console.WriteLine($"Данные неверные. Совершено {counter} попыток\n");
                    counter++;
                }
            } while (counter != 4 && !access);

            if (counter == 4)
            {
                Console.WriteLine("Использованы все попытки. Доступ запрещен.");
                return;
            }

            Console.WriteLine("\nПрограмма выполняется");
        }

        private static bool Attempt(string login, string password)
        {
            return login == "root" && password == "GeekBrains";
        }
    }
}