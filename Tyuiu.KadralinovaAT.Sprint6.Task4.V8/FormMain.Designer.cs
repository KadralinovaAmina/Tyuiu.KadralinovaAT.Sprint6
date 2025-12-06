namespace Tyuiu.KadralinovaAT.Sprint6.Task4.V8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            groupBoxUslovie_KAT = new GroupBox();
            textBox1 = new TextBox();
            groupBoxVvod_KAT = new GroupBox();
            textBoxStopStep_KAT = new TextBox();
            textBoxStartStep_KAT = new TextBox();
            labelstop_KAT = new Label();
            labelstart_KAT = new Label();
            buttonDone_KAT = new Button();
            buttonSave_KAT = new Button();
            buttonHelp_KAT = new Button();
            groupBoxVivod_KAT = new GroupBox();
            textBoxResult_KAT = new TextBox();
            chartFunction_KAT = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBoxUslovie_KAT.SuspendLayout();
            groupBoxVvod_KAT.SuspendLayout();
            groupBoxVivod_KAT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_KAT).BeginInit();
            SuspendLayout();
            // 
            // groupBoxUslovie_KAT
            // 
            groupBoxUslovie_KAT.Controls.Add(textBox1);
            groupBoxUslovie_KAT.Location = new Point(14, 15);
            groupBoxUslovie_KAT.Name = "groupBoxUslovie_KAT";
            groupBoxUslovie_KAT.Size = new Size(434, 109);
            groupBoxUslovie_KAT.TabIndex = 0;
            groupBoxUslovie_KAT.TabStop = false;
            groupBoxUslovie_KAT.Text = "Условие";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Control;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(6, 23);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(418, 80);
            textBox1.TabIndex = 0;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // groupBoxVvod_KAT
            // 
            groupBoxVvod_KAT.Controls.Add(textBoxStopStep_KAT);
            groupBoxVvod_KAT.Controls.Add(textBoxStartStep_KAT);
            groupBoxVvod_KAT.Controls.Add(labelstop_KAT);
            groupBoxVvod_KAT.Controls.Add(labelstart_KAT);
            groupBoxVvod_KAT.Location = new Point(454, 15);
            groupBoxVvod_KAT.Name = "groupBoxVvod_KAT";
            groupBoxVvod_KAT.Size = new Size(285, 109);
            groupBoxVvod_KAT.TabIndex = 1;
            groupBoxVvod_KAT.TabStop = false;
            groupBoxVvod_KAT.Text = "Ввод данных";
            // 
            // textBoxStopStep_KAT
            // 
            textBoxStopStep_KAT.Location = new Point(147, 61);
            textBoxStopStep_KAT.Name = "textBoxStopStep_KAT";
            textBoxStopStep_KAT.Size = new Size(129, 27);
            textBoxStopStep_KAT.TabIndex = 3;
            textBoxStopStep_KAT.Text = "5";
            // 
            // textBoxStartStep_KAT
            // 
            textBoxStartStep_KAT.Location = new Point(8, 61);
            textBoxStartStep_KAT.Name = "textBoxStartStep_KAT";
            textBoxStartStep_KAT.Size = new Size(133, 27);
            textBoxStartStep_KAT.TabIndex = 2;
            textBoxStartStep_KAT.Text = "-5";
            // 
            // labelstop_KAT
            // 
            labelstop_KAT.AutoSize = true;
            labelstop_KAT.Location = new Point(147, 28);
            labelstop_KAT.Name = "labelstop_KAT";
            labelstop_KAT.Size = new Size(94, 20);
            labelstop_KAT.TabIndex = 1;
            labelstop_KAT.Text = "Конец шага:";
            // 
            // labelstart_KAT
            // 
            labelstart_KAT.AutoSize = true;
            labelstart_KAT.Location = new Point(8, 28);
            labelstart_KAT.Name = "labelstart_KAT";
            labelstart_KAT.Size = new Size(88, 20);
            labelstart_KAT.TabIndex = 0;
            labelstart_KAT.Text = "Старт шага:";
            // 
            // buttonDone_KAT
            // 
            buttonDone_KAT.BackColor = Color.FromArgb(0, 192, 0);
            buttonDone_KAT.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonDone_KAT.Location = new Point(745, 25);
            buttonDone_KAT.Name = "buttonDone_KAT";
            buttonDone_KAT.Size = new Size(138, 99);
            buttonDone_KAT.TabIndex = 2;
            buttonDone_KAT.Text = "Выполнить";
            buttonDone_KAT.UseVisualStyleBackColor = false;
            buttonDone_KAT.Click += buttonDone_KAT_Click;
            // 
            // buttonSave_KAT
            // 
            buttonSave_KAT.BackColor = SystemColors.Highlight;
            buttonSave_KAT.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonSave_KAT.Location = new Point(889, 25);
            buttonSave_KAT.Name = "buttonSave_KAT";
            buttonSave_KAT.Size = new Size(138, 99);
            buttonSave_KAT.TabIndex = 3;
            buttonSave_KAT.Text = "Сохранить";
            buttonSave_KAT.UseVisualStyleBackColor = false;
            buttonSave_KAT.Click += buttonSave_KAT_Click;
            // 
            // buttonHelp_KAT
            // 
            buttonHelp_KAT.BackColor = SystemColors.MenuHighlight;
            buttonHelp_KAT.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonHelp_KAT.Location = new Point(1033, 25);
            buttonHelp_KAT.Name = "buttonHelp_KAT";
            buttonHelp_KAT.Size = new Size(138, 99);
            buttonHelp_KAT.TabIndex = 4;
            buttonHelp_KAT.Text = "Справка";
            buttonHelp_KAT.UseVisualStyleBackColor = false;
            buttonHelp_KAT.Click += buttonHelp_KAT_Click;
            // 
            // groupBoxVivod_KAT
            // 
            groupBoxVivod_KAT.Controls.Add(textBoxResult_KAT);
            groupBoxVivod_KAT.Location = new Point(14, 124);
            groupBoxVivod_KAT.Name = "groupBoxVivod_KAT";
            groupBoxVivod_KAT.Size = new Size(284, 556);
            groupBoxVivod_KAT.TabIndex = 5;
            groupBoxVivod_KAT.TabStop = false;
            groupBoxVivod_KAT.Text = "Вывод";
            // 
            // textBoxResult_KAT
            // 
            textBoxResult_KAT.Location = new Point(0, 26);
            textBoxResult_KAT.Multiline = true;
            textBoxResult_KAT.Name = "textBoxResult_KAT";
            textBoxResult_KAT.ScrollBars = ScrollBars.Vertical;
            textBoxResult_KAT.Size = new Size(284, 508);
            textBoxResult_KAT.TabIndex = 0;
            // 
            // chartFunction_KAT
            // 
            chartArea2.Name = "ChartArea1";
            chartFunction_KAT.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chartFunction_KAT.Legends.Add(legend2);
            chartFunction_KAT.Location = new Point(304, 130);
            chartFunction_KAT.Name = "chartFunction_KAT";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.MarkerBorderColor = Color.Fuchsia;
            series2.MarkerBorderWidth = 2;
            series2.Name = "График функции";
            chartFunction_KAT.Series.Add(series2);
            chartFunction_KAT.Size = new Size(867, 550);
            chartFunction_KAT.TabIndex = 6;
            title2.Alignment = ContentAlignment.TopCenter;
            title2.BackColor = Color.White;
            title2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            title2.ForeColor = Color.MediumOrchid;
            title2.Name = "График функции sin(x) + (cos(x) + 1) / (2 - x) + 2x";
            title2.Text = "График функции sin(x) + (cos(x) + 1) / (2 - x) + 2x";
            chartFunction_KAT.Titles.Add(title2);
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1179, 692);
            Controls.Add(chartFunction_KAT);
            Controls.Add(groupBoxVivod_KAT);
            Controls.Add(buttonHelp_KAT);
            Controls.Add(buttonSave_KAT);
            Controls.Add(buttonDone_KAT);
            Controls.Add(groupBoxVvod_KAT);
            Controls.Add(groupBoxUslovie_KAT);
            MinimumSize = new Size(1150, 700);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 4 | Вариант 8 | Кадралинова А.Т.";
            groupBoxUslovie_KAT.ResumeLayout(false);
            groupBoxUslovie_KAT.PerformLayout();
            groupBoxVvod_KAT.ResumeLayout(false);
            groupBoxVvod_KAT.PerformLayout();
            groupBoxVivod_KAT.ResumeLayout(false);
            groupBoxVivod_KAT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_KAT).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxUslovie_KAT;
        private TextBox textBox1;
        private GroupBox groupBoxVvod_KAT;
        private TextBox textBoxStartStep_KAT;
        private Label labelstop_KAT;
        private Label labelstart_KAT;
        private TextBox textBoxStopStep_KAT;
        private Button buttonDone_KAT;
        private Button buttonSave_KAT;
        private Button buttonHelp_KAT;
        private GroupBox groupBoxVivod_KAT;
        private TextBox textBoxResult_KAT;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_KAT;
    }
}
