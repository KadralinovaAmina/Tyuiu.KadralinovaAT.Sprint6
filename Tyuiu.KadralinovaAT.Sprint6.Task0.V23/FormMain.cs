using Tyuiu.KadralinovaAT.Sprint6.Task0.V23.Lib;
namespace Tyuiu.KadralinovaAT.Sprint6.Task0.V23
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonDone_KAT_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxResult_KAT.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxX_KAT.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void textBoxX_KATKeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }
        private void buttonHelp_KAT_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнила студентка группы ПИНб-25-1 Кадралинова Амина Тастемировна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
