using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.KadralinovaAT.Sprint6.Task7.V18.Lib
{
    public class DataService : ISprint6Task7V18
    {
        public int[,] GetMatrix(string path)
        {
            string[] lines = File.ReadAllLines(path);

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

            return array;
        }
    }
}
