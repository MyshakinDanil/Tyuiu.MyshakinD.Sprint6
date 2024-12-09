using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.MyshakinD.Sprint6.Task4.V9.Lib {
    public class DataService : ISprint6Task4V9 {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;

            double[] res = new double[len];

            int count = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                if (Math.Cos(x) - 2 * x == 0)
                {
                    res[count] = 0;
                    count++;
                }
                else
                {
                    res[count] = Math.Round(((2 * x - 3) / (Math.Cos(x) - 2 * x)) + 5 * x - Math.Sin(x), 2);
                    count++;
                }
            }
            
            return res;
        }
    }
}
