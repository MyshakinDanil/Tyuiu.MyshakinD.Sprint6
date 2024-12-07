using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.MyshakinD.Sprint6.Task2.V18.Lib {
    public class DataService : ISprint6Task2V18 {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int count = 0;

            int len = stopValue - startValue + 1;
            double[] res = new double[len];

            for (int x = startValue; x <= stopValue; x++)
            {
                if (4 * x - 0.5 == 0)
                {
                    res[count] = 0;
                    count++;
                }
                else
                {
                    res[count] = Math.Round((3 * Math.Cos(x) / (4 * x - 0.5)) + Math.Sin(x) - 5 * x - 2, 2);
                    count++;
                }
            }

            return res;
        }
    }
}
