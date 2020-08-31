using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HelperLibrary;

namespace HW1_4
{
    //4.	Написать программу обмена значениями двух переменных:
    //      а) с использованием третьей переменной;
    //      б) * без использования третьей переменной.

    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            int b = 7;
            int tmp;

            Helper.Println("Обмен значений 2-х переменных при помощи третьей");
            Helper.Println($"Значения до замены\t a = {a}  b = {b}");

            tmp = b;
            b = a;
            a = tmp;

            Helper.Println($"Значения после замены\t a = {a}  b = {b}");
            Helper.Pause();

            Helper.Println();

            a = 2;
            b = 8;

            Helper.Println("Обмен значений 2-х переменных без помощи третьей");
            Helper.Println($"Значения до замены\t a = {a}  b = {b}");

            // последовательность действий нашёл в интернете
            a = a + b;
            b = b - a;
            b = -b;
            a = a - b;

            Helper.Println($"Значения после замены\t a = {a}  b = {b}");
            Helper.Pause();

        }
    }
}
