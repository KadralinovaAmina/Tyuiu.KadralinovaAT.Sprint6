using System.Windows.Forms.DataVisualization.Charting;
using Tyuiu.KadralinovaAT.Sprint6.Task2.V26.Lib;
namespace Tyuiu.KadralinovaAT.Sprint6.Task2.V26
{
    public partial class FormMain : Form
    {
        private Chart chartFunction;
        public FormMain()
        {
            InitializeComponent();
            chartFunction = new Chart();
            chartFunction.Location = new Point(20, 200);
            chartFunction.Size = new Size(600, 300);
            chartFunction.Name = "chartFunction";

            ChartArea chartArea = new ChartArea();
            chartFunction.ChartAreas.Add(chartArea);

            this.Controls.Add(chartFunction);
        }
        DataService ds = new DataService();
        private void buttonDone_KAT_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStep_KAT.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep_KAT.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                chartFunction.Series.Clear();

                Series series = new Series();
                series.Name = "FunctionGraph";
                series.ChartType = SeriesChartType.Line;
                series.Color = Color.Blue;
                series.BorderWidth = 2;

                int x = startStep;
                for (int i = 0; i < valueArray.Length; i++)
                {
                    series.Points.AddXY(x, valueArray[i]);
                    x++;
                }

                chartFunction.Series.Add(series);
                this.chartFunction.Titles.Clear();
                this.chartFunction.Titles.Add("График функции sin(x) + cos(2x)/2 - 1.5x");
                this.chartFunction.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewFunction.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));
                    this.chartFunction.Series[0].Points.AddXY(startStep, valueArray[i]);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonDone_KAT_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_KAT.BackColor = Color.Red;
        }
        private void buttonDone_KAT_MouseLeave(object sender, EventArgs e)
        {
            buttonDone_KAT.BackColor = Color.Green;
        }
        private void buttonDone_KAT_MouseDown(object sender, EventArgs e)
        {
            buttonDone_KAT.BackColor = Color.Blue;
        }
        private void buttonHelp_KAT_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнила студентка группы ПИНб-25-1 Кадралинова Амина Тастемировна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
