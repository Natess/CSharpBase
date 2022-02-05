using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson4
{
    internal struct Account
    {
        public string Login;
        public string Password;

        public Account(string login, string password) 
        {
            Login = login;
            Password = password;
        }

        public override string ToString()
        {
            return $"Логин = {Login}; Пароль = {Password}";
        }
    }
}
