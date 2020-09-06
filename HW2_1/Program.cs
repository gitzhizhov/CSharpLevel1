using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HelperLibrary;

namespace HW2_1
{
    // 1.	Написать метод, возвращающий минимальное из трёх чисел.

    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;
            string min = null;

            Helper.Print("Веедите первое число: ");
            a = Helper.CheckInt();
            Helper.Print("Веедите второе число: ");
            b = Helper.CheckInt();
            Helper.Print("Веедите третье число: ");
            c = Helper.CheckInt();

            if (a < b && a < c)
                min = a.ToString();
            else
            {
                if (b < c)
                    min = b.ToString();
                else
                    min = c.ToString();
            }
            Helper.Println($"Минимальное число: {min}");
            Helper.Pause();
        }
    }
}
