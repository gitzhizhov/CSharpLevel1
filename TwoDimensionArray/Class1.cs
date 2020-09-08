using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoDimensionArray
{
    public class CTwoDimensionArray
    {
        int[,] array;
        int size;

        public CTwoDimensionArray() {}

        /// <summary>
        /// Конструктор, заполняет массив слычайными числами
        /// </summary>
        /// <param name="col"></param>
        /// <param name="row"></param>
        public CTwoDimensionArray(int col, int row)
        {
            int m = 20;
            array = new int[col, row];
            Random rnd = new Random();

            for (int i = 0; i < col; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    array[col, row] = rnd.Next(m);
                }
            }
        }

        /// <summary>
        /// Конструктор заполняющий массиы из файла
        /// </summary>
        /// <param name="path"></param>
        public CTwoDimensionArray(string path)
        {
            try
            {
                string[] lines = File.ReadAllLines(path);
                int[,] array = new int[lines.Length, lines[0].Split(';').Length];
                for (int i = 0; i < lines.Length; i++)
                {
                    string[] row = lines[i].Split(';');
                    for (int j = 0; j < row.Length; j++)
                    {
                        array[i, j] = Convert.ToInt32(row[j]);
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine($"Что-то пошло не так.");
            }
        }

        /// <summary>
        /// Метод возвращает сумму всех элементов массива
        /// </summary>
        /// <param name="sum"></param>
        /// <returns>Сумма</returns>
        public int Sum(out int sum)
        {
            sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    sum += array[i, j];
                }
            }
            return sum;
        }

        /// <summary>
        /// Метод возвращает сумму всех элементов массива больше заданного
        /// </summary>
        /// <param name="m">Заданное значение</param>
        /// <param name="sum"></param>
        /// <returns>Сумма</returns>
        public int sumMoreThan(ref int m, out int sum)
        {
            sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i,j] < m)
                        sum += array[i, j];
                }
            }
            return sum;
        }

        /// <summary>
        /// Свойство, возвращающее минимальный элемент массива
        /// </summary>
        public int Min
        {
            get
            {
                int min = 0;
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        if (array[i, j] < min)
                            min = array[i, j];
                    }
                }
                return min;
            }
        }

        /// <summary>
        /// Свойство, возвращающее максимальный элемент массива
        /// </summary>
        public int Max
        {
            get
            {
                int max = 0;
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        if (array[i, j] > max)
                        max = array[i, j];
                    }                    
                }
                return max;
            }
        }

        /// <summary>
        /// метод, возвращающий номер максимального элемента массива
        /// </summary>
        /// <param name="index"></param>
        /// <returns>Индекс элемента</returns>
        public string IndexOfMax(out string index)
        {
            index = "";
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] == Max)
                        index = $"{i}{j}";
                }
            }
            return index;
        }

        /// <summary>
        /// Метод записывает массив в указынный файл
        /// </summary>
        /// <param name="path"></param>
        public void SaveToFile(string path)
        {
            try
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    string[] lines = new string[array.GetLength(1)];
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        lines[i] = array[i, j].ToString();
                    }
                    File.WriteAllText(path, string.Join(";", lines));
                }
            }
            catch (Exception)
            {
                Console.WriteLine($"Что-то пошло не так.");
            }
        }
    }
}
