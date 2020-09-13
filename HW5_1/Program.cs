using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HW5_1
{
    // 1.    Создать программу, которая будет проверять корректность ввода логина.
    //       Корректным логином будет строка от 2 до 10 символов, содержащая только буквы латинского алфавита или цифры, при этом цифра не может быть первой:
    //       а) без использования регулярных выражений;
    //       б) ** с использованием регулярных выражений.

    class Program
    {
        static void Main(string[] args)
        {
            string login;
            bool check;
            string exit = "quit";

            WelcomeText();

            do
            {
                login = Console.ReadLine();
                if (login == exit)
                    break;

                //CheckLogin1(login, out check);
                CheckLogin2(login, out check);

                if (check)
                {
                    Console.WriteLine("Логин корректный");
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Не корректный логин");
                    WelcomeText();
                }
            } while (true);

            Console.ReadKey();
        }

        /// <summary>
        /// Метод приветствия
        /// </summary>
        private static void WelcomeText()
        {
            Console.WriteLine("Придумайте логин состоящий только буквы латинского алфавита или цифры,");
            Console.WriteLine("при этом цифра не может быть первой и длинной от 2 до 10 символов.");
            Console.WriteLine("Для выхода введите quit");
            Console.Write("Логин: ");
        }

        /// <summary>
        /// Метод проверки корректности создания логин (c использованием регулярных выыражаний)
        /// </summary>
        /// <param name="login">Строка логина</param>
        /// <param name="check"></param>
        private static void CheckLogin2(string login, out bool check)
        {
            string pattern = @"^\D[a-zA-Z0-9]";
            Regex regex = new Regex(pattern);
            check = false;
            char[] log = login.ToCharArray();
            if (login.Length > 1 && login.Length < 10  && regex.IsMatch(login))
                check = true;
        }

        /// <summary>
        /// Метод проверки корректности создания логин (без использования регулярных выыражаний)
        /// </summary>
        /// <param name="login">Строка логина</param>
        /// <param name="check"></param>
        private static void CheckLogin1(string login, out bool check)
        {
            check = false;
            char[] log = login.ToCharArray();
            // проверка на длинну и первый символ не цыфра
            if (login.Length > 1 && login.Length < 10 && !char.IsDigit(login, 0))
            {
                for (int i = 0; i < log.Length; i++)
                    // проверка на латинский алфавит или цыфры
                    if ((log[i] >= 'a' && log[i] <= 'z') || (log[i] >= 'A' && log[i] <= 'Z') || (log[i] >= '1' && log[i] <= '9'))
                        check = true;
            }
        }
    }
}
