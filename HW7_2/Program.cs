﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW7_2
{
//    2.	Используя Windows Forms, разработать игру «Угадай число».
//          Компьютер загадывает число от 1 до 100, а человек пытается его угадать за минимальное число попыток.
//          Компьютер говорит, больше или меньше загаданное число введенного.
//          a) Для ввода данных от человека используется элемент TextBox;
//          б) ** Реализовать отдельную форму c TextBox для ввода числа.

    // Андрей Жижов
    static class Program
    {
        public static MainForm MF;
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MF = new MainForm();
            Application.Run(MF);
        }
    }
}
