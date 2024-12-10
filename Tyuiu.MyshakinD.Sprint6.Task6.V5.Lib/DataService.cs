using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.MyshakinD.Sprint6.Task6.V5.Lib {
    public class DataService : ISprint6Task6V5 {
       
        public string CollectTextFromFile(string path)
        {
            string resstr = "";

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.Contains("l"))
                    {
                        resstr = resstr + " " + line;
                    }
                }
            }

            return resstr;
        }
    }
}
