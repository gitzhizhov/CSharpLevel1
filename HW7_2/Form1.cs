using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace HW7_2
{
    public partial class MainForm : Form
    {
        internal Game logic;
        internal string message;
        Form userForm;

        public MainForm()
        {
            Program.MF = this;
            InitializeComponent();
            this.lblText.Text = "Для начало игры нажмите Новая игра";
        }

        /// <summary>
        /// Новая игра
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiNewGame_Click(object sender, EventArgs e)
        {
            //this.tboxEnterNum.Text = "";
            this.lblNumText.Text = null;
            this.lblText.Text = "Угадайте загаданное компьютером число от 1 до 100";
            // устанавливаем положение элемента по центру
            this.lblText.Left = (this.Width - lblText.Width) / 2;
            userForm = new UserForm();
            userForm.Show();
            this.logic = new Game();
            this.message = null;
        }

        /// <summary>
        /// Принудительно обновляет форму
        /// </summary>
        public void Update()
        {
            this.Refresh();
            lblNumText.Text = logic.Disparity();
            this.lblNumText.Left = (this.Width - lblNumText.Width) / 2;
            logic.CheckGuessed();
            if (logic.Win)
            {
                userForm.Close();
                if (MessageBox.Show($"Вы угадали число за \n{logic.Step} попыток", "Поздравляю!", MessageBoxButtons.OK) == DialogResult.OK)
                    GameOver();
            }

            // подсказка для отладки
            //label1.Text = logic.QuestNumber.ToString();
        }

        /// <summary>
        /// Выход
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        /// <summary>
        /// Вывод информации
        /// </summary>
        /// <param name="msg"></param>
        internal void Info(string msg)
        {
            lblInfo.Text = msg;
        }

        /// <summary>
        /// Очиска полей, значений и прочего
        /// </summary>
        private void GameOver()
        {
            lblNumText.Text = null;
            logic.Step = 0;
            userForm.Dispose();
            this.lblText.Text = "Для начало игры нажмите Новая игра";
            this.lblInfo.Text = "";
        }
    }
}
