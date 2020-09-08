using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_3
{
    class ArryaUtil
    {
        private int size;
        private int[] array;
        private int sum;

        public int Size
        {
            get
            {
                size = array.GetLength(0);
                return size;
            }
        }
        public int[] Array { get => array; }

        /// <summary>
        /// Свойство, возвращает сумму элементов массива.
        /// </summary>
        public int Sum
        {
            get
            {
                this.sum = 0;
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    this.sum += array[i];
                }
                return sum;
            }
        }

        public ArryaUtil() { }

        /// <summary>
        /// Конструктор, создающий массив заданного размера.
        /// </summary>
        /// <param name="size"></param>
        public ArryaUtil(int size)
        {
            this.array = new int[size];
        }

        /// <summary>
        /// Заполняет массив заданного размера случайными элементами из диапазона
        /// </summary>
        /// <param name="min">Минимальное значение</param>
        /// <param name="max">Максимальное значение</param>
        /// <param name="array">Размер создаваемого массива</param>
        public void FullArray(int min, int max)
        {
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(min, max + 1);
            }
        }

        /// <summary>
        /// Конструктор, создающий массив заданного размера, от начального значения с шагом.
        /// </summary>
        /// <param name="size">Размер массива</param>
        /// <param name="begin">Начальный элемент</param>
        /// <param name="step">Шаг</param>
        public ArryaUtil(int size, int begin, int step)
        {
            this.array = new int[size];
            array[0] = begin;
            for (int i = 1; i < array.Length; i++)
            {
                array[i] = array[i - 1] + step;
            }
        }

        /// <summary>
        /// Возвращающий новый массив с измененными знаками у всех элементов массива
        /// </summary>
        /// <returns>Массив</returns>
        public ArryaUtil Inverse()
        {
            ArryaUtil inverseArray = new ArryaUtil(array.Length);
            for (int i = 0; i < array.Length; i++)
            {
                inverseArray.Array[i] = this.Array[i] * -1;
            }
            return inverseArray;
        }

        /// <summary>
        /// Перемножает каждый элемент массива на число
        /// </summary>
        /// <param name="x"></param>
        /// <returns>Массив</returns>
        public int[] Multi(int x)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = array[i] * x;
            }
            return array;
        }

        /// <summary>
        /// Свойство, возвращает значение максимального элемента.
        /// </summary>
        public int Max
        {
            get
            {
                int max = 0;
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    if (array[i] > max)
                        max = array[i];
                }
                return max;
            }
        }

        /// <summary>
        /// Свойство, возвращает кол-во элементов максимального значения
        /// </summary>
        public int MaxCount
        {
            get
            {
                int maxCount = 0;
                int max = Max;
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    if (array[i] == max)
                        maxCount++;
                }
                return maxCount;
            }
        }

        /// <summary>
        /// Подсчитывает частоту вхождения каждого элемента в массиве
        /// </summary>
        /// <param name="arr">Массив</param>
        /// <returns>Коллекцию</returns>
        public static Dictionary<int, int> Countries(int[] arr)
        {
            Dictionary<int, int> countries = new Dictionary<int, int>(arr.Length);
            int[] counter = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                int index = arr[i];
                counter[index]++;
            }
            for (int i = 0; i < counter.Length; i++)
            {
                countries.Add(i, counter[i]);
            }
            return countries;

            // данный метод не работает если диапазон больше размерности массива
        }
    }
}
