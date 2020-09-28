using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW7_1
{
    /// <summary>
    /// Делегат
    /// </summary>
    public delegate void StackMetode();
    class DoublerClass
    {
        Random rnd = new Random();
        private int step; // кол нажатий на батоны
        private int questNumber; // загаданое число
        private int resultNumber; // число полученное при манипуляциях

        Stack<StackMetode> operation = new Stack<StackMetode>();
        /// <summary>
        /// Конструктор класса.
        /// </summary>
        public DoublerClass()
        {
            this.step = 0;
            this.questNumber = rnd.Next(2, 100);
            this.resultNumber = 1;
        }

        /// <summary>
        /// Свойство аозвращает значение num.
        /// </summary>
        public int QuestNumber { get { return questNumber; } }
        public int Step { get => step; set => step = value; }
        public int ResultNumber { get => resultNumber; set => resultNumber = value; }

        /// <summary>
        /// Метод учеличивающий значение на 1
        /// </summary>
        public void Increment()
        {
            this.resultNumber++;
            this.step++;
            operation.Push(new StackMetode(Decrement));
        }

        /// <summary>
        /// Метод уменьшает значение на 1
        /// </summary>
        public void Decrement()
        {
            this.resultNumber--;
            this.step--;
        }

        /// <summary>
        /// Метод умножает значение на 2
        /// </summary>
        public void MultTwo()
        {
            this.resultNumber *= 2;
            this.step++;
            operation.Push(new StackMetode(DivTwo));
        }

        /// <summary>
        /// Метод деления значения на 2
        /// </summary>
        public void DivTwo()
        {
            this.resultNumber /= 2;
            this.step--;
        }

        /// <summary>
        /// Метод отмены последнего действия.
        /// Проверяет стэк, если не пуст выполняем последнюю добавленую операцию
        /// </summary>
        public void CancelStep()
        {
            StackMetode stackMetode;
            if (operation.Count != 0)
            {
                stackMetode = operation.Pop();
                stackMetode();
            }
        }

        /// <summary>
        /// Проверка на соответствие загаданного числа и полученного числа
        /// </summary>
        /// <returns></returns>
        public bool CheckResult()
        {
            return questNumber == resultNumber ? true : false;
        }

        /// <summary>
        /// Метод сбрысывает шаги и полученное значение
        /// </summary>
        public void Reset()
        {
            this.resultNumber = 1;
            this.step = 0;
            operation.Clear();
        }

        /// <summary>
        /// 
        /// </summary>
        public void GeneratoinNewNum()
        {
            questNumber = rnd.Next(2, 100);
        }
    }
}
