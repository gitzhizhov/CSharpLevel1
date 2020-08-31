using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HelperLibrary;

namespace HW2_5
{
    //5.  а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или все в норме;
    //    б) * Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.

    class Program
    {
        static void Main(string[] args)
        {
            double m; // вес
            double h; // рост
            double bmi;
            string msg;
            double deviation;

            double bmiNormMin = 18.5;
            double bmiNormMax = 25;

            msg = "Введите вес человека в килограммах: ";
            Helper.Print(msg);
            m = Helper.CheckDouble();
            msg = "Введите рост человека в метрах: ";
            Helper.Print(msg);
            h = Helper.CheckDouble();

            bmi = Math.Round(m / (h * h), 2);

            if (bmi < bmiNormMin)
            {
                deviation = (bmiNormMin - bmi) * Math.Pow(h, 2);
                msg = $"Для нормализации веса Вам нужно набрать {Math.Round(deviation, 2)} кг.";
                Helper.Println(msg);
            }
            else if (bmi > bmiNormMax)
            {
                deviation = (bmi - bmiNormMax) * Math.Pow(h, 2);
                msg = $"Для нормализации веса Вам нужно похудеть на {Math.Round(deviation, 2)} кг.";
                Helper.Println(msg);
            }
            else
            {
                msg = $"Индекс массы тела у Вас в норме.";
                Helper.Println(msg);
            }

            Helper.Pause();
        }
    }
}
