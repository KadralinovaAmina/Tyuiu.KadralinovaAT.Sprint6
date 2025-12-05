using Tyuiu.KadralinovaAT.Sprint6.Task1.V12.Lib;
namespace Tyuiu.KadralinovaAT.Sprint6.Task1.V12
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        private void buttonDone_KAT_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStep_KAT.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep_KAT.Text);

                string strLine;
                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);
                textBoxResult_KAT.Text = "";
                textBoxResult_KAT.AppendText("+----------+----------+" + Environment.NewLine);
                textBoxResult_KAT.AppendText("+    X     +   f(x)   +" + Environment.NewLine);
                textBoxResult_KAT.AppendText("+----------+----------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,5:d}      |   {1, 5:f2} | ", startStep, valueArray[i]);
                    textBoxResult_KAT.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }

                textBoxResult_KAT.AppendText("+----------+----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonHelp_KAT_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнила студентка группы ПИНб-25-1 Кадралинова Амина Тастемировна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
