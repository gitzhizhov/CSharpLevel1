using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperLibrary
{
    //6.	* Создать класс с методами, которые могут пригодиться в вашей учебе(Print, Pause). В итоге сделал библиотеку.

    /// <summary>
    /// Класс помощник
    /// </summary>
    public class Helper
    {
        /// <summary>
        /// Выводит, переданное в качестве параметра, сообщение. Без перевода на новую строку.
        /// </summary>
        /// <param name="msg"></param>
        static public void Print(string msg)
        {
            Console.Write(msg);
        }

        /// <summary>
        /// Выводит пустую строку.
        /// </summary>
        static public void Println()
        {
            Console.WriteLine();
        }

        /// <summary>
        /// Выводит, переданное в качестве параметра, сообщение.
        /// </summary>
        /// <param name="msg"></param>
        static public void Println(string msg)
        {
            Console.WriteLine(msg);
        }

        /// <summary>
        /// Пауза. Ожидает нажатия любой клавиши.
        /// </summary>
        static public void Pause()
        {
            Console.ReadKey();
        }
    }
}
