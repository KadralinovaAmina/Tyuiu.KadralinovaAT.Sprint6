namespace Tyuiu.KadralinovaAT.Sprint6.Task7.V18
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
            buttonSave_KAT = new Button();
            buttonDone_KAT = new Button();
            buttonOpen_KAT = new Button();
            groupBoxUsl_KAT = new GroupBox();
            textBoxUsl_KAT = new TextBox();
            panelLeft_KAT = new Panel();
            groupBoxVvod_KAT = new GroupBox();
            dataGridViewIn_KAT = new DataGridView();
            panelRight_KAT = new Panel();
            groupBoxVivod_KAT = new GroupBox();
            dataGridViewOut_KAT = new DataGridView();
            splitter_KAT = new Splitter();
            openFileDialogTask_KAT = new OpenFileDialog();
            toolTipButton_KAT = new ToolTip(components);
            SaveFileDialogMatrix_KAT = new SaveFileDialog();
            panelTop_KAT.SuspendLayout();
            groupBoxUsl_KAT.SuspendLayout();
            panelLeft_KAT.SuspendLayout();
            groupBoxVvod_KAT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn_KAT).BeginInit();
            panelRight_KAT.SuspendLayout();
            groupBoxVivod_KAT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_KAT).BeginInit();
            SuspendLayout();
            // 
            // panelTop_KAT
            // 
            panelTop_KAT.Controls.Add(buttonHelp_KAT);
            panelTop_KAT.Controls.Add(buttonSave_KAT);
            panelTop_KAT.Controls.Add(buttonDone_KAT);
            panelTop_KAT.Controls.Add(buttonOpen_KAT);
            panelTop_KAT.Controls.Add(groupBoxUsl_KAT);
            panelTop_KAT.Dock = DockStyle.Top;
            panelTop_KAT.Location = new Point(0, 0);
            panelTop_KAT.Name = "panelTop_KAT";
            panelTop_KAT.Size = new Size(1182, 162);
            panelTop_KAT.TabIndex = 0;
            // 
            // buttonHelp_KAT
            // 
            buttonHelp_KAT.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_KAT.BackColor = SystemColors.ButtonFace;
            buttonHelp_KAT.Image = Properties.Resources.help;
            buttonHelp_KAT.Location = new Point(1110, 3);
            buttonHelp_KAT.Name = "buttonHelp_KAT";
            buttonHelp_KAT.Size = new Size(66, 73);
            buttonHelp_KAT.TabIndex = 1;
            toolTipButton_KAT.SetToolTip(buttonHelp_KAT, "О программе");
            buttonHelp_KAT.UseVisualStyleBackColor = false;
            buttonHelp_KAT.Click += buttonHelp_KAT_Click;
            buttonHelp_KAT.MouseEnter += buttonHelp_KAT_MouseEnter;
            // 
            // buttonSave_KAT
            // 
            buttonSave_KAT.Enabled = false;
            buttonSave_KAT.FlatStyle = FlatStyle.Flat;
            buttonSave_KAT.Image = Properties.Resources.page_save;
            buttonSave_KAT.Location = new Point(237, 3);
            buttonSave_KAT.Name = "buttonSave_KAT";
            buttonSave_KAT.Size = new Size(111, 73);
            buttonSave_KAT.TabIndex = 1;
            toolTipButton_KAT.SetToolTip(buttonSave_KAT, "Сохранить обработанные данные в файл в формате CSV");
            buttonSave_KAT.UseVisualStyleBackColor = true;
            buttonSave_KAT.Click += buttonSave_KAT_Click;
            buttonSave_KAT.MouseEnter += buttonSave_KAT_MouseEnter;
            // 
            // buttonDone_KAT
            // 
            buttonDone_KAT.Enabled = false;
            buttonDone_KAT.FlatStyle = FlatStyle.Flat;
            buttonDone_KAT.Image = Properties.Resources.page_white_go;
            buttonDone_KAT.Location = new Point(120, 3);
            buttonDone_KAT.Name = "buttonDone_KAT";
            buttonDone_KAT.Size = new Size(111, 73);
            buttonDone_KAT.TabIndex = 1;
            toolTipButton_KAT.SetToolTip(buttonDone_KAT, "Выполнить обработку данных");
            buttonDone_KAT.UseVisualStyleBackColor = true;
            buttonDone_KAT.Click += buttonDone_KAT_Click;
            buttonDone_KAT.MouseEnter += buttonDone_KAT_MouseEnter;
            // 
            // buttonOpen_KAT
            // 
            buttonOpen_KAT.Image = Properties.Resources.folder_page_white;
            buttonOpen_KAT.Location = new Point(3, 3);
            buttonOpen_KAT.Name = "buttonOpen_KAT";
            buttonOpen_KAT.Size = new Size(111, 73);
            buttonOpen_KAT.TabIndex = 1;
            toolTipButton_KAT.SetToolTip(buttonOpen_KAT, "Открыть файл для обработки данных в формате CSV");
            buttonOpen_KAT.UseVisualStyleBackColor = true;
            buttonOpen_KAT.Click += buttonOpen_KAT_Click;
            buttonOpen_KAT.MouseEnter += buttonOpen_KAT_MouseEnter;
            // 
            // groupBoxUsl_KAT
            // 
            groupBoxUsl_KAT.Controls.Add(textBoxUsl_KAT);
            groupBoxUsl_KAT.Dock = DockStyle.Bottom;
            groupBoxUsl_KAT.Location = new Point(0, 76);
            groupBoxUsl_KAT.Name = "groupBoxUsl_KAT";
            groupBoxUsl_KAT.Size = new Size(1182, 86);
            groupBoxUsl_KAT.TabIndex = 0;
            groupBoxUsl_KAT.TabStop = false;
            groupBoxUsl_KAT.Text = "Условие";
            // 
            // textBoxUsl_KAT
            // 
            textBoxUsl_KAT.BackColor = SystemColors.Control;
            textBoxUsl_KAT.BorderStyle = BorderStyle.None;
            textBoxUsl_KAT.Dock = DockStyle.Bottom;
            textBoxUsl_KAT.Location = new Point(3, 26);
            textBoxUsl_KAT.Multiline = true;
            textBoxUsl_KAT.Name = "textBoxUsl_KAT";
            textBoxUsl_KAT.Size = new Size(1176, 57);
            textBoxUsl_KAT.TabIndex = 0;
            textBoxUsl_KAT.Text = resources.GetString("textBoxUsl_KAT.Text");
            // 
            // panelLeft_KAT
            // 
            panelLeft_KAT.Controls.Add(groupBoxVvod_KAT);
            panelLeft_KAT.Dock = DockStyle.Left;
            panelLeft_KAT.Location = new Point(0, 162);
            panelLeft_KAT.Name = "panelLeft_KAT";
            panelLeft_KAT.Size = new Size(583, 491);
            panelLeft_KAT.TabIndex = 1;
            // 
            // groupBoxVvod_KAT
            // 
            groupBoxVvod_KAT.Controls.Add(dataGridViewIn_KAT);
            groupBoxVvod_KAT.Dock = DockStyle.Fill;
            groupBoxVvod_KAT.Location = new Point(0, 0);
            groupBoxVvod_KAT.Name = "groupBoxVvod_KAT";
            groupBoxVvod_KAT.Padding = new Padding(5);
            groupBoxVvod_KAT.Size = new Size(583, 491);
            groupBoxVvod_KAT.TabIndex = 0;
            groupBoxVvod_KAT.TabStop = false;
            groupBoxVvod_KAT.Text = "Ввод";
            // 
            // dataGridViewIn_KAT
            // 
            dataGridViewIn_KAT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewIn_KAT.ColumnHeadersVisible = false;
            dataGridViewIn_KAT.Dock = DockStyle.Fill;
            dataGridViewIn_KAT.Location = new Point(5, 25);
            dataGridViewIn_KAT.Name = "dataGridViewIn_KAT";
            dataGridViewIn_KAT.RowHeadersVisible = false;
            dataGridViewIn_KAT.RowHeadersWidth = 51;
            dataGridViewIn_KAT.Size = new Size(573, 461);
            dataGridViewIn_KAT.TabIndex = 0;
            // 
            // panelRight_KAT
            // 
            panelRight_KAT.Controls.Add(groupBoxVivod_KAT);
            panelRight_KAT.Dock = DockStyle.Fill;
            panelRight_KAT.Location = new Point(583, 162);
            panelRight_KAT.Name = "panelRight_KAT";
            panelRight_KAT.Size = new Size(599, 491);
            panelRight_KAT.TabIndex = 2;
            // 
            // groupBoxVivod_KAT
            // 
            groupBoxVivod_KAT.Controls.Add(dataGridViewOut_KAT);
            groupBoxVivod_KAT.Dock = DockStyle.Fill;
            groupBoxVivod_KAT.Location = new Point(0, 0);
            groupBoxVivod_KAT.Name = "groupBoxVivod_KAT";
            groupBoxVivod_KAT.Padding = new Padding(5);
            groupBoxVivod_KAT.Size = new Size(599, 491);
            groupBoxVivod_KAT.TabIndex = 1;
            groupBoxVivod_KAT.TabStop = false;
            groupBoxVivod_KAT.Text = "Вывод";
            // 
            // dataGridViewOut_KAT
            // 
            dataGridViewOut_KAT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOut_KAT.ColumnHeadersVisible = false;
            dataGridViewOut_KAT.Dock = DockStyle.Fill;
            dataGridViewOut_KAT.Location = new Point(5, 25);
            dataGridViewOut_KAT.Name = "dataGridViewOut_KAT";
            dataGridViewOut_KAT.RowHeadersVisible = false;
            dataGridViewOut_KAT.RowHeadersWidth = 51;
            dataGridViewOut_KAT.Size = new Size(589, 461);
            dataGridViewOut_KAT.TabIndex = 0;
            // 
            // splitter_KAT
            // 
            splitter_KAT.Location = new Point(583, 162);
            splitter_KAT.Name = "splitter_KAT";
            splitter_KAT.Size = new Size(4, 491);
            splitter_KAT.TabIndex = 3;
            splitter_KAT.TabStop = false;
            // 
            // openFileDialogTask_KAT
            // 
            openFileDialogTask_KAT.FileName = "openFileDialogTask_KAT";
            // 
            // toolTipButton_KAT
            // 
            toolTipButton_KAT.IsBalloon = true;
            toolTipButton_KAT.ToolTipTitle = "Подсказка";
            // 
            // SaveFileDialogMatrix_KAT
            // 
            SaveFileDialogMatrix_KAT.FileName = "SaveFileDialogMatrix_KAT";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 653);
            Controls.Add(splitter_KAT);
            Controls.Add(panelRight_KAT);
            Controls.Add(panelLeft_KAT);
            Controls.Add(panelTop_KAT);
            MinimumSize = new Size(900, 600);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 7 | Вариант 18 | Кадралинова А.Т.";
            Load += FormMain_Load;
            panelTop_KAT.ResumeLayout(false);
            groupBoxUsl_KAT.ResumeLayout(false);
            groupBoxUsl_KAT.PerformLayout();
            panelLeft_KAT.ResumeLayout(false);
            groupBoxVvod_KAT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn_KAT).EndInit();
            panelRight_KAT.ResumeLayout(false);
            groupBoxVivod_KAT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_KAT).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop_KAT;
        private GroupBox groupBoxUsl_KAT;
        private TextBox textBoxUsl_KAT;
        private Button buttonHelp_KAT;
        private Button buttonSave_KAT;
        private Button buttonDone_KAT;
        private Button buttonOpen_KAT;
        private Panel panelLeft_KAT;
        private GroupBox groupBoxVvod_KAT;
        private DataGridView dataGridViewIn_KAT;
        private Panel panelRight_KAT;
        private GroupBox groupBoxVivod_KAT;
        private DataGridView dataGridViewOut_KAT;
        private Splitter splitter_KAT;
        private OpenFileDialog openFileDialogTask_KAT;
        private ToolTip toolTipButton_KAT;
        private SaveFileDialog SaveFileDialogMatrix_KAT;
    }
}
