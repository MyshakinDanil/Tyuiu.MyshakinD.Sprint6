using System.Data;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.MyshakinD.Sprint6.Task7.V8.Lib {
    public class DataService : ISprint6Task7V8 {
        public int[,] GetMatrix(string path)
        {
            string filedata = File.ReadAllText(path);

            filedata = filedata.Replace('\n', '\r');
            string[] lines = filedata.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            int rows = lines.Length;
            int columns = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] line_r = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    arrayValues[i, j] = Convert.ToInt32(line_r[j]);
                }
            }

            int xCol = 8;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0;j < columns; j++)
                {
                    if (arrayValues[i, j] != 5 && i == 8)
                    {
                        arrayValues[i, j] = -1;
                    }
                }
            }

            return arrayValues;
        }
    }
}
