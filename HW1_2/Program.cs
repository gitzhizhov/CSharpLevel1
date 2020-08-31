using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HelperLibrary;
namespace HW1_2
{
    //2.    Ввести вес и рост человека.Рассчитать и вывести индекс массы тела(ИМТ) по формуле I=m/(h* h); где m — масса тела в килограммах, h — рост в метрах.

    class Program
    {
        static void Main(string[] args)
        {
            double m; // вес
            double h; // рост

            Helper.Print("Введите вес человека в килограммах (например 78,2): ");
            m = double.Parse(Console.ReadLine());
            Helper.Print("Введите рост человека в метрах (например 1,76): ");
            h = Convert.ToDouble(Console.ReadLine());

            double i = Math.Round(m / (h * h), 2);

            Helper.Println();
            Helper.Println($"ИМТ равен: {i}");
            Helper.Pause();

        }
    }
}
