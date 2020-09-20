using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW7_1
{
    //1.  а) Добавить в программу «Удвоитель» подсчёт количества отданных команд удвоителю.
    //    б) Добавить меню и команду «Играть». При нажатии появляется сообщение, какое число должен получить игрок.
    //    Игрок должен получить это число за минимальное количество ходов.
    //    в) * Добавить кнопку «Отменить», которая отменяет последние ходы. Используйте обобщенный класс Stack.
    //    Вся логика игры должна быть реализована в классе с удвоителем.

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
