using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_2
{
    static class ArrayClass
    {
        /// <summary>
        /// Ищет в массиве пару элементов в которых только одно число делится на 3.
        /// </summary>
        /// <param name="array">Массив</param>
        static public void PairOfElem(int[] array)
        {
            int count = 0;

            for (int i = 0; i < array.Length - 1; i++)
            {
                if ((array[i] % 3 == 0 && array[i + 1] % 3 != 0) || (array[i] % 3 != 0 && array[i + 1] % 3 == 0))
                {
                    count++;
                }
            }

            Console.WriteLine($"Количество пар элементов массива, в которых только одно число делится на 3 равно {count}");
        }
    }
}
