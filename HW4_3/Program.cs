using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_3
{
    //3.	а) Дописать класс для работы с одномерным массивом.
    //      Реализовать конструктор, создающий массив определенного размера и заполняющий массив числами от начального значения с заданным шагом.
    //      Создать свойство Sum, которое возвращает сумму элементов массива, метод Inverse, возвращающий новый массив с измененными знаками у всех элементов массива(старый массив, остается без изменений),  метод Multi, умножающий каждый элемент массива на определённое число, свойство MaxCount, возвращающее количество максимальных элементов.
    //      б)** Создать библиотеку содержащую класс для работы с массивом. Продемонстрировать работу библиотеки
    //      е) *** Подсчитать частоту вхождения каждого элемента в массив(коллекция Dictionary<int, int>)

    // Андрей Жижов
    class Program
    {
        static void Main(string[] args)
        {
            // Использую допущение массивы состоят из целых чисел (int)

            // Создаем массив заданного размера
            ArryaUtil array = new ArryaUtil(20);

            // Создаем массив заданного размера, от начального значения с шагом
            array = new ArryaUtil(4, 1, 3);
            Console.WriteLine();

            // Свойство, возвращает сумму элементов
            int sum = array.Sum;
            Console.WriteLine($"\nСумма элементов массива: {sum}");
            Console.WriteLine();

            array = new ArryaUtil(5, 0, 3);
            // Метод возвращает новый массив с изменненными знаками у всех элементов массива
            ArryaUtil invarr = array.Inverse();
            PrintArray(array);
            Console.WriteLine();
            PrintArray(invarr);

            Console.WriteLine();

            // Метод умножает значение элементов массива на число
            PrintArray(array.Multi(2));

            Console.WriteLine();

            // Метод заполняет массив случайными числами из диапазона 
            array = new ArryaUtil(15);
            array.FullArray(0, 10);
            PrintArray(array.Array);

            Console.WriteLine();

            //Подсчет частоты вхождения каждого элемента в массиве
            Dictionary<int, int> keyValues = ArryaUtil.Countries(array.Array);

            foreach (KeyValuePair<int, int> keyValue in keyValues)
            {
                Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
            }

            Console.ReadKey();
        }

        /// <summary>
        /// Выводит элементы массива
        /// </summary>
        /// <param name="array"></param>
        static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
        }

        /// <summary>
        /// Выводит элементы массива
        /// </summary>
        /// <param name="array"></param>
        static void PrintArray(ArryaUtil array)
        {
            for (int i = 0; i < array.Size; i++)
            {
                Console.Write($"{array.Array[i]} ");
            }
        }
    }
}
