using System.Diagnostics.Tracing;
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
                    string[] words = line.Split(' ');
                    foreach (string word in words)
                    {
                        if (word.Contains("l"))
                        {
                            resstr = resstr + " " + word;
                        }
                    }
                }
            }

            return resstr[1..];
        }
    }
}
