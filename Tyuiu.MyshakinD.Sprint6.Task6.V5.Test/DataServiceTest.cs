using Tyuiu.MyshakinD.Sprint6.Task6.V5.Lib;

namespace Tyuiu.MyshakinD.Sprint6.Task6.V5.Test {
    [TestClass]
    public class DataServiceTest {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string path = @"C:\DataSprint5\InPutFileTask6V5.txt";

            string resstr = ds.CollectTextFromFile(path);

            string wait = "ulzPXa sMLuPzlvneiTo tfouGdncXlJ";

            Assert.AreEqual(wait, resstr);
        }
    }
}