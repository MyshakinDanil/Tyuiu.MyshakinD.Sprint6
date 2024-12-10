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

            string wait = " UPPfdzU ulzPXa UpGwjzkBH xvfsWpk KyiidnDo FVUh XNQBU sMLuPzlvneiTo XIpph QN hZznJL bWk Rz tfouGdncXlJ";

            Assert.AreEqual(wait, resstr);
        }
    }
}