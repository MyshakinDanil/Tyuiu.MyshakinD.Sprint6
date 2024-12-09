using Tyuiu.MyshakinD.Sprint6.Task5.V22.Lib;

namespace Tyuiu.MyshakinD.Sprint6.Task5.V22.Test {
    [TestClass]
    public class DataServiceTest {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string path = @"C:\DataSprint5\InPutDataFileTask5V22.txt";
            
            double[] res = ds.LoadFromDataFile(path);

            double[] wait = [19.03, 11, 6.55, 5.46, 16, 18, 11, 17, 8.63, 7.56, 19.91];

            CollectionAssert.AreEqual(res, wait);
        }
    }
}