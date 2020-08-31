using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HelperLibrary;

namespace HW1_5
{
    //5.	а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
    //      б) * Сделать задание, только вывод организовать в центре экрана.
    //      в) ** Сделать задание б с использованием собственных методов(например, Print(string ms, int x, int y).

    class Program
    {
        static void Main(string[] args)
        {
            string firstName;
            string lastName;
            string city;
            string msg;
            int lengthMsg;

            firstName = "Андрей";
            lastName = "Жижов";
            city = "Пермь";
            msg = $"{firstName} {lastName} {city}";
            lengthMsg = msg.Length;

            Print($"{msg}", (Console.WindowWidth - lengthMsg) / 2, Console.WindowHeight / 2);
            Helper.Pause();
        }

        static void Print(string msg, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Helper.Println(msg);
        }
    }
}
