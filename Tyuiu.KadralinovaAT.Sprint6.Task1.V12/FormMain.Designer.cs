namespace Tyuiu.KadralinovaAT.Sprint6.Task1.V12
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
            groupBoxTask_KAT = new GroupBox();
            textBoxTask = new TextBox();
            groupBoxVvod_KAT = new GroupBox();
            textBoxStopStep_KAT = new TextBox();
            textBoxStartStep_KAT = new TextBox();
            Stop_KAT = new Label();
            Start_KAT = new Label();
            buttonHelp_KAT = new Button();
            buttonDone_KAT = new Button();
            groupBoxVivod_KAT = new GroupBox();
            textBoxResult_KAT = new TextBox();
            Result_KAT = new Label();
            groupBoxTask_KAT.SuspendLayout();
            groupBoxVvod_KAT.SuspendLayout();
            groupBoxVivod_KAT.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask_KAT
            // 
            groupBoxTask_KAT.Controls.Add(textBoxTask);
            groupBoxTask_KAT.Location = new Point(32, 20);
            groupBoxTask_KAT.Name = "groupBoxTask_KAT";
            groupBoxTask_KAT.Size = new Size(477, 279);
            groupBoxTask_KAT.TabIndex = 0;
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
            textBoxTask.Size = new Size(444, 101);
            textBoxTask.TabIndex = 0;
            textBoxTask.Text = "Протабулировать функцию sin(x) + (cos(x) + 1) / (2 - x) + 2 * x на заданном диапазоне. Результат вывести в виде таблицы.";
            // 
            // groupBoxVvod_KAT
            // 
            groupBoxVvod_KAT.Controls.Add(textBoxStopStep_KAT);
            groupBoxVvod_KAT.Controls.Add(textBoxStartStep_KAT);
            groupBoxVvod_KAT.Controls.Add(Stop_KAT);
            groupBoxVvod_KAT.Controls.Add(Start_KAT);
            groupBoxVvod_KAT.Location = new Point(32, 333);
            groupBoxVvod_KAT.Name = "groupBoxVvod_KAT";
            groupBoxVvod_KAT.Size = new Size(257, 94);
            groupBoxVvod_KAT.TabIndex = 1;
            groupBoxVvod_KAT.TabStop = false;
            groupBoxVvod_KAT.Text = "Ввод данных";
            // 
            // textBoxStopStep_KAT
            // 
            textBoxStopStep_KAT.Location = new Point(131, 52);
            textBoxStopStep_KAT.Name = "textBoxStopStep_KAT";
            textBoxStopStep_KAT.Size = new Size(115, 27);
            textBoxStopStep_KAT.TabIndex = 3;
            // 
            // textBoxStartStep_KAT
            // 
            textBoxStartStep_KAT.Location = new Point(6, 52);
            textBoxStartStep_KAT.Name = "textBoxStartStep_KAT";
            textBoxStartStep_KAT.Size = new Size(112, 27);
            textBoxStartStep_KAT.TabIndex = 2;
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
            buttonHelp_KAT.Location = new Point(305, 333);
            buttonHelp_KAT.Name = "buttonHelp_KAT";
            buttonHelp_KAT.Size = new Size(88, 94);
            buttonHelp_KAT.TabIndex = 2;
            buttonHelp_KAT.Text = "Справка";
            buttonHelp_KAT.UseVisualStyleBackColor = false;
            buttonHelp_KAT.Click += buttonHelp_KAT_Click;
            // 
            // buttonDone_KAT
            // 
            buttonDone_KAT.BackColor = Color.FromArgb(0, 192, 0);
            buttonDone_KAT.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonDone_KAT.Location = new Point(399, 333);
            buttonDone_KAT.Name = "buttonDone_KAT";
            buttonDone_KAT.Size = new Size(110, 94);
            buttonDone_KAT.TabIndex = 3;
            buttonDone_KAT.Text = "Выполнить";
            buttonDone_KAT.UseVisualStyleBackColor = false;
            buttonDone_KAT.Click += buttonDone_KAT_Click;
            // 
            // groupBoxVivod_KAT
            // 
            groupBoxVivod_KAT.Controls.Add(textBoxResult_KAT);
            groupBoxVivod_KAT.Controls.Add(Result_KAT);
            groupBoxVivod_KAT.Location = new Point(515, 20);
            groupBoxVivod_KAT.Name = "groupBoxVivod_KAT";
            groupBoxVivod_KAT.Size = new Size(273, 407);
            groupBoxVivod_KAT.TabIndex = 4;
            groupBoxVivod_KAT.TabStop = false;
            groupBoxVivod_KAT.Text = "Вывод данных";
            // 
            // textBoxResult_KAT
            // 
            textBoxResult_KAT.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxResult_KAT.Location = new Point(0, 55);
            textBoxResult_KAT.Multiline = true;
            textBoxResult_KAT.Name = "textBoxResult_KAT";
            textBoxResult_KAT.ReadOnly = true;
            textBoxResult_KAT.ScrollBars = ScrollBars.Vertical;
            textBoxResult_KAT.Size = new Size(273, 352);
            textBoxResult_KAT.TabIndex = 1;
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
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxVivod_KAT);
            Controls.Add(buttonDone_KAT);
            Controls.Add(buttonHelp_KAT);
            Controls.Add(groupBoxVvod_KAT);
            Controls.Add(groupBoxTask_KAT);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 1 | Вариант 12 | Кадралинова А.Т.";
            groupBoxTask_KAT.ResumeLayout(false);
            groupBoxTask_KAT.PerformLayout();
            groupBoxVvod_KAT.ResumeLayout(false);
            groupBoxVvod_KAT.PerformLayout();
            groupBoxVivod_KAT.ResumeLayout(false);
            groupBoxVivod_KAT.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_KAT;
        private TextBox textBoxTask;
        private GroupBox groupBoxVvod_KAT;
        private TextBox textBoxStopStep_KAT;
        private TextBox textBoxStartStep_KAT;
        private Label Stop_KAT;
        private Label Start_KAT;
        private Button buttonHelp_KAT;
        private Button buttonDone_KAT;
        private GroupBox groupBoxVivod_KAT;
        private TextBox textBoxResult_KAT;
        private Label Result_KAT;
    }
}
