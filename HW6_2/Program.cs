using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW6_2
{
    //2.    Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию в виде делегата.
    //      а) Сделать меню с различными функциями и представить пользователю выбор, для какой функции и на каком отрезке находить минимум.
    //      Использовать массив(или список) делегатов, в котором хранятся различные функции.
    //      б) * Переделать функцию Load, чтобы она возвращала массив считанных значений.
    //      Пусть она возвращает минимум через параметр(с использованием модификатора out). 

    // Андрей Жижов

    class Program
    {
        /// <summary>
        /// Делегат функции с сигнатурой double
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public delegate double Fun(double x);

        /// <summary>
        /// Расчет значений переданной функции, запись в файл в бинарном потоке
        /// </summary>
        /// <param name="fileName">Имя файла</param>
        /// <param name="start">Начало отрезка</param>
        /// <param name="end">Конец отрезка</param>
        /// <param name="step">Шаг</param>
        public static void SaveFunc(string fileName, double start, double end, double step, Fun F)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            double x = start;
            while (x <= end)
            {
                bw.Write(F(x));
                x += step;// x=x+h;
            }
            bw.Close();
            fs.Close();
        }

        /// <summary>
        /// Чтение файла, нахождение минимума
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static double[] Load(string fileName, out double min)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            min = double.MaxValue;
            double[] array = new double[fs.Length / sizeof(double)];
            double d;
            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {
                // Считываем значение и переходим к следующему
                d = bw.ReadDouble();
                array[i] = d;
                if (d < min) min = d;
            }
            bw.Close();
            fs.Close();
            return array;
        }

        /// <summary>
        /// Метод возвращает выбранную функцию списка
        /// </summary>
        /// <param name="listFunc"></param>
        /// <returns></returns>
        private static Fun GetFunc(List<Fun> listFunc)
        {
            int max = listFunc.Count;
            while (true)
            {
                //int x = Convert.ToInt32(Console.ReadLine());
                if (!int.TryParse(Console.ReadLine(), out int x) || x > max)
                {
                    Console.Clear();
                    Console.WriteLine($"Введите целое число 1 до {max}.");
                    Console.WriteLine("Повторите ввод.");
                    Console.WriteLine();
                    Welcome();
                }
                else
                    return listFunc[x - 1];
            }
        }

        private static void SetInterval(out double start, out double end)
        {
            Console.WriteLine();
            Console.WriteLine("Задайте отрезок для нахождения минимума функции: ");
            Console.Write("Введите начало отрезка: ");
            start = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите конец отрезка: ");
            end = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
        }

        /// <summary>
        /// Вывод результата
        /// </summary>
        /// <param name="values"></param>
        private static void Print(double start, double end, double step, double[] values)
        {
            Console.WriteLine("------- X ------- Y -----");
            int index = 0;
            while (start <= end)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} ", start, values[index]);
                start += step;
                index++;
            }
            Console.WriteLine("--------------------------");
        }

        /// <summary>
        /// Приветствие
        /// </summary>
        private static void Welcome()
        {
            Console.WriteLine("Выберете функция для работы.");
            Console.WriteLine("1: x^2 - 50*x + 10");
            Console.WriteLine("2: (x^2) / 4 - x^3");
            Console.WriteLine("3: (x-1)^3");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            double start = 0;
            double end = 0;
            double step = 0.5;
            string path = "data.bin";
            double min = double.MaxValue;

            List<Fun> listFunc = new List<Fun>();
            listFunc.Add(Functoins.F1);
            listFunc.Add(Functoins.F2);
            listFunc.Add(Functoins.F3);

            Welcome();
            Fun useFunc = GetFunc(listFunc);
            SetInterval(out start, out end);

            SaveFunc(path, start, end, step, useFunc);
            Print(start, end, step, Load(path, out min));
            Console.WriteLine($"Минимальное значение = {min}");

            Console.ReadKey();
        }
    }
}
