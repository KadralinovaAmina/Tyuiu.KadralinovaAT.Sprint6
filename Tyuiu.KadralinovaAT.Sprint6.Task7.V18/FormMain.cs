using Tyuiu.KadralinovaAT.Sprint6.Task7.V18.Lib;
using System.Windows.Forms;

namespace Tyuiu.KadralinovaAT.Sprint6.Task7.V18
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            openFileDialogTask_KAT.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            SaveFileDialogMatrix_KAT.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }

        static int rows;
        static int colums;
        static string openFilePath;

        DataService ds = new DataService();

        public static int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);

            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            colums = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, colums];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < colums; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }
            return arrayValues;

        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            buttonOpen_KAT.Visible = true;
            buttonDone_KAT.Visible = true;
            buttonSave_KAT.Visible = true;
            buttonHelp_KAT.Visible = true;
            dataGridViewIn_KAT.Visible = true;
            dataGridViewOut_KAT.Visible = true;
        }
        private void buttonOpen_KAT_Click(object sender, EventArgs e)
        {
            openFileDialogTask_KAT.ShowDialog();
            openFilePath = openFileDialogTask_KAT.FileName;

            int[,] arrayValues = new int[rows, colums];

            arrayValues = LoadFromFileData(openFilePath);

            dataGridViewIn_KAT.ColumnCount = colums;
            dataGridViewIn_KAT.RowCount = rows;
            dataGridViewOut_KAT.ColumnCount = colums;
            dataGridViewOut_KAT.RowCount = rows;

            for (int i = 0; i < colums; i++)
            {
                dataGridViewIn_KAT.Columns[i].Width = 50;
                dataGridViewOut_KAT.Columns[i].Width = 50;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < colums; c++)
                {
                    dataGridViewIn_KAT.Rows[r].Cells[c].Value = arrayValues[r, c];
                }            
            }

            arrayValues = ds.GetMatrix(openFilePath);
            buttonDone_KAT.Enabled = true;
        }

        private void buttonHelp_KAT_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
        private void buttonDone_KAT_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, colums];
            arrayValues = ds.GetMatrix(openFilePath);
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < colums; c++)
                {
                    dataGridViewOut_KAT.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            buttonSave_KAT.Enabled = true;
        }
        private void buttonSave_KAT_Click(object sender, EventArgs e)
        {
            SaveFileDialogMatrix_KAT.FileName = "OutPutFileTask7.csv";
            SaveFileDialogMatrix_KAT.InitialDirectory = Directory.GetCurrentDirectory();
            SaveFileDialogMatrix_KAT.ShowDialog();
            string path = SaveFileDialogMatrix_KAT.FileName;
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }
            int rows = dataGridViewOut_KAT.RowCount;
            int columns = dataGridViewOut_KAT.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOut_KAT.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOut_KAT.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }
        private void buttonOpen_KAT_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_KAT.ToolTipTitle = "Открыть файл";
        }
        private void buttonDone_KAT_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_KAT.ToolTipTitle = "Выполнить";
        }
        private void buttonSave_KAT_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_KAT.ToolTipTitle = "Сохранить в файл";
        }
        private void buttonHelp_KAT_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_KAT.ToolTipTitle = "Справка";
        }
    }
}
