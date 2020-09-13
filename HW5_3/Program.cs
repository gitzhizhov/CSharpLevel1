using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5_3
{
    //3.	* Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой.
    //    Например:
    //    badc являются перестановкой abcd.

    // Андрей Жижов

    class Program
    {
        static void Main(string[] args)
        {
            string firstString = "badc";
            string twoString = "abcd";

            bool permutation = ToCompareStrings(firstString, twoString);
            Console.WriteLine($"Строки {firstString} и {twoString} являются перестановкой: {permutation}");

            Console.ReadKey();
        }

        /// <summary>
        /// Метод, определяющий, является ли одна строка перестановкой другой.
        /// </summary>
        /// <param name="s1">Первая строка</param>
        /// <param name="s2">Вторая строка</param>
        /// <returns></returns>
        static bool ToCompareStrings(string s1, string s2)
        {
            char[] charS1 = s1.ToUpper().ToCharArray();
            char[] charS2 = s2.ToUpper().ToCharArray();
            Array.Sort(charS1);
            Array.Sort(charS2);

            return charS1.SequenceEqual(charS2);

            // на просторах интернета нашёл запись с использованием LINQ
            //return s1.Select(Char.ToUpper).OrderBy(x => x).SequenceEqual(s2.Select(Char.ToUpper).OrderBy(x => x));
        }
    }
}
