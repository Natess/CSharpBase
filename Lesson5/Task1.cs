using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Lesson5
{
    //1. Создать программу, которая будет проверять корректность ввода логина.Корректным логином будет строка от 2 до 10 символов,
    //содержащая только буквы латинского алфавита или цифры, при этом цифра не может быть первой
    internal class Task1
    {
        //а) без использования регулярных выражений;
        internal static object LoginIsValid(string login)
        {
            return 2 <= login.Length && login.Length <= 10
                && !char.IsDigit(login[0])
                && login.All(Char.IsLetterOrDigit);

        }

        //б) ** с использованием регулярных выражений.
        internal static object LoginIsValidWithRegex(string login)
        {
            return Regex.IsMatch(login, @"^[a-zA-Z][a-zA-Z0-9]{1,9}$");
        }
    }
}