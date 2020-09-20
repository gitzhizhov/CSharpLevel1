using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW7_1
{
    public partial class MainForm : Form
    {
        int num;
        DoublerClass doubler;

        public MainForm()
        {
            doubler = new DoublerClass();
            InitializeComponent();
            this.Text = "Удвоитель";
            ElemVisibility(false);
            //NewGame();
        }

        /// <summary>
        /// Увеличивает результат на 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddOne_Click(object sender, EventArgs e)
        {
            doubler.Increment();
            Update();
        }

        /// <summary>
        /// Умножает результат на 2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMultTwo_Click(object sender, EventArgs e)
        {
            doubler.MultTwo();
            Update();
        }

        /// <summary>
        /// Отменяет последний шаг
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            doubler.CancelStep();
            Update();
        }

        /// <summary>
        /// Сбрасывает результат
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            doubler.Reset();
            Update();
        }

        
        /// <summary>
        /// Запуск новой игры
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiNewGame_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        /// <summary>
        /// Обновление формы, проверка на выигрыш.
        /// </summary>
        private void Update()
        {
            lblResult.Text = doubler.ResultNumber.ToString();
            lblCount.Text = doubler.Step.ToString();
            this.Refresh();
            if (doubler.CheckResult())
            {
                MessageBox.Show($"Поздравляю.\nВы получили предлженное число.\nВам понадобилось {doubler.Step} ходов", "Ура!", MessageBoxButtons.OK);
                ElemVisibility(false);
            }
        }

        /// <summary>
        /// Метод запуска новой игры
        /// </summary>
        private void NewGame()
        {
            doubler.GeneratoinNewNum();
            num = doubler.QuestNumber;
            MessageBox.Show($"Получите число: {num}", "", MessageBoxButtons.OK);
            ElemVisibility(true);
            lblNum.Text = num.ToString();
            Update();
        }

        /// <summary>
        /// Переключатель видемости элементов
        /// </summary>
        /// <param name="vis"></param>
        private void ElemVisibility(bool vis)
        {
            if (vis)
            {
                btnAddOne.Enabled = true;
                btnMultTwo.Enabled = true;
                btnCancel.Enabled = true;
                btnClear.Enabled = true;
            }
            else
            {
                btnAddOne.Enabled = false;
                btnMultTwo.Enabled = false;
                btnCancel.Enabled = false;
                btnClear.Enabled = false;
            }
        }

    }
}
