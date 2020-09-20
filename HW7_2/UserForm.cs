using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW7_2
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Вводим значение в textbox, проверяем на валидность
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbForm2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && tbForm2.Text != "" && !Program.MF.logic.Win && Program.MF.logic.regex.IsMatch(tbForm2.Text))
            {
                Program.MF.logic.EnterNum = int.Parse(tbForm2.Text);
                Program.MF.logic.Step++;
                Program.MF.message = $"Вы ввели число {Program.MF.logic.EnterNum}";
                Program.MF.Info(Program.MF.message);
                Program.MF.Update();
                tbForm2.Text = "";
            }
        }
    }
}
