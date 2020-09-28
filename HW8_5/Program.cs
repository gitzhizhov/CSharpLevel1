using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW8_5
{
    //5.	** Написать программу-преобразователь из CSV в XML-файл с информацией о студентах(6 урок).

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
