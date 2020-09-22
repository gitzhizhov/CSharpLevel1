using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW8_5
{
    public partial class MainForm : Form
    {
        Convert convert;

        public MainForm()
        {
            Program.MF = this;
            convert = new Convert();
            InitializeComponent();
            tbFrom.Text = "Выберете CSV файл";
            tbFrom.ForeColor = Color.Gray;
            tbTo.Text = "Выберете XML файл";
            tbTo.ForeColor = Color.Gray;
        }

        /// <summary>
        /// Выбор файла, фильтр csv
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOpenFileCSV_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Файл CSV | *.csv";
            // если отказались то выход
            if (openFile.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            // получаем выбранный файл
            convert.PathFrom = openFile.FileName;
            tbFrom.Text = openFile.FileName;
            tbFrom.ForeColor = Color.Black;
        }

        /// <summary>
        /// Выбор файла, фильтр xml
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveFileXML_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Файл XML | *.xml";
            if (saveFile.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            tbTo.Text = saveFile.FileName;
            convert.PathTo = tbTo.Text;
            tbTo.ForeColor = Color.Black;
        }

        /// <summary>
        /// Запуск процесса конвертации
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (tbFrom.Text == "Выберете CSV файл" || tbFrom.Text == "")
            {
                Info("Не выбран CSV файл");
                return;
            }
            if (tbTo.Text == "Выберете XML файл" || tbTo.Text == "")
            {
                Info("Не выбран XML файл");
                return;
            }

            convert.Conv();
            if (convert.ResOK)
                Info("Файл сконвертирован");
        }

        /// <summary>
        /// Вывод информации
        /// </summary>
        /// <param name="msg"></param>
        public void Info(string msg)
        {
            MessageBox.Show(msg);
        }

        private void tsmiAbout_Click(object sender, EventArgs e)
        {
            Info("Программа конвертации из формата CSV в XML");
        }
    }
}
