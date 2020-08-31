using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HelperLibrary;

namespace HW1_1
{
    //1.    Написать программу «Анкета». Последовательно задаются вопросы(имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку:
    //       а) используя склеивание;
    //       б) используя форматированный вывод;
	//       в) используя вывод со знаком $.

    class Program
    {
        static void Main(string[] args)
        {
            string firstName;
            string lastName;
            string age;
            int growth;
            double weight;

            Helper.Print("Введите фамилию: ");
            lastName = Console.ReadLine();
            Helper.Print("Введите имя: ");
            firstName = Console.ReadLine();
            Helper.Print("Введите отчество: ");
            age = Console.ReadLine();
            Helper.Print("Введите рост: ");
            growth = Convert.ToInt32(Console.ReadLine());
            Helper.Print("Введите вес: ");
            weight = Convert.ToDouble(Console.ReadLine());

            Helper.Println();
            Console.WriteLine("ФИО: " + lastName + " " + firstName + " " + age + ", рост" + growth +  ", вес" + weight);
            Console.WriteLine("ФИО: {0} {1} {2}, рост {3}, вес {4}", lastName, firstName, age, growth, weight);
            Console.WriteLine($"ФИО: {lastName} {firstName} {age}, рост {growth}, вес {weight}");

            Helper.Pause();
        }
    }
}
