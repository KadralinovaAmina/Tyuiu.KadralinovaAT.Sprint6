using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.KadralinovaAT.Sprint6.Task3.V29.Lib
{
    public class DataService : ISprint6Task3V29
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;

            int[,] res= (int[,])matrix.Clone();
            int[] five = new int[rows];

            for (int i = 0; i < rows; i++)
            {
                five[i] = res[i, 4];
            }
            Array.Sort(five);
            for (int i = 0; i < rows; i++)
            {
                res[i, 4] = five[i];
            }
            return res;
        }
    }
}
