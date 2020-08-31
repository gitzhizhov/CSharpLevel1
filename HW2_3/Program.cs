using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HelperLibrary;

namespace HW2_3
{
    //3.	С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.

    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int x;

            while (true)
            {
                Helper.Print("Введите любое число: ");
                x = Helper.CheckInt();

                if (x == 0)
                    break;
                if (x % 2 == 1 && x > 0)
                    sum += x;
            }

            Helper.Println($"Сумма всех нечетных положительных чисел = {sum}");
            Helper.Pause();
        }
    }
}
