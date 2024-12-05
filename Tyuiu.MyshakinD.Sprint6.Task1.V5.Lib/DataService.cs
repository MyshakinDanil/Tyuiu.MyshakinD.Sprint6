using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.MyshakinD.Sprint6.Task1.V5.Lib {
    public class DataService : ISprint6Task1V5 {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] res = new double[len];

            int count = 0;

            for (int i = startValue; i <= stopValue; i++)
            {
                res[count] = Math.Round(Math.Sin(i) + (Math.Cos(2 * i) / 2) - 1.5 * i, 2);
                count++;
            }

            return res;
        }
    }
}
