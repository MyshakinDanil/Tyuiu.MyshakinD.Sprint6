using Tyuiu.MyshakinD.Sprint6.Task1.V5.Lib;

namespace Tyuiu.MyshakinD.Sprint6.Task1.V5.Test {
    [TestClass]
    public class DataServiceTest {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;
            int len = stopValue - startValue + 1;

            double[] valueWaitArray;
            valueWaitArray = new double[len];

            valueWaitArray = [ 8.04, 6.68, 4.84, 1.76, 0.45, 0.5, -0.87, -2.42, -3.88, -6.83, -8.88 ];

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(res, valueWaitArray);
        }
    }
}