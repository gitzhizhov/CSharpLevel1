using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HelperLibrary;

namespace HW2_7
{
    //7.  a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b);

    //    б) * Разработать рекурсивный метод, который считает сумму чисел от a до b.

    class Program
    {
        static int a;
        static int b;

        static void Main(string[] args)
        {
            do
            {
                Helper.Print("Введите первое число ");
                a = Helper.CheckInt();
                Helper.Print("Введите второе число ");
                b = Helper.CheckInt();

                if (a >= b)
                    Helper.Println("Первое число должно быть меньше второго числа");

                Helper.Println();
            } while (a >= b);

            recursion(a, b);
            recursionSum(a, b, 0);

            Helper.Pause();
        }

        /// <summary>
        /// Выводит числа от a до b.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static int recursion(int a, int b)
        {
            if (a <= b)
            {
                Helper.Println($"{a}");
                return recursion(a + 1, b);
            }
            return b;
        }

        /// <summary>
        /// Возвращает сумму чисел от a до b
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static long recursionSum(int a, int b, long sum)
        {
            if (a == b)
            {
                Helper.Println($"\nСумма чисел равна {sum}");
                return sum;
            }
            else
            {
                sum += a;
                a++;
                return recursionSum(a, b, sum);
            }
        }
    }
}
