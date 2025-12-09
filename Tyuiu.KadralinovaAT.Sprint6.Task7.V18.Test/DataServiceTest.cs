using Tyuiu.KadralinovaAT.Sprint6.Task7.V18.Lib;
namespace Tyuiu.KadralinovaAT.Sprint6.Task7.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidMatrix()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint6\InPutDataFileTask7V18.csv";
            string fileData = File.ReadAllText(path);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            int rows = lines.Length;
            int columns = lines[0].Split(';').Length;

            int[,] array = new int[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    array[r, c] = Convert.ToInt32(line_r[c]);
                }
            }

            for (int r = 0; r < rows; r++)
            {
                if (array[r, 8] != 11)
                {
                    array[r, 8] = 11;
                }
            }

            int[,] res = ds.GetMatrix(path);

            CollectionAssert.AreEqual(array, res);
        }
    }
}
