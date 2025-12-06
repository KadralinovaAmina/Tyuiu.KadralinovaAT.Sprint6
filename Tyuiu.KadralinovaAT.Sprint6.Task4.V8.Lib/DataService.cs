using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.KadralinovaAT.Sprint6.Task4.V8.Lib
{
    public class DataService : ISprint6Task4V8
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double y;
            int count = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                if (x == 2)
                {
                    y = 0;
                }
                else
                {
                    y = Math.Sin(x) + (Math.Cos(x) + 1) / (2 - x) + 2 * x;
                }

                valueArray[count] = Math.Round(y, 2);
                count++;
            }

            return valueArray;
        }
    }
}
