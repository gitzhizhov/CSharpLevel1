using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HelperLibrary;

namespace HW1_3
{
    //3.    а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2).
    //         Вывести результат, используя спецификатор формата .2f(с двумя знаками после запятой);
    //      б) * Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.

    class Program
    {
        static void Main(string[] args)
        {
            double x1;
            double x2;
            double y1;
            double y2;
            double r;

            //координаты первой точки
            x1 = 4;
            y1 = 6;

            //координаты второй точки
            x2 = 3;
            y2 = 14;

            r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            Console.WriteLine("Расстояние между точками: {0:F2}", r);

            Helper.Pause();

        }
    }
}
