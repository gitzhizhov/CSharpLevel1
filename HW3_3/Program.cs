using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_3
{
    //3.  * Описать класс дробей - рациональных чисел, являющихся отношением двух целых чисел.Предусмотреть методы сложения, вычитания, умножения и деления дробей.
    //    Написать программу, демонстрирующую все разработанные элементы класса.
    //    ** Добавить проверку, чтобы знаменатель не равнялся 0. Выбрасывать исключение
    //    ArgumentException("Знаменатель не может быть равен 0");
    //    Добавить упрощение дробей

    //    Андрей Жижов

    class Program
    {
        static void Main(string[] args)
        {
            Fraction f1 = new Fraction();
            Fraction f2 = new Fraction();
            Fraction res;

            Console.Write("Введите числитель первой дроби: ");
            f1.Num = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите знаминатель первой дроби: ");
            f1.Den = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите числитель второй дроби: ");
            f2.Num = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите знаменатель второй дроби: ");
            f2.Den = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            res = f1.Plus(f2);
            Console.WriteLine($"{f1} + {f2} = {res}");
            res = f1.Diff(f2);
            Console.WriteLine($"{f1} - {f2} = {res}");
            res = f1.Multi(f2);
            Console.WriteLine($"{f1} * {f2} = {res}");
            res = f1.Divis(f2);
            Console.WriteLine($"{f1} / {f2} = {res}");

            Console.ReadKey();
        }
    }
}
