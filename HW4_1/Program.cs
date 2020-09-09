using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_1
{
    //1.	Дан целочисленный  массив из 20 элементов. Элементы массива  могут принимать  целые значения  от –10 000 до 10 000 включительно.
    //      Заполнить случайными числами. Написать программу, позволяющую найти и вывести количество пар элементов массива, в которых только одно число делится на 3.
    //      В данной задаче под парой подразумевается два подряд идущих элемента массива. Например, для массива из пяти элементов: 6; 2; 9; –3; 6 ответ — 2. 

    // Андрей Жижов
    class Program
    {
        static void Main(string[] args)
        {
            int count;
            int min = -10_000;
            int max = 10_000;

            int[] array = new int[20];

            FullArray(min, max, array);

            Console.WriteLine();

            count = PairOfElem(array);
            Console.WriteLine($"Количество пар элементов массива, в которых только одно число делится на 3 равно {count}");

            Console.ReadKey();
        }

        /// <summary>
        /// Метод заполняющий массив случайными числами из диапазона
        /// </summary>
        /// <param name="min">минимальное число</param>
        /// <param name="max">максимальное число</param>
        /// <param name="array">размерность массива</param>
        private static void FullArray(int min, int max, int[] array)
        {
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(min, max + 1);
                //Console.Write($"{array[i]} ");
            }
        }

        /// <summary>
        /// Ищет в массиве пару элементов в которых только одно число делится на 3.
        /// </summary>
        /// <param name="array"></param>
        /// <returns>Выводит количество пар</returns>
        private static int PairOfElem(int[] array)
        {
            int count = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if ((array[i] % 3 == 0 && array[i + 1] % 3 != 0) || (array[i] % 3 != 0 && array[i + 1] % 3 == 0))
                {
                    count++;
                    //Console.WriteLine($"{array[i]} {array[i + 1]}");
                }
            }
            return count;
        }
    }
}
