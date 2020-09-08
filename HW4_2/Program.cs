using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_2
{
    //2.	Реализуйте задачу 1 в виде статического класса StaticClass;
    //      а) Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1;
    //      б) * Добавьте статический метод для считывания массива из текстового файла. Метод должен возвращать массив целых чисел;
    //      в)** Добавьте обработку ситуации отсутствия файла на диске.

    // Андрей Жижов
    class Program
    {
        static void Main(string[] args)
        {
            string path = "array.csv";

            if (!File.Exists(path))
            {
                Console.WriteLine($"Указынный файл {path} отсутствует!");
            }
            else
            {
                int[] array = ReadFile(path);
                if (array.Length < 2)
                {
                    Console.WriteLine("Массив содержит меннее 2-х элементов");
                }
                else
                {
                    ArrayClass.PairOfElem(array);
                }
            }

            Console.ReadKey();
        }

        /// <summary>
        /// Считывает файл с числами через ';'.
        /// </summary>
        /// <param name="path">Путь до файла</param>
        /// <param name="fileExists">Файл существует</param>
        /// <returns>Массив целых чисел</returns>
        static int[] ReadFile(string path)
        {
            int[] array = new int[0];
            StreamReader sr = new StreamReader(path);
            while (!sr.EndOfStream)
            {
                string text = sr.ReadLine();
                string[] arr = text.Split(';');
                array = new int[arr.Length];
                for (int i = 0; i < arr.Length; i++)
                {
                    array[i] = Convert.ToInt32(arr[i]);
                }
            }
            return array;
        }
    }
}
