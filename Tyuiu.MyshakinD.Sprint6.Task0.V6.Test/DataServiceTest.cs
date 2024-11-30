using Tyuiu.MyshakinD.Sprint6.Task0.V6.Lib;

namespace Tyuiu.MyshakinD.Sprint6.Task0.V6.Test {
    [TestClass]
    public class DataServiceTest {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int x = 3;

            double res = ds.Calculate(x);
            double wait = 0.866;

            Assert.AreEqual(res, wait);
        }
    }
}