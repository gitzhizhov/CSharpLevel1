using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HelperLibrary;

namespace HW2_4
{
    //4.  Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль.
    //    На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains).
    //    Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает.
    //    С помощью цикла do while ограничить ввод пароля тремя попытками.

    class Program
    {
        static string correctLogin = "root";
        static string correctPassword = "GeekBrains";
        static bool auth = false;

        static void Main(string[] args)
        {
            string login;
            string password;
            int i = 3;

            do
            {
                Helper.Print("Введите логин: ");
                login = Console.ReadLine();
                Helper.Print("Введите пароль: ");
                password = Console.ReadLine();

                i--;
                authentication(login, password, i);
                if (auth)
                {
                    break;
                }
            } while (i > 0);

            Helper.Pause();
        }

        static bool authentication(string login, string pass, int i)
        {
            string attempt = null;
            if (login == correctLogin && pass == correctPassword)
            {
                Helper.Println("Доступ разрешён");
                auth = true;
            }
            else
            {
                setAttempt(i, ref attempt);
                Helper.Println($"Связка логина и паролья не совпадает, осталось {i} {attempt}");
                Helper.Println();
            }
            return auth;
        }

        static void setAttempt(int i, ref string _attempt)
        {
            switch (i)
            {
                case 2:
                    _attempt = "попытки.";
                    break;
                case 1:
                    _attempt = "попытка.";
                    break;
                case 0:
                    _attempt = "попыток.";
                    break;
            }
        }
    }
}
