using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HW7_2
{
    class Game
    {
        private Random rnd = new Random();
        internal Regex regex;
        private int questNumber;
        private int step;
        private int enterNum;
        private bool win = false;

        public Game()
        {
            QuestNumber = rnd.Next(1,100);
            Step = 0;
            string pattern = "^[0-9]+$"; // оставляет только цыфры от начало до конца
            regex = new Regex(pattern);
        }

        public bool Win { get => win; set => win = value; }
        internal int Step { get => step; set => step = value; }
        internal int QuestNumber { get => questNumber; set => questNumber = value; }
        internal int EnterNum { get => enterNum; set => enterNum = value; }

        /// <summary>
        /// Проверка на соответствия загаданного и введенного числа
        /// </summary>
        /// <returns></returns>
        public void CheckGuessed()
        {
            if (QuestNumber == EnterNum)
            {
                win = true;
            }
        }

        /// <summary>
        /// Провераяет на больше-меньше введенное число
        /// </summary>
        /// <returns>Строку</returns>
        public string Disparity()
        {
            return QuestNumber < EnterNum ? "Введенный номер больше загаданного" : "Введенный номер меньше загаданного";
        }
    }
}
