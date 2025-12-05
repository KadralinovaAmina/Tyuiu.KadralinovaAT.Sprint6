namespace Tyuiu.KadralinovaAT.Sprint6.Task2.V26
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBoxTask_KAT = new GroupBox();
            textBoxTask = new TextBox();
            groupBoxVivod_KAT = new GroupBox();
            dataGridViewFunction = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Result_KAT = new Label();
            buttonDone_KAT = new Button();
            groupBoxVvod_KAT = new GroupBox();
            textBoxStopStep_KAT = new TextBox();
            textBoxStartStep_KAT = new TextBox();
            Stop_KAT = new Label();
            Start_KAT = new Label();
            buttonHelp_KAT = new Button();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBoxTask_KAT.SuspendLayout();
            groupBoxVivod_KAT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction).BeginInit();
            groupBoxVvod_KAT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask_KAT
            // 
            groupBoxTask_KAT.Controls.Add(textBoxTask);
            groupBoxTask_KAT.Location = new Point(12, 22);
            groupBoxTask_KAT.Name = "groupBoxTask_KAT";
            groupBoxTask_KAT.Size = new Size(477, 279);
            groupBoxTask_KAT.TabIndex = 5;
            groupBoxTask_KAT.TabStop = false;
            groupBoxTask_KAT.Text = "Условие";
            // 
            // textBoxTask
            // 
            textBoxTask.BackColor = SystemColors.Control;
            textBoxTask.BorderStyle = BorderStyle.None;
            textBoxTask.Cursor = Cursors.IBeam;
            textBoxTask.Location = new Point(5, 27);
            textBoxTask.Multiline = true;
            textBoxTask.Name = "textBoxTask";
            textBoxTask.Size = new Size(466, 101);
            textBoxTask.TabIndex = 0;
            textBoxTask.Text = "Протабулировать функцию sin(x) + cos(2x) / 2 - 1,5x на заданном диапазоне. Результат вывести в DataGridView и построить график функции.";
            // 
            // groupBoxVivod_KAT
            // 
            groupBoxVivod_KAT.Controls.Add(dataGridViewFunction);
            groupBoxVivod_KAT.Controls.Add(Result_KAT);
            groupBoxVivod_KAT.Location = new Point(495, 22);
            groupBoxVivod_KAT.Name = "groupBoxVivod_KAT";
            groupBoxVivod_KAT.Size = new Size(216, 407);
            groupBoxVivod_KAT.TabIndex = 8;
            groupBoxVivod_KAT.TabStop = false;
            groupBoxVivod_KAT.Text = "Вывод данных";
            // 
            // dataGridViewFunction
            // 
            dataGridViewFunction.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFunction.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dataGridViewFunction.Location = new Point(0, 50);
            dataGridViewFunction.Name = "dataGridViewFunction";
            dataGridViewFunction.RowHeadersVisible = false;
            dataGridViewFunction.RowHeadersWidth = 51;
            dataGridViewFunction.Size = new Size(215, 357);
            dataGridViewFunction.TabIndex = 1;
            // 
            // Column1
            // 
            Column1.HeaderText = "X";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "F(X)";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Result_KAT
            // 
            Result_KAT.AutoSize = true;
            Result_KAT.Location = new Point(6, 27);
            Result_KAT.Name = "Result_KAT";
            Result_KAT.Size = new Size(75, 20);
            Result_KAT.TabIndex = 0;
            Result_KAT.Text = "Результат";
            // 
            // buttonDone_KAT
            // 
            buttonDone_KAT.BackColor = Color.FromArgb(0, 192, 0);
            buttonDone_KAT.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonDone_KAT.Location = new Point(379, 335);
            buttonDone_KAT.Name = "buttonDone_KAT";
            buttonDone_KAT.Size = new Size(110, 94);
            buttonDone_KAT.TabIndex = 7;
            buttonDone_KAT.Text = "Выполнить";
            buttonDone_KAT.UseVisualStyleBackColor = false;
            buttonDone_KAT.Click += buttonDone_KAT_Click;
            buttonDone_KAT.MouseEnter += buttonDone_KAT_MouseEnter;
            buttonDone_KAT.MouseLeave += buttonDone_KAT_MouseLeave;
            // 
            // groupBoxVvod_KAT
            // 
            groupBoxVvod_KAT.Controls.Add(textBoxStopStep_KAT);
            groupBoxVvod_KAT.Controls.Add(textBoxStartStep_KAT);
            groupBoxVvod_KAT.Controls.Add(Stop_KAT);
            groupBoxVvod_KAT.Controls.Add(Start_KAT);
            groupBoxVvod_KAT.Location = new Point(12, 335);
            groupBoxVvod_KAT.Name = "groupBoxVvod_KAT";
            groupBoxVvod_KAT.Size = new Size(257, 94);
            groupBoxVvod_KAT.TabIndex = 6;
            groupBoxVvod_KAT.TabStop = false;
            groupBoxVvod_KAT.Text = "Ввод данных";
            // 
            // textBoxStopStep_KAT
            // 
            textBoxStopStep_KAT.Location = new Point(131, 52);
            textBoxStopStep_KAT.Name = "textBoxStopStep_KAT";
            textBoxStopStep_KAT.Size = new Size(115, 27);
            textBoxStopStep_KAT.TabIndex = 3;
            textBoxStopStep_KAT.Text = "5";
            // 
            // textBoxStartStep_KAT
            // 
            textBoxStartStep_KAT.Location = new Point(6, 52);
            textBoxStartStep_KAT.Name = "textBoxStartStep_KAT";
            textBoxStartStep_KAT.Size = new Size(112, 27);
            textBoxStartStep_KAT.TabIndex = 2;
            textBoxStartStep_KAT.Text = "-5";
            // 
            // Stop_KAT
            // 
            Stop_KAT.AutoSize = true;
            Stop_KAT.Location = new Point(131, 23);
            Stop_KAT.Name = "Stop_KAT";
            Stop_KAT.Size = new Size(94, 20);
            Stop_KAT.TabIndex = 1;
            Stop_KAT.Text = "Конец шага:";
            // 
            // Start_KAT
            // 
            Start_KAT.AutoSize = true;
            Start_KAT.Location = new Point(6, 23);
            Start_KAT.Name = "Start_KAT";
            Start_KAT.Size = new Size(88, 20);
            Start_KAT.TabIndex = 0;
            Start_KAT.Text = "Старт шага:";
            // 
            // buttonHelp_KAT
            // 
            buttonHelp_KAT.BackColor = SystemColors.MenuHighlight;
            buttonHelp_KAT.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonHelp_KAT.Location = new Point(285, 335);
            buttonHelp_KAT.Name = "buttonHelp_KAT";
            buttonHelp_KAT.Size = new Size(88, 94);
            buttonHelp_KAT.TabIndex = 9;
            buttonHelp_KAT.Text = "Справка";
            buttonHelp_KAT.UseVisualStyleBackColor = false;
            buttonHelp_KAT.Click += buttonHelp_KAT_Click;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(717, 22);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(493, 407);
            chart1.TabIndex = 10;
            chart1.Text = "chart1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1242, 450);
            Controls.Add(chart1);
            Controls.Add(buttonHelp_KAT);
            Controls.Add(groupBoxTask_KAT);
            Controls.Add(groupBoxVivod_KAT);
            Controls.Add(buttonDone_KAT);
            Controls.Add(groupBoxVvod_KAT);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 2 | Вариант 26 | Кадралинова А.Т.";
            groupBoxTask_KAT.ResumeLayout(false);
            groupBoxTask_KAT.PerformLayout();
            groupBoxVivod_KAT.ResumeLayout(false);
            groupBoxVivod_KAT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction).EndInit();
            groupBoxVvod_KAT.ResumeLayout(false);
            groupBoxVvod_KAT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_KAT;
        private TextBox textBoxTask;
        private GroupBox groupBoxVivod_KAT;
        private Label Result_KAT;
        private Button buttonDone_KAT;
        private GroupBox groupBoxVvod_KAT;
        private TextBox textBoxStopStep_KAT;
        private TextBox textBoxStartStep_KAT;
        private Label Stop_KAT;
        private Label Start_KAT;
        private Button buttonHelp_KAT;
        private DataGridView dataGridViewFunction;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}
