namespace HW8_5
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOpenFileCSV = new System.Windows.Forms.Button();
            this.btnSaveFileXML = new System.Windows.Forms.Button();
            this.tbFrom = new System.Windows.Forms.TextBox();
            this.tbTo = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAbout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(492, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiAbout
            // 
            this.tsmiAbout.Name = "tsmiAbout";
            this.tsmiAbout.Size = new System.Drawing.Size(94, 20);
            this.tsmiAbout.Text = "О программе";
            this.tsmiAbout.Click += new System.EventHandler(this.tsmiAbout_Click);
            // 
            // btnOpenFileCSV
            // 
            this.btnOpenFileCSV.AutoSize = true;
            this.btnOpenFileCSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenFileCSV.Location = new System.Drawing.Point(13, 140);
            this.btnOpenFileCSV.Name = "btnOpenFileCSV";
            this.btnOpenFileCSV.Size = new System.Drawing.Size(92, 25);
            this.btnOpenFileCSV.TabIndex = 2;
            this.btnOpenFileCSV.Text = "Выбрать файл";
            this.btnOpenFileCSV.UseVisualStyleBackColor = true;
            this.btnOpenFileCSV.Click += new System.EventHandler(this.btnOpenFileCSV_Click);
            // 
            // btnSaveFileXML
            // 
            this.btnSaveFileXML.AutoSize = true;
            this.btnSaveFileXML.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveFileXML.Location = new System.Drawing.Point(279, 140);
            this.btnSaveFileXML.Name = "btnSaveFileXML";
            this.btnSaveFileXML.Size = new System.Drawing.Size(92, 25);
            this.btnSaveFileXML.TabIndex = 3;
            this.btnSaveFileXML.Text = "Выбрать файл";
            this.btnSaveFileXML.UseVisualStyleBackColor = true;
            this.btnSaveFileXML.Click += new System.EventHandler(this.btnSaveFileXML_Click);
            // 
            // tbFrom
            // 
            this.tbFrom.Location = new System.Drawing.Point(13, 100);
            this.tbFrom.Name = "tbFrom";
            this.tbFrom.Size = new System.Drawing.Size(200, 20);
            this.tbFrom.TabIndex = 10;
            this.tbFrom.TabStop = false;
            // 
            // tbTo
            // 
            this.tbTo.Location = new System.Drawing.Point(279, 100);
            this.tbTo.Name = "tbTo";
            this.tbTo.Size = new System.Drawing.Size(200, 20);
            this.tbTo.TabIndex = 11;
            this.tbTo.TabStop = false;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(209, 52);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 1;
            this.btnConvert.Text = ">";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 223);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.tbTo);
            this.Controls.Add(this.tbFrom);
            this.Controls.Add(this.btnSaveFileXML);
            this.Controls.Add(this.btnOpenFileCSV);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "CSV to XML";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
        private System.Windows.Forms.Button btnOpenFileCSV;
        private System.Windows.Forms.Button btnSaveFileXML;
        private System.Windows.Forms.Button btnConvert;
        public System.Windows.Forms.TextBox tbFrom;
        public System.Windows.Forms.TextBox tbTo;
    }
}

