namespace Tyuiu.KadralinovaAT.Sprint6.Task3.V29
{
    partial class FormMain_KAT
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
            groupBoxUslovie_KAT = new GroupBox();
            dataGridViewMatrix_KAT = new DataGridView();
            textBox1 = new TextBox();
            groupBoxVivod_KAT = new GroupBox();
            textBoxResult_KAT = new TextBox();
            labelResult_KAT = new Label();
            buttonHelp_KAT = new Button();
            buttonDone_KAT = new Button();
            groupBoxUslovie_KAT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_KAT).BeginInit();
            groupBoxVivod_KAT.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxUslovie_KAT
            // 
            groupBoxUslovie_KAT.Controls.Add(dataGridViewMatrix_KAT);
            groupBoxUslovie_KAT.Controls.Add(textBox1);
            groupBoxUslovie_KAT.Location = new Point(15, 13);
            groupBoxUslovie_KAT.Name = "groupBoxUslovie_KAT";
            groupBoxUslovie_KAT.Size = new Size(734, 357);
            groupBoxUslovie_KAT.TabIndex = 0;
            groupBoxUslovie_KAT.TabStop = false;
            groupBoxUslovie_KAT.Text = "Условие";
            // 
            // dataGridViewMatrix_KAT
            // 
            dataGridViewMatrix_KAT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMatrix_KAT.ColumnHeadersVisible = false;
            dataGridViewMatrix_KAT.Location = new Point(378, 10);
            dataGridViewMatrix_KAT.Name = "dataGridViewMatrix_KAT";
            dataGridViewMatrix_KAT.RowHeadersVisible = false;
            dataGridViewMatrix_KAT.RowHeadersWidth = 51;
            dataGridViewMatrix_KAT.Size = new Size(350, 341);
            dataGridViewMatrix_KAT.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Control;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Location = new Point(19, 42);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(316, 261);
            textBox1.TabIndex = 0;
            textBox1.Text = "Дана матрица 5 на 5\r\n -2 -13 -15  -9 -17\r\n\r\n  13 -20 -15  27  18\r\n\r\n -12  -1 -20  13   0\r\n\r\n  15  32  18 -12 -18\r\n\r\n  16   5   3  -5  -8\r\nВыполнить сортировку по возрастанию в пятом столбце.";
            // 
            // groupBoxVivod_KAT
            // 
            groupBoxVivod_KAT.Controls.Add(textBoxResult_KAT);
            groupBoxVivod_KAT.Controls.Add(labelResult_KAT);
            groupBoxVivod_KAT.Location = new Point(756, 23);
            groupBoxVivod_KAT.Name = "groupBoxVivod_KAT";
            groupBoxVivod_KAT.Size = new Size(250, 125);
            groupBoxVivod_KAT.TabIndex = 1;
            groupBoxVivod_KAT.TabStop = false;
            groupBoxVivod_KAT.Text = "Вывод данных";
            // 
            // textBoxResult_KAT
            // 
            textBoxResult_KAT.Location = new Point(9, 52);
            textBoxResult_KAT.Name = "textBoxResult_KAT";
            textBoxResult_KAT.ReadOnly = true;
            textBoxResult_KAT.Size = new Size(235, 27);
            textBoxResult_KAT.TabIndex = 1;
            // 
            // labelResult_KAT
            // 
            labelResult_KAT.AutoSize = true;
            labelResult_KAT.Location = new Point(7, 24);
            labelResult_KAT.Name = "labelResult_KAT";
            labelResult_KAT.Size = new Size(75, 20);
            labelResult_KAT.TabIndex = 0;
            labelResult_KAT.Text = "Результат";
            // 
            // buttonHelp_KAT
            // 
            buttonHelp_KAT.BackColor = SystemColors.ButtonFace;
            buttonHelp_KAT.Location = new Point(767, 327);
            buttonHelp_KAT.Name = "buttonHelp_KAT";
            buttonHelp_KAT.Size = new Size(57, 38);
            buttonHelp_KAT.TabIndex = 2;
            buttonHelp_KAT.Text = "?";
            buttonHelp_KAT.UseVisualStyleBackColor = false;
            buttonHelp_KAT.Click += buttonHelp_KAT_Click;
            // 
            // buttonDone_KAT
            // 
            buttonDone_KAT.BackColor = SystemColors.ButtonFace;
            buttonDone_KAT.Location = new Point(843, 327);
            buttonDone_KAT.Name = "buttonDone_KAT";
            buttonDone_KAT.Size = new Size(157, 37);
            buttonDone_KAT.TabIndex = 3;
            buttonDone_KAT.Text = "Выполнить";
            buttonDone_KAT.UseVisualStyleBackColor = false;
            buttonDone_KAT.Click += buttonDone_KAT_Click;
            // 
            // FormMain_KAT
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1018, 382);
            Controls.Add(buttonDone_KAT);
            Controls.Add(buttonHelp_KAT);
            Controls.Add(groupBoxVivod_KAT);
            Controls.Add(groupBoxUslovie_KAT);
            Name = "FormMain_KAT";
            Text = "Спринт 6 | Таск 3 | Вариант 29 | Кадралинова А.Т.";
            Load += FormMain_KAT_Load;
            groupBoxUslovie_KAT.ResumeLayout(false);
            groupBoxUslovie_KAT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_KAT).EndInit();
            groupBoxVivod_KAT.ResumeLayout(false);
            groupBoxVivod_KAT.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxUslovie_KAT;
        private TextBox textBox1;
        private DataGridView dataGridViewMatrix_KAT;
        private GroupBox groupBoxVivod_KAT;
        private Label labelResult_KAT;
        private TextBox textBoxResult_KAT;
        private Button buttonHelp_KAT;
        private Button buttonDone_KAT;
    }
}
