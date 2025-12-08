using Tyuiu.KadralinovaAT.Sprint6.Task6.V21.Lib;
namespace Tyuiu.KadralinovaAT.Sprint6.Task6.V21
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        string openFilePath;
        DataService ds = new DataService();
        private void buttonOpenFile_KAT_Click(object sender, EventArgs e)
        {
            openFileDialogTask_KAT.ShowDialog();
            openFilePath = openFileDialogTask_KAT.FileName;
            textBoxIn_KAT.Text = File.ReadAllText(openFilePath);
            groupBoxOutPutData_KAT.Text = groupBoxOutPutData_KAT.Text + " " + openFileDialogTask_KAT.FileName;
            buttonDone_KAT.Enabled = true;
        }

        private void buttonHelp_KAT_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonDone_KAT_Click(object sender, EventArgs e)
        {
            textBoxResult_KAT.Text = ds.CollectTextFromFile(openFilePath);
        }
    }
}
