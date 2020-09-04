using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_1
{
    // 1.а) Дописать структуру Complex, добавив метод вычитания комплексных чисел.Продемонстрировать работу структуры;
    //   б) Дописать класс Complex, добавив методы вычитания и произведения чисел.Проверить работу класса;
    
    // Андрей Жижов

    class Program
    {
        static void Main(string[] args)
        {
            #region struct
            Complex c1;
            Complex c2;
            Complex res;

            c1.re = 3;
            c1.im = 23;
            c2.re = 4;
            c2.im = 16;

            Console.WriteLine("Работа струкруты Complex");
            Console.WriteLine();

            //res = Complex.Sum(c1, c2);
            res = c1 + c2;
            Console.WriteLine($"Результат сложения комплексных чисел {c1} и {c2} равен {res}");

            res = Complex.Diff(c1, c2);
            Console.WriteLine($"Разница комплексных чисел {c1} и {c2} равен {res}");
            #endregion

            #region class
            Console.WriteLine();
            Console.WriteLine("Работа класса Complex");
            Console.WriteLine();

            ComplexClass cc1 = new ComplexClass();
            ComplexClass cc2 = new ComplexClass();
            ComplexClass ccRes;

            cc1.Re = 5;
            cc1.Im = 3;
            cc2.Re = 2;
            cc2.Im = 15;

            ccRes = cc1.Multi(cc2);
            Console.WriteLine($"Перемножение комплексных чисел {cc1} и {cc2} равен {ccRes}");
            #endregion

            Console.ReadKey();
        }
    }
}
