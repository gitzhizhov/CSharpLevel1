using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_4
{
    //4.	Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль.
    //      На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains).
    //      Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает.
    //      С помощью цикла do while ограничить ввод пароля тремя попытками.
    //4.	Решить задачу с логинами из урока 2, только логины и пароли считать из файла в массив. Создайте структуру Account, содержащую Login и Password.

    // Андрей Жижов
    class Program
    {
        static void Main(string[] args)
        {
            string login;
            string password;
            int i = 3;
            string path = "login.txt";
            bool auth = false;
            string[] loginPass;

            if (!File.Exists(path))
            {
                Console.WriteLine("Ошибка чтения файла");
            }
            else
            {
                loginPass = LoginPass(path);
                do
                {
                    Console.Write("Введите логин: ");
                    login = Console.ReadLine();
                    Console.Write("Введите пароль: ");
                    password = Console.ReadLine();

                    i--;
                    Authentication(loginPass, login, password, ref auth);
                    if (auth)
                    {
                        Console.WriteLine($"Добро пожаловать {login}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Неверный логин или пароль");
                        Console.WriteLine($"осталость попыток: {i}");
                    }
                } while (i > 0);
            }

            if (auth)
            {
                Console.WriteLine("Доступ разрешён");
            }
            else
            {
                Console.WriteLine("Доступ запрещен");
            }

            Console.ReadKey();
        }

        /// <summary>
        /// Метод проверяет совпадения логин и пароля 
        /// </summary>
        /// <param name="dbLogPass">Массиы строк логинов</param>
        /// <param name="login">Введенный логин</param>
        /// <param name="password">Введенный пароль</param>
        /// <param name="auth"></param>
        /// <returns></returns>
        static bool Authentication(string[] dbLogPass, string login, string password, ref bool auth)
        {
            for (int i = 0; i < dbLogPass.Length; i++)
            {
                string[] line = dbLogPass[i].Split(' ');
                if (login == line[0] && password == line[1])
                    auth = true;
            }
            return auth;
        }

        /// <summary>
        /// Метод заполняет массив(строк) из файла
        /// </summary>
        /// <param name="path"></param>
        /// <returns>Массив</returns>
        static string[] LoginPass(string path)
        {
            string[] loginPass = File.ReadAllLines(path);
            return loginPass;
        }
    }



    struct Account
    {
        private string login;
        private string password;

        public Account(string login, string password)
        {
            this.login = login;
            this.password = password;
        }

        public string Login { get => login; set => login = value; }
        public string Password { get => password; set => password = value; }

        public string[,] LoadFile(string path)
        {
            string[] lines = File.ReadAllLines(path);
            string[,] loginPass = new string[lines.Length, lines[0].Split(';').Length];
            for (int i = 0; i < lines.Length; i++)
            {
                string[] row = lines[i].Split(';');
                for (int j = 0; j < row.Length; j++)
                {
                    loginPass[i, j] = row[j];
                }
            }
            return loginPass;
        }
    }

}
