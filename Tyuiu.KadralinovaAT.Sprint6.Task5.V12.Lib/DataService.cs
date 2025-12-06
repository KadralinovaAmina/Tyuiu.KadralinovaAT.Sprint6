using System.Security.Cryptography.X509Certificates;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.KadralinovaAT.Sprint6.Task5.V12.Lib
{
    public class DataService : ISprint6Task5V12
    {
        public int len = 0;
        public double[] LoadFromDataFile(string path)
        {

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    len++;
                }
            }

            double[] numsArray = new double[len];

            int index = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string formattedNum = line.Replace('.', ',');
                    numsArray[index] = Convert.ToDouble(formattedNum);
                    index++;
                }
            }

            numsArray = numsArray.Where(val => Math.Abs(val % 5) > 0.000001).ToArray();

            for (int i = 0; i < numsArray.Length; i++)
            {
                numsArray[i] = Math.Round(numsArray[i], 3);
            }

            return numsArray;
        }
    }
}
