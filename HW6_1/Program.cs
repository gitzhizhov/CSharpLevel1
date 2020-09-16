using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW6_1
{
    //1.    Изменить программу вывода таблицы функции так, чтобы можно было передавать функции типа double (double, double).
    //      Продемонстрировать работу на функции с функцией a* x^2 и функцией a* sin(x).

    // Андрей Жижов


    // Описываем делегат. В делегате описывается сигнатура методов, на
    // которые он сможет ссылаться в дальнейшем (хранить в себе)
    public delegate double Fun(double a, double x);

    class Program
    {
        // Создаем метод, который принимает делегат
        // На практике этот метод сможет принимать любой метод
        // с такой же сигнатурой, как у делегата
        public static void Table(Fun F, double a, double x, double b)
        {
            Console.WriteLine("----- A ------- X -------- Y -----");
            while (x <= b)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} | {2,8:0.000}", a, x, F(a, x));
                x += 1;
            }
            Console.WriteLine("---------------------");
        }


        public static double Functoin1(double a, double x)
        {
            return a * x * x;
        }

        public static double Functoin2(double a, double x)
        {
            return a * Math.Sin(x);
        }

        static void Main()
        {
            // Создаем новый делегат и передаем ссылку на него в метод Table
            Console.WriteLine("Таблица функции MyFunc:");
            // Параметры метода и тип возвращаемого значения, должны совпадать с делегатом
            Table(new Fun(Functoin1), 1, -2, 2);
            Console.WriteLine("Еще раз та же таблица, но вызов организован по новому");
            // Упрощение(c C# 2.0).Делегат создается автоматически. 
            Table(Functoin1, -1, -2, 2);
            Console.WriteLine("Таблица функции a*x^2:");
            // Упрощение(с C# 2.0). Использование анонимного метода
            Table(delegate (double x, double a) { return a* x * x; }, 1, 0, 3);
            Table(Functoin2, -1, -2, 2);

            Console.ReadKey();
        }
    }
}
