using System;

namespace HW6_2
{
    /// <summary>
    /// Структура хранит методы функций
    /// </summary>
    struct Functoins
    {
        static public double F1(double x)
        {
            return x * x - 50 * x + 10;
        }

        static public double F2(double x)
        {
            return (x * x) / 4 - x * x * x;
        }

        static public double F3(double x)
        {
            return Math.Pow(x - 1, 3);
        }
    }
}
