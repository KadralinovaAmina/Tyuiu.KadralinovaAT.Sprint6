namespace Tyuiu.KadralinovaAT.Sprint6.Task5.V12
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panel1 = new Panel();
            groupBoxUslovie_KAT = new GroupBox();
            textBoxzad_KAT = new TextBox();
            buttonHelp_KAT = new Button();
            buttonOpenFile_KAT = new Button();
            buttonDone_KAT = new Button();
            panel2 = new Panel();
            groupBoxVivod_KAT = new GroupBox();
            dataGridViewNums_KAT = new DataGridView();
            splitter1 = new Splitter();
            panel3 = new Panel();
            chartDiag_KAT = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel1.SuspendLayout();
            groupBoxUslovie_KAT.SuspendLayout();
            panel2.SuspendLayout();
            groupBoxVivod_KAT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNums_KAT).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartDiag_KAT).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBoxUslovie_KAT);
            panel1.Controls.Add(buttonHelp_KAT);
            panel1.Controls.Add(buttonOpenFile_KAT);
            panel1.Controls.Add(buttonDone_KAT);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1178, 128);
            panel1.TabIndex = 0;
            // 
            // groupBoxUslovie_KAT
            // 
            groupBoxUslovie_KAT.Controls.Add(textBoxzad_KAT);
            groupBoxUslovie_KAT.Location = new Point(11, 10);
            groupBoxUslovie_KAT.Name = "groupBoxUslovie_KAT";
            groupBoxUslovie_KAT.Size = new Size(725, 109);
            groupBoxUslovie_KAT.TabIndex = 5;
            groupBoxUslovie_KAT.TabStop = false;
            groupBoxUslovie_KAT.Text = "Условие";
            // 
            // textBoxzad_KAT
            // 
            textBoxzad_KAT.BackColor = SystemColors.Control;
            textBoxzad_KAT.BorderStyle = BorderStyle.None;
            textBoxzad_KAT.Location = new Point(6, 23);
            textBoxzad_KAT.Multiline = true;
            textBoxzad_KAT.Name = "textBoxzad_KAT";
            textBoxzad_KAT.Size = new Size(719, 80);
            textBoxzad_KAT.TabIndex = 0;
            textBoxzad_KAT.Text = "Прочитать данные из файла InPutDataFileTask5V12.txt. Вывести в dataGridView все числа не кратные 5 и построить диаграмму по этим значениям.";
            // 
            // buttonHelp_KAT
            // 
            buttonHelp_KAT.BackColor = SystemColors.MenuHighlight;
            buttonHelp_KAT.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonHelp_KAT.Location = new Point(1030, 20);
            buttonHelp_KAT.Name = "buttonHelp_KAT";
            buttonHelp_KAT.Size = new Size(138, 99);
            buttonHelp_KAT.TabIndex = 8;
            buttonHelp_KAT.Text = "Справка";
            buttonHelp_KAT.UseVisualStyleBackColor = false;
            buttonHelp_KAT.Click += buttonHelp_KAT_Click;
            // 
            // buttonOpenFile_KAT
            // 
            buttonOpenFile_KAT.BackColor = SystemColors.Highlight;
            buttonOpenFile_KAT.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonOpenFile_KAT.Location = new Point(886, 20);
            buttonOpenFile_KAT.Name = "buttonOpenFile_KAT";
            buttonOpenFile_KAT.Size = new Size(138, 99);
            buttonOpenFile_KAT.TabIndex = 7;
            buttonOpenFile_KAT.Text = "Открыть файл";
            buttonOpenFile_KAT.UseVisualStyleBackColor = false;
            buttonOpenFile_KAT.Click += buttonOpenFile_KAT_Click;
            // 
            // buttonDone_KAT
            // 
            buttonDone_KAT.BackColor = Color.FromArgb(0, 192, 0);
            buttonDone_KAT.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonDone_KAT.Location = new Point(742, 20);
            buttonDone_KAT.Name = "buttonDone_KAT";
            buttonDone_KAT.Size = new Size(138, 99);
            buttonDone_KAT.TabIndex = 6;
            buttonDone_KAT.Text = "Выполнить";
            buttonDone_KAT.UseVisualStyleBackColor = false;
            buttonDone_KAT.Click += buttonDone_KAT_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBoxVivod_KAT);
            panel2.Controls.Add(splitter1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 128);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 540);
            panel2.TabIndex = 1;
            // 
            // groupBoxVivod_KAT
            // 
            groupBoxVivod_KAT.Controls.Add(dataGridViewNums_KAT);
            groupBoxVivod_KAT.Location = new Point(11, 6);
            groupBoxVivod_KAT.Name = "groupBoxVivod_KAT";
            groupBoxVivod_KAT.Size = new Size(239, 534);
            groupBoxVivod_KAT.TabIndex = 6;
            groupBoxVivod_KAT.TabStop = false;
            groupBoxVivod_KAT.Text = "Вывод";
            // 
            // dataGridViewNums_KAT
            // 
            dataGridViewNums_KAT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewNums_KAT.Location = new Point(0, 26);
            dataGridViewNums_KAT.Margin = new Padding(5);
            dataGridViewNums_KAT.Name = "dataGridViewNums_KAT";
            dataGridViewNums_KAT.RowHeadersWidth = 51;
            dataGridViewNums_KAT.Size = new Size(233, 505);
            dataGridViewNums_KAT.TabIndex = 0;
            // 
            // splitter1
            // 
            splitter1.Dock = DockStyle.Right;
            splitter1.Location = new Point(246, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(4, 540);
            splitter1.TabIndex = 0;
            splitter1.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(chartDiag_KAT);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(250, 128);
            panel3.Name = "panel3";
            panel3.Size = new Size(928, 540);
            panel3.TabIndex = 2;
            // 
            // chartDiag_KAT
            // 
            chartArea1.Name = "ChartArea1";
            chartDiag_KAT.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartDiag_KAT.Legends.Add(legend1);
            chartDiag_KAT.Location = new Point(3, 0);
            chartDiag_KAT.Name = "chartDiag_KAT";
            series1.ChartArea = "ChartArea1";
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartDiag_KAT.Series.Add(series1);
            chartDiag_KAT.Size = new Size(922, 537);
            chartDiag_KAT.TabIndex = 0;
            chartDiag_KAT.Text = "chart1";
            // 
            // FormMain_KAT
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1178, 668);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MinimumSize = new Size(1150, 700);
            Name = "FormMain_KAT";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 5 | Вариант 12 | Кадралинова А.Т.";
            panel1.ResumeLayout(false);
            groupBoxUslovie_KAT.ResumeLayout(false);
            groupBoxUslovie_KAT.PerformLayout();
            panel2.ResumeLayout(false);
            groupBoxVivod_KAT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewNums_KAT).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartDiag_KAT).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Splitter splitter1;
        private Panel panel3;
        private GroupBox groupBoxUslovie_KAT;
        private TextBox textBoxzad_KAT;
        private Button buttonHelp_KAT;
        private Button buttonOpenFile_KAT;
        private Button buttonDone_KAT;
        private GroupBox groupBoxVivod_KAT;
        private DataGridView dataGridViewNums_KAT;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDiag_KAT;
    }
}
