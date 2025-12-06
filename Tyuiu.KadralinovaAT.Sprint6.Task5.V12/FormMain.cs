using Tyuiu.KadralinovaAT.Sprint6.Task5.V12.Lib;
namespace Tyuiu.KadralinovaAT.Sprint6.Task5.V12
{
    public partial class FormMain_KAT : Form
    {
        public FormMain_KAT()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string path = @"C:\DataSprint6\InPutDataFileTask5V12.txt";

        private void buttonDone_KAT_Click(object sender, EventArgs e)
        {
            dataGridViewNums_KAT.ColumnCount = 2;
            dataGridViewNums_KAT.Columns[0].Width = 20;
            dataGridViewNums_KAT.Columns[1].Width = 50;

            this.chartDiag_KAT.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartDiag_KAT.ChartAreas[0].AxisY.Title = "Ось Y";

            chartDiag_KAT.Series[0].Points.Clear();

            double[] numsMass = new double[ds.len];
            numsMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewNums_KAT.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartDiag_KAT.Series[0].Points.AddXY(i, numsMass[i]);
            }
        }

        private void buttonOpenFile_KAT_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }
        private void buttonHelp_KAT_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнила студентка группы ПИНб-25-1 Кадралинова Амина Тастемировна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
