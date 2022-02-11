using System;
using System.IO;

namespace Lesson4
{
    /// <summary>
    /// 4. Решить задачу с логинами из урока 2, только логины и пароли считать из файла в массив. Создайте структуру Account, 
    /// содержащую Login и Password.
    /// </summary>
    internal class Task4
    {
        internal static Account[] ReadAuthorizationData(string fileName, string path)
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
                var accounts = new Account[lines.Length];
                for (int i = 0; i < lines.Length; i++)
                {
                    var data = lines[i].Split();
                    accounts[i] = new Account(data[0], data[1]);
                }
                return accounts;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Было поймано исключение: {ex.Message}");
                return null;

            }

        }

        internal static void LogIn(Account[] accounts)
        {
            var counter = 1;
            bool access = false;
            while (counter != 4 && !access && counter <= accounts.Length)
            { 
                access = Attempt(accounts[counter-1].Login, accounts[counter-1].Password);
                if (!access)
                {
                    Console.WriteLine($"Данные неверные. Совершено {counter} попыток\n");
                    counter++;
                }
            } 

            if(!access && counter > accounts.Length)
            {
                Console.WriteLine("Перебраны все авторизационные данные. Доступ запрещен.");
                return;
            }

            if (counter == 4)
            {
                Console.WriteLine("Использованы все попытки. Доступ запрещен.");
                return;
            }

            Console.WriteLine("\nПрограмма выполняется...");
        }
        private static bool Attempt(string login, string password)
        {
            return login == "root" && password == "GeekBrains";
        }
    }
}