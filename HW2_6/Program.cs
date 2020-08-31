using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HelperLibrary;

namespace HW2_6
{
    //6.* Написать программу подсчета количества «Хороших» чисел в диапазоне от 1 до 1 000 000 000.
    //    Хорошим называется число, которое делится на сумму своих цифр.
    //    Реализовать подсчет времени выполнения программы, используя структуру DateTime.

    class Program
    {
        static int sumDigits; // сумма цифр числа

        static void Main(string[] args)
        {
            int count = 0;
            int i = 1;
            int startRange = i;
            int n = 1000000000;
            DateTime start;
            DateTime finish;

            start = DateTime.Now;
            for (i = 1; i < n; i++)
            {
                if (i % getSum(i) == 0)
                {
                    count++;
                }
            }
            finish = DateTime.Now;


            Helper.Println($"Количество «Хороших» чисел в диапазоне от {startRange} до {n}: {count}");
            Helper.Println($"Время выполнения: {finish - start}");
            Helper.Pause();
        }

        /// <summary>
        /// Возвращает сумму цифр числа
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        static int getSum(int i)
        {
            sumDigits = 0;
            while (i > 0)
            {
                sumDigits += i % 10;
                i = i / 10;
            }
            return sumDigits;
        }
    }
}
