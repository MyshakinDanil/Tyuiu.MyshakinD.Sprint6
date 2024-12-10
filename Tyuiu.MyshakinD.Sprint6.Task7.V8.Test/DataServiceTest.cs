using Tyuiu.MyshakinD.Sprint6.Task7.V8.Lib;

namespace Tyuiu.MyshakinD.Sprint6.Task7.V8.Test {
    [TestClass]
    public class DataServiceTest {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string path = @"C:\DataSprint5\InPutFileTask7V8.csv";

            int[,] res = ds.GetMatrix(path);

            int[,] wait =
            {
                { -14, -20, -20, 19, -1, -10, -8, 0, -1, -6 },
                { 17,6,6,4,-2,17,18,13,-1,-6 },
                { 16, 12, -17, -1, -11, 17, 15, -20, -1,11 },
                { 12,-17,-18,-4,-1,3,13,-8,-1,10 },
                { -17,9,-10,-3,-16,-3,3,0,-1,16 },
                { -14,5,-1,-4,17,16,-9,5,-1,18 },
                { -12,-4,17,0,1,14,4,-20,-1,-7 },
                { 15,-11,15,-14,20,12,-3,2,-1,-8 },
                { 19,8,9,19,3,14,-1,15,-1,4 },
                { -5,-16,-12,18,-7,-5,-6,-4,-1,0 },
            };
        }
    }
}