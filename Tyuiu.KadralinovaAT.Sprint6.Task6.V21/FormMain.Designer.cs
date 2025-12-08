namespace Tyuiu.KadralinovaAT.Sprint6.Task6.V21
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panelTop_KAT = new Panel();
            buttonHelp_KAT = new Button();
            buttonDone_KAT = new Button();
            buttonOpenFile_KAT = new Button();
            groupBoxUsl_KAT = new GroupBox();
            textBoxUsl_KAT = new TextBox();
            panelLeft_KAT = new Panel();
            groupBoxLeft_KAT = new GroupBox();
            textBoxIn_KAT = new TextBox();
            panelFill_KAT = new Panel();
            groupBoxOutPutData_KAT = new GroupBox();
            textBoxResult_KAT = new TextBox();
            splitterLeft_KAT = new Splitter();
            openFileDialogTask_KAT = new OpenFileDialog();
            toolTipFile_KAT = new ToolTip(components);
            panelTop_KAT.SuspendLayout();
            groupBoxUsl_KAT.SuspendLayout();
            panelLeft_KAT.SuspendLayout();
            groupBoxLeft_KAT.SuspendLayout();
            panelFill_KAT.SuspendLayout();
            groupBoxOutPutData_KAT.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop_KAT
            // 
            panelTop_KAT.BackColor = SystemColors.Control;
            panelTop_KAT.Controls.Add(buttonHelp_KAT);
            panelTop_KAT.Controls.Add(buttonDone_KAT);
            panelTop_KAT.Controls.Add(buttonOpenFile_KAT);
            panelTop_KAT.Controls.Add(groupBoxUsl_KAT);
            panelTop_KAT.Dock = DockStyle.Top;
            panelTop_KAT.Location = new Point(0, 0);
            panelTop_KAT.Name = "panelTop_KAT";
            panelTop_KAT.Size = new Size(1182, 151);
            panelTop_KAT.TabIndex = 0;
            // 
            // buttonHelp_KAT
            // 
            buttonHelp_KAT.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_KAT.BackColor = SystemColors.Control;
            buttonHelp_KAT.Image = Properties.Resources.help;
            buttonHelp_KAT.Location = new Point(1104, 3);
            buttonHelp_KAT.Name = "buttonHelp_KAT";
            buttonHelp_KAT.Size = new Size(75, 55);
            buttonHelp_KAT.TabIndex = 3;
            toolTipFile_KAT.SetToolTip(buttonHelp_KAT, "Сведение о программе");
            buttonHelp_KAT.UseVisualStyleBackColor = false;
            buttonHelp_KAT.Click += buttonHelp_KAT_Click;
            // 
            // buttonDone_KAT
            // 
            buttonDone_KAT.BackColor = SystemColors.ButtonFace;
            buttonDone_KAT.Image = Properties.Resources.page_white_go;
            buttonDone_KAT.Location = new Point(84, 3);
            buttonDone_KAT.Name = "buttonDone_KAT";
            buttonDone_KAT.Size = new Size(75, 55);
            buttonDone_KAT.TabIndex = 3;
            toolTipFile_KAT.SetToolTip(buttonDone_KAT, "Производит вывод слов, в которых встречается g");
            buttonDone_KAT.UseVisualStyleBackColor = false;
            buttonDone_KAT.Click += buttonDone_KAT_Click;
            // 
            // buttonOpenFile_KAT
            // 
            buttonOpenFile_KAT.BackColor = SystemColors.ButtonFace;
            buttonOpenFile_KAT.Image = Properties.Resources.folder_page_white;
            buttonOpenFile_KAT.Location = new Point(3, 3);
            buttonOpenFile_KAT.Name = "buttonOpenFile_KAT";
            buttonOpenFile_KAT.Size = new Size(75, 55);
            buttonOpenFile_KAT.TabIndex = 3;
            toolTipFile_KAT.SetToolTip(buttonOpenFile_KAT, "Открыть файл\r\nВыберите нужный файл для обработки\r\n");
            buttonOpenFile_KAT.UseVisualStyleBackColor = false;
            buttonOpenFile_KAT.Click += buttonOpenFile_KAT_Click;
            // 
            // groupBoxUsl_KAT
            // 
            groupBoxUsl_KAT.Controls.Add(textBoxUsl_KAT);
            groupBoxUsl_KAT.Dock = DockStyle.Bottom;
            groupBoxUsl_KAT.Location = new Point(0, 61);
            groupBoxUsl_KAT.Name = "groupBoxUsl_KAT";
            groupBoxUsl_KAT.Size = new Size(1182, 90);
            groupBoxUsl_KAT.TabIndex = 2;
            groupBoxUsl_KAT.TabStop = false;
            groupBoxUsl_KAT.Text = "Условие";
            // 
            // textBoxUsl_KAT
            // 
            textBoxUsl_KAT.BackColor = SystemColors.Control;
            textBoxUsl_KAT.BorderStyle = BorderStyle.None;
            textBoxUsl_KAT.Dock = DockStyle.Fill;
            textBoxUsl_KAT.Location = new Point(3, 23);
            textBoxUsl_KAT.Multiline = true;
            textBoxUsl_KAT.Name = "textBoxUsl_KAT";
            textBoxUsl_KAT.Size = new Size(1176, 64);
            textBoxUsl_KAT.TabIndex = 0;
            textBoxUsl_KAT.Text = resources.GetString("textBoxUsl_KAT.Text");
            // 
            // panelLeft_KAT
            // 
            panelLeft_KAT.BackColor = SystemColors.Control;
            panelLeft_KAT.Controls.Add(groupBoxLeft_KAT);
            panelLeft_KAT.Dock = DockStyle.Left;
            panelLeft_KAT.Location = new Point(0, 151);
            panelLeft_KAT.Name = "panelLeft_KAT";
            panelLeft_KAT.Padding = new Padding(3);
            panelLeft_KAT.Size = new Size(586, 497);
            panelLeft_KAT.TabIndex = 0;
            // 
            // groupBoxLeft_KAT
            // 
            groupBoxLeft_KAT.Controls.Add(textBoxIn_KAT);
            groupBoxLeft_KAT.Dock = DockStyle.Fill;
            groupBoxLeft_KAT.Location = new Point(3, 3);
            groupBoxLeft_KAT.Name = "groupBoxLeft_KAT";
            groupBoxLeft_KAT.Size = new Size(580, 491);
            groupBoxLeft_KAT.TabIndex = 0;
            groupBoxLeft_KAT.TabStop = false;
            groupBoxLeft_KAT.Text = "Ввод";
            // 
            // textBoxIn_KAT
            // 
            textBoxIn_KAT.Dock = DockStyle.Fill;
            textBoxIn_KAT.Location = new Point(3, 23);
            textBoxIn_KAT.Multiline = true;
            textBoxIn_KAT.Name = "textBoxIn_KAT";
            textBoxIn_KAT.ScrollBars = ScrollBars.Vertical;
            textBoxIn_KAT.Size = new Size(574, 465);
            textBoxIn_KAT.TabIndex = 0;
            // 
            // panelFill_KAT
            // 
            panelFill_KAT.BackColor = SystemColors.Control;
            panelFill_KAT.Controls.Add(groupBoxOutPutData_KAT);
            panelFill_KAT.Dock = DockStyle.Fill;
            panelFill_KAT.Location = new Point(586, 151);
            panelFill_KAT.Name = "panelFill_KAT";
            panelFill_KAT.Padding = new Padding(3);
            panelFill_KAT.Size = new Size(596, 497);
            panelFill_KAT.TabIndex = 0;
            // 
            // groupBoxOutPutData_KAT
            // 
            groupBoxOutPutData_KAT.Controls.Add(textBoxResult_KAT);
            groupBoxOutPutData_KAT.Dock = DockStyle.Fill;
            groupBoxOutPutData_KAT.Location = new Point(3, 3);
            groupBoxOutPutData_KAT.Name = "groupBoxOutPutData_KAT";
            groupBoxOutPutData_KAT.Size = new Size(590, 491);
            groupBoxOutPutData_KAT.TabIndex = 1;
            groupBoxOutPutData_KAT.TabStop = false;
            groupBoxOutPutData_KAT.Text = "Вывод";
            // 
            // textBoxResult_KAT
            // 
            textBoxResult_KAT.Dock = DockStyle.Fill;
            textBoxResult_KAT.Location = new Point(3, 23);
            textBoxResult_KAT.Multiline = true;
            textBoxResult_KAT.Name = "textBoxResult_KAT";
            textBoxResult_KAT.ScrollBars = ScrollBars.Vertical;
            textBoxResult_KAT.Size = new Size(584, 465);
            textBoxResult_KAT.TabIndex = 0;
            // 
            // splitterLeft_KAT
            // 
            splitterLeft_KAT.Location = new Point(586, 151);
            splitterLeft_KAT.Name = "splitterLeft_KAT";
            splitterLeft_KAT.Size = new Size(4, 497);
            splitterLeft_KAT.TabIndex = 1;
            splitterLeft_KAT.TabStop = false;
            // 
            // openFileDialogTask_KAT
            // 
            openFileDialogTask_KAT.FileName = "openFileDialogTask_KAT";
            // 
            // toolTipFile_KAT
            // 
            toolTipFile_KAT.ToolTipIcon = ToolTipIcon.Info;
            toolTipFile_KAT.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 648);
            Controls.Add(splitterLeft_KAT);
            Controls.Add(panelFill_KAT);
            Controls.Add(panelLeft_KAT);
            Controls.Add(panelTop_KAT);
            MinimumSize = new Size(900, 550);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 6 | Вариант 21 | Кадралинова А.Т.";
            panelTop_KAT.ResumeLayout(false);
            groupBoxUsl_KAT.ResumeLayout(false);
            groupBoxUsl_KAT.PerformLayout();
            panelLeft_KAT.ResumeLayout(false);
            groupBoxLeft_KAT.ResumeLayout(false);
            groupBoxLeft_KAT.PerformLayout();
            panelFill_KAT.ResumeLayout(false);
            groupBoxOutPutData_KAT.ResumeLayout(false);
            groupBoxOutPutData_KAT.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop_KAT;
        private Panel panelLeft_KAT;
        private Panel panelFill_KAT;
        private Splitter splitterLeft_KAT;
        private GroupBox groupBoxLeft_KAT;
        private TextBox textBoxIn_KAT;
        private GroupBox groupBoxOutPutData_KAT;
        private TextBox textBoxResult_KAT;
        private GroupBox groupBoxUsl_KAT;
        private TextBox textBoxUsl_KAT;
        private Button buttonOpenFile_KAT;
        private Button buttonDone_KAT;
        private Button buttonHelp_KAT;
        private OpenFileDialog openFileDialogTask_KAT;
        private ToolTip toolTipFile_KAT;
    }
}
