using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW6_4
{
    //4.	** Считайте файл различными способами. Смотрите “Пример записи файла различными способами”.
    //      Создайте методы, которые возвращают массив byte (FileStream, BufferedStream), строку для StreamReader и массив int для BinaryReader.

    // Андрей Жижов
    class Program
    {
        static void Main(string[] args)
        {
            string file = "text.txt";

            Console.ReadKey();
        }

        /// <summary>
        /// Читает файл. Возвращает массив байт.
        /// </summary>
        /// <param name="path"></param>
        /// <returns>Массив байт</returns>
        static byte[] FileStreamText(string path)
        {
            FileStream fs = new FileStream(path, FileMode.Open);
            byte[] arrayByte = new byte[fs.Length];
            try
            {
                fs.Read(arrayByte, 0, Convert.ToInt32(fs.Length));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                fs.Close();
            }
            return arrayByte;
        }

        /// <summary>
        /// Читает файл. Возвращает массив байт.
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        static byte[] BufferedStreamText(string path)
        {
            BufferedStream bs = new BufferedStream(File.Open(path, FileMode.Open));
            byte[] arrayByte = new byte[bs.Length];
            try
            {
                bs.Read(arrayByte, 0, Convert.ToInt32(bs.Length));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                bs.Close();
            }
            return arrayByte;
        }
        /// <summary>
        /// Читает файл. Возвращает строку.
        /// </summary>
        /// <param name="path"></param>
        /// <returns>Строка</returns>
        static string StreamReaderText(string path)
        {
            string str = null;
            StreamReader sr = new StreamReader(path);
            try
            {
                str = sr.ReadToEnd();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                sr.Close();
            }
            return str;
        }

        /// <summary>
        /// Читает файл. Возвращает массив целых чисел.
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        static int[] BinaryReaderText(string path)
        {
            BinaryReader br = new BinaryReader(File.Open(path, FileMode.Open));
            long size = br.BaseStream.Length;
            int[] arrayBin = new int[size];
            try
            {
                // пока не достигнут конец файла
                // считываем каждое значение из файла
                while (br.PeekChar() > -1)
                {
                    for (int i = 0; i < arrayBin.Length; i++)
                    {
                        arrayBin[i] = br.ReadInt32();
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                br.Close();
            }
            return arrayBin;
        }
    }
}
