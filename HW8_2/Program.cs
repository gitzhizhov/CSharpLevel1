using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW8_2
{
    //2.	Создайте простую форму на котором свяжите свойство Text элемента TextBox со свойством Value элемента NumericUpDown

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
