using Tyuiu.KadralinovaAT.Sprint6.Task5.V12.Lib;
namespace Tyuiu.KadralinovaAT.Sprint6.Task5.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidChecked()
        {
            string file = "InPutDataFileTask5V12.txt";
            string directory = @"C:\DataSprint6";
            string path = Path.Combine(directory, file);
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
