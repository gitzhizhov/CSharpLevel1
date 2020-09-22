using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HW8_1
{
    // 1.	С помощью рефлексии выведите все свойства структуры DateTime

    // Андрей Жижов
    class Program
    {
        /// <summary>
        /// Метод возвращает свойства объета
        /// </summary>
        /// <param name="obj"></param>
        static void GetPropertysInfo(object obj)
        {
            string typeString = obj.GetType().ToString();
            Type getType = Type.GetType(typeString, false, true);
            foreach (var item in getType.GetProperties())
            {
                Console.WriteLine($"{item.PropertyType} {item.Name}");
            }
        }

        static void Main(string[] args)
        {
            DateTime dateTime = new DateTime();

            Console.WriteLine("Свойства:");
            GetPropertysInfo(dateTime);

            Console.ReadKey();
        }
    }
}
