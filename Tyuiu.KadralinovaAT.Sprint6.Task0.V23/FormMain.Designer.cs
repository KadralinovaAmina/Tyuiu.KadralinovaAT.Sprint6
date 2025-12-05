namespace Tyuiu.KadralinovaAT.Sprint6.Task0.V23
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            textBoxX_KAT = new TextBox();
            buttonDone_KAT = new Button();
            label2 = new Label();
            pictureBoxFormula_KAT = new PictureBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            buttonHelp_KAT = new Button();
            groupBoxVvod_KAT = new GroupBox();
            Peremennaya_KAT = new Label();
            groupBoxVivod_KAT = new GroupBox();
            Result_KAT = new Label();
            textBoxResult_KAT = new TextBox();
            groupBoxTask_KAT = new GroupBox();
            textBoxTask_KAT = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_KAT).BeginInit();
            groupBoxVvod_KAT.SuspendLayout();
            groupBoxVivod_KAT.SuspendLayout();
            groupBoxTask_KAT.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 62);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 0;
            // 
            // textBoxX_KAT
            // 
            textBoxX_KAT.Location = new Point(8, 64);
            textBoxX_KAT.Name = "textBoxX_KAT";
            textBoxX_KAT.Size = new Size(125, 27);
            textBoxX_KAT.TabIndex = 1;
            textBoxX_KAT.KeyPress += textBoxX_KATKeyPress;
            // 
            // buttonDone_KAT
            // 
            buttonDone_KAT.Location = new Point(634, 393);
            buttonDone_KAT.Name = "buttonDone_KAT";
            buttonDone_KAT.Size = new Size(128, 45);
            buttonDone_KAT.TabIndex = 2;
            buttonDone_KAT.Text = "Выполнить";
            buttonDone_KAT.UseVisualStyleBackColor = true;
            buttonDone_KAT.Click += buttonDone_KAT_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 30);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 3;
            // 
            // pictureBoxFormula_KAT
            // 
            pictureBoxFormula_KAT.Image = Properties.Resources.task0;
            pictureBoxFormula_KAT.Location = new Point(634, 33);
            pictureBoxFormula_KAT.Name = "pictureBoxFormula_KAT";
            pictureBoxFormula_KAT.Size = new Size(128, 60);
            pictureBoxFormula_KAT.TabIndex = 5;
            pictureBoxFormula_KAT.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // buttonHelp_KAT
            // 
            buttonHelp_KAT.FlatStyle = FlatStyle.Flat;
            buttonHelp_KAT.Location = new Point(583, 393);
            buttonHelp_KAT.Name = "buttonHelp_KAT";
            buttonHelp_KAT.Size = new Size(45, 45);
            buttonHelp_KAT.TabIndex = 8;
            buttonHelp_KAT.Text = "?";
            buttonHelp_KAT.UseVisualStyleBackColor = true;
            buttonHelp_KAT.Click += buttonHelp_KAT_Click;
            // 
            // groupBoxVvod_KAT
            // 
            groupBoxVvod_KAT.Controls.Add(Peremennaya_KAT);
            groupBoxVvod_KAT.Controls.Add(textBoxX_KAT);
            groupBoxVvod_KAT.Location = new Point(41, 269);
            groupBoxVvod_KAT.Name = "groupBoxVvod_KAT";
            groupBoxVvod_KAT.Size = new Size(410, 118);
            groupBoxVvod_KAT.TabIndex = 9;
            groupBoxVvod_KAT.TabStop = false;
            groupBoxVvod_KAT.Text = "Ввод данных";
            // 
            // Peremennaya_KAT
            // 
            Peremennaya_KAT.AutoSize = true;
            Peremennaya_KAT.Location = new Point(6, 32);
            Peremennaya_KAT.Name = "Peremennaya_KAT";
            Peremennaya_KAT.Size = new Size(112, 20);
            Peremennaya_KAT.TabIndex = 2;
            Peremennaya_KAT.Text = "Переменная x:";
            // 
            // groupBoxVivod_KAT
            // 
            groupBoxVivod_KAT.Controls.Add(Result_KAT);
            groupBoxVivod_KAT.Controls.Add(textBoxResult_KAT);
            groupBoxVivod_KAT.Location = new Point(518, 269);
            groupBoxVivod_KAT.Name = "groupBoxVivod_KAT";
            groupBoxVivod_KAT.Size = new Size(244, 118);
            groupBoxVivod_KAT.TabIndex = 10;
            groupBoxVivod_KAT.TabStop = false;
            groupBoxVivod_KAT.Text = "Вывод данных";
            // 
            // Result_KAT
            // 
            Result_KAT.AutoSize = true;
            Result_KAT.Location = new Point(6, 32);
            Result_KAT.Name = "Result_KAT";
            Result_KAT.Size = new Size(75, 20);
            Result_KAT.TabIndex = 1;
            Result_KAT.Text = "Результат";
            // 
            // textBoxResult_KAT
            // 
            textBoxResult_KAT.Cursor = Cursors.IBeam;
            textBoxResult_KAT.Location = new Point(6, 64);
            textBoxResult_KAT.Name = "textBoxResult_KAT";
            textBoxResult_KAT.ReadOnly = true;
            textBoxResult_KAT.Size = new Size(232, 27);
            textBoxResult_KAT.TabIndex = 1;
            // 
            // groupBoxTask_KAT
            // 
            groupBoxTask_KAT.Controls.Add(textBoxTask_KAT);
            groupBoxTask_KAT.Location = new Point(41, 30);
            groupBoxTask_KAT.Name = "groupBoxTask_KAT";
            groupBoxTask_KAT.Size = new Size(721, 233);
            groupBoxTask_KAT.TabIndex = 11;
            groupBoxTask_KAT.TabStop = false;
            groupBoxTask_KAT.Text = "Условие";
            // 
            // textBoxTask_KAT
            // 
            textBoxTask_KAT.BackColor = SystemColors.Control;
            textBoxTask_KAT.BorderStyle = BorderStyle.None;
            textBoxTask_KAT.Cursor = Cursors.IBeam;
            textBoxTask_KAT.Location = new Point(10, 33);
            textBoxTask_KAT.Multiline = true;
            textBoxTask_KAT.Name = "textBoxTask_KAT";
            textBoxTask_KAT.Size = new Size(577, 149);
            textBoxTask_KAT.TabIndex = 0;
            textBoxTask_KAT.Text = "Вычислить выражение по формуле";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxVivod_KAT);
            Controls.Add(groupBoxVvod_KAT);
            Controls.Add(buttonHelp_KAT);
            Controls.Add(pictureBoxFormula_KAT);
            Controls.Add(label2);
            Controls.Add(buttonDone_KAT);
            Controls.Add(label1);
            Controls.Add(groupBoxTask_KAT);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 0 | Вариант 23 | Кадралинова А.Т.";
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_KAT).EndInit();
            groupBoxVvod_KAT.ResumeLayout(false);
            groupBoxVvod_KAT.PerformLayout();
            groupBoxVivod_KAT.ResumeLayout(false);
            groupBoxVivod_KAT.PerformLayout();
            groupBoxTask_KAT.ResumeLayout(false);
            groupBoxTask_KAT.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxX_KAT;
        private Button buttonDone_KAT;
        private Label label2;
        private PictureBox pictureBoxFormula_KAT;
        private ContextMenuStrip contextMenuStrip1;
        private Button buttonHelp_KAT;
        private GroupBox groupBoxVvod_KAT;
        private Label Peremennaya_KAT;
        private GroupBox groupBoxVivod_KAT;
        private GroupBox groupBoxTask_KAT;
        private TextBox textBoxResult_KAT;
        private Label Result_KAT;
        private TextBox textBoxTask_KAT;
    }
}
