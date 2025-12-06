using System.Drawing.Drawing2D;
using Tyuiu.KadralinovaAT.Sprint6.Task3.V29.Lib;
namespace Tyuiu.KadralinovaAT.Sprint6.Task3.V29
{
    public partial class FormMain_KAT : Form
    {
        public FormMain_KAT()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        int[,] mtrx = new int[5, 5] { { -2, -13, -15,  -9, -17 },
                                          { 13, -20, -15,  27, 18 },
                                          { -12, -1, -20,  13,  0 },
                                          { 15, 32,  18, -12, -18 },
                                          { 16,  5,   3,  -5,  -8 } };
        private void FormMain_KAT_Load(object sender, EventArgs e)
        {
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;

            dataGridViewMatrix_KAT.ColumnCount = columns;
            dataGridViewMatrix_KAT.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewMatrix_KAT.Columns[i].Width = 40;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMatrix_KAT.Rows[i].Cells[j].Value = mtrx[i, j].ToString();
                }
            }
        }
        private void buttonDone_KAT_Click(object sender, EventArgs e)
        {
            try
            {
                int[,] sort = ds.Calculate(mtrx);

                for (int i = 0; i < 5; i++)
                {
                    textBoxResult_KAT.Text += sort[i, 4] + " ";
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonHelp_KAT_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнила студентка группы ПИНб-25-1 Кадралинова Амина Тастемировна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
