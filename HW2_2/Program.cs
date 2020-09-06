using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HelperLibrary;

namespace HW2_2
{
    // 2.	Написать метод подсчета количества цифр числа.

    class Program
    {
        static void Main(string[] args)
        {
            long a;
            int length;
            string ending = "";

            Helper.Print("Введите число: ");
            a = Helper.CheckLong();

            length = a.ToString().Length;

            if ((length % 10 == 1 && length != 11) || length == 1)
            {
                ending = "а";
            }
            if ((length % 10 >= 2 && length % 10 <= 4) || (length >= 2 && length <= 4))
                ending = "ы";
            if (length % 10 >= 5 || (length >= 11 && length <= 20) || length >= 5)
                ending = "";

            // пока не работает окончание

            Helper.Println($"В введенном числе {length} цифр{ending}");
            Helper.Pause();
        }
    }
}
