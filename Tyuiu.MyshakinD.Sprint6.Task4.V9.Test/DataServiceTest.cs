using Tyuiu.MyshakinD.Sprint6.Task4.V9.Lib;

namespace Tyuiu.MyshakinD.Sprint6.Task4.V9.Test {
    [TestClass]
    public class DataServiceTest {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            double[] res = ds.GetMassFunction(startValue, stopValue);
            double[] wait = [-27.22, -22.25, -16.66, -11.04, -6.13, -3.0, 4.84, 8.86, 14.43, 20.18, 25.24];

            CollectionAssert.AreEqual(res, wait);
        }
    }
}