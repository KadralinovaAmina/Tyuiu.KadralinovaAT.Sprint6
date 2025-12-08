using System.Text;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.KadralinovaAT.Sprint6.Task6.V21.Lib
{
    public class DataService : ISprint6Task6V21
    {
        public string CollectTextFromFile(string path)
        {
            StringBuilder result = new StringBuilder();

            using (StreamReader reader = new StreamReader(path, Encoding.UTF8))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    
                    string[] words = line.Split(
                        new[] { ' ', '\t' },
                        StringSplitOptions.RemoveEmptyEntries
                    );

                    foreach (string word in words)
                    {
                        
                        if (word.IndexOf('g', StringComparison.OrdinalIgnoreCase) >= 0)
                        {
                            result.Append(word).Append(" ");
                        }
                    }
                }
            }

            return result.ToString().Trim();
        }
    }
}
