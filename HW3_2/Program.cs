using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_2
{
    // 2. а) С клавиатуры вводятся числа, пока не будет введен 0 (каждое число в новой строке).
    //       Требуется подсчитать сумму всех нечетных положительных чисел. Сами числа и сумму вывести на экран, используя tryParse;
    //    б) Добавить обработку исключительных ситуаций на то, что могут быть введены некорректные данные.
    //       При возникновении ошибки вывести сообщение. Напишите соответствующую функцию;
    
    // Андрей Жижов
    class Program
    {
        static void Main(string[] args)
        {
            int x, sum = 0;
            List<int> numbers = new List<int>();

            Console.WriteLine("Программа подсчета нечетных положительных чисел, для выхода введите 0");
            Console.WriteLine("Введите целые числа: ");
            while (true)
            {
                x = CheckInt();

                if (x == 0)
                    break;
                if (x % 2 == 1 && x > 0)
                {
                    sum += x;
                    numbers.Add(x);
                }
            }

            Console.WriteLine();
            Console.WriteLine("Положительные нечетные числа:");
            foreach (var i in numbers)
            {
                Console.Write($"{i} ");
            }
            
            Console.WriteLine($"\nСумма всех нечетных положительных чисел = {sum}");
            Console.ReadKey();
        }

        static public int CheckInt()
        {
            while (true)
                if (!int.TryParse(Console.ReadLine(), out int x))
                    Console.Write("Неверный ввод (требуется числовое значение).\nПожалуйста повторите ввод: \n");
                else return x;
        }
    }

}
