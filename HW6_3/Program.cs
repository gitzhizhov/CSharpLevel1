using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW6_3
{
    //    3.    Переделать программу Пример использования коллекций для решения следующих задач:
    //          а) Подсчитать количество студентов учащихся на 5 и 6 курсах;
    //          б) подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся(*частотный массив);
    //          в) отсортировать список по возрасту студента;
    //          г) * отсортировать список по курсу и возрасту студента;

    class Program
    {
        /// <summary>
        /// Метод для сравнения экземпляров, по имени
        /// </summary>
        /// <param name="st1"></param>
        /// <param name="st2"></param>
        /// <returns></returns>
        static int MyDelegat(Student st1, Student st2)          // Создаем метод для сравнения для экземпляров
        {
            return String.Compare(st1.firstName, st2.firstName);          // Сравниваем две строки
        }

        /// <summary>
        /// Метод для сравнения экземпляров, по курсу
        /// </summary>
        /// <param name="st1"></param>
        /// <param name="st2"></param>
        /// <returns></returns>
        static int DelegateCours(Student st1, Student st2)
        {
            return String.Compare(st1.course.ToString(), st2.course.ToString());
        }

        /// <summary>
        /// Метод для сравнения экземпляров, по возрасту
        /// </summary>
        /// <param name="st1"></param>
        /// <param name="st2"></param>
        /// <returns></returns>
        static int DelegateAge(Student st1, Student st2)
        {
            return String.Compare(st1.age.ToString(), st2.age.ToString());
        }

        /// <summary>
        /// Метод для сравнения экземпляров по курсу и возрасту
        /// Пример сортировки по 2-м параметрам
        /// </summary>
        /// <param name="st1"></param>
        /// <param name="st2"></param>
        /// <returns></returns>
        static int DelegateCourseAndAge(Student st1, Student st2)
        {
            if (st1.course > st2.course)
                return 1;
            if (st1.course < st2.course)
                return -1;
            if (st1.age > st2.age)
                return 1;
            if (st1.age < st2.age)
                return -1;
            return 0;
        }

        static void Main(string[] args)
        {
            int student5Cours = 0;
            int student6Cours = 0;
            int bakalavr = 0;
            int magistr = 0;
            Dictionary<int, int> counsStudents = new Dictionary<int, int>();
            List<Student> list = new List<Student>();                             // Создаем список студентов
            DateTime dt = DateTime.Now;
            StreamReader sr = new StreamReader("students_6.csv");

            while (!sr.EndOfStream)
            {
                try
                {
                    string[] s = sr.ReadLine().Split(';');
                    // Добавляем в список новый экземпляр класса Student
                    list.Add(new Student(s[0], s[1], s[2], s[3], int.Parse(s[4]), s[5], int.Parse(s[6]), s[7], int.Parse(s[8])));
                    // Одновременно подсчитываем количество бакалавров и магистров
                    if (int.Parse(s[4]) < 5) bakalavr++; else magistr++;
                    // Одновременно подсчитываем количество студентов учащихся на 5 и 6 курсах
                    if (int.Parse(s[4]) == 5) student5Cours++;
                    if (int.Parse(s[4]) == 6) student6Cours++;
                    // частотный анализ студентов на курсах
                    if (int.Parse(s[8]) >= 18 && int.Parse(s[8]) <= 20)
                        if (counsStudents.ContainsKey(int.Parse(s[4])))
                            counsStudents[int.Parse(s[4])]++;
                        else
                            counsStudents.Add(int.Parse(s[4]), 1);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Ошибка!ESC - прекратить выполнение программы");
                    // Выход из Main
                    if (Console.ReadKey().Key == ConsoleKey.Escape) return;
                }
            }
            sr.Close();


            Console.WriteLine("Всего студентов:" + list.Count);
            Console.WriteLine("Магистров:{0}", magistr);
            Console.WriteLine("Бакалавров:{0}", bakalavr);
            foreach (var v in list) Console.WriteLine(v.firstName);

            Console.WriteLine();
            Console.WriteLine($"Количество студентов учащихся на 5 курсе: {student5Cours};");
            Console.WriteLine($"Количество студентов учащихся на 6 курсе: {student6Cours};");
            Console.WriteLine();

            Console.WriteLine("Количество студентов в возрасте от 18 до 20 лет на каком курсе учатся");
            foreach (KeyValuePair<int, int> keyValue in counsStudents)
            {
                Console.WriteLine($"Курс {keyValue.Key} - кол. {keyValue.Value}");
            }

            Console.WriteLine("Сортировка по возрасту");
            list.Sort(new Comparison<Student>(DelegateAge));
            foreach (var v in list) Console.WriteLine(v.firstName);
            Console.WriteLine();

            Console.WriteLine("Сортировка по курсу и возрасту");
            list.Sort(new Comparison<Student>(DelegateCourseAndAge));
            foreach (var v in list) Console.WriteLine(v.firstName);

            Console.WriteLine();
            Console.WriteLine(DateTime.Now - dt);
            Console.ReadKey();
        }
    }

}
