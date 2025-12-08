namespace Tyuiu.KadralinovaAT.Sprint6.Task6.V21
{
    partial class FormAbout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            pictureBoxMe_KAT = new PictureBox();
            labelAbout_KAT = new Label();
            buttonOK_KAT = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMe_KAT).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxMe_KAT
            // 
            pictureBoxMe_KAT.Image = Properties.Resources.я;
            pictureBoxMe_KAT.Location = new Point(12, 22);
            pictureBoxMe_KAT.Name = "pictureBoxMe_KAT";
            pictureBoxMe_KAT.Size = new Size(142, 247);
            pictureBoxMe_KAT.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxMe_KAT.TabIndex = 0;
            pictureBoxMe_KAT.TabStop = false;
            // 
            // labelAbout_KAT
            // 
            labelAbout_KAT.Location = new Point(180, 22);
            labelAbout_KAT.Name = "labelAbout_KAT";
            labelAbout_KAT.Size = new Size(404, 222);
            labelAbout_KAT.TabIndex = 1;
            labelAbout_KAT.Text = resources.GetString("labelAbout_KAT.Text");
            // 
            // buttonOK_KAT
            // 
            buttonOK_KAT.BackColor = SystemColors.ButtonFace;
            buttonOK_KAT.Location = new Point(490, 240);
            buttonOK_KAT.Name = "buttonOK_KAT";
            buttonOK_KAT.Size = new Size(94, 29);
            buttonOK_KAT.TabIndex = 2;
            buttonOK_KAT.Text = "Ок";
            buttonOK_KAT.UseVisualStyleBackColor = false;
            buttonOK_KAT.Click += buttonOK_KAT_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(611, 290);
            Controls.Add(buttonOK_KAT);
            Controls.Add(labelAbout_KAT);
            Controls.Add(pictureBoxMe_KAT);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBoxMe_KAT).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBoxMe_KAT;
        private Label labelAbout_KAT;
        private Button buttonOK_KAT;
    }
}