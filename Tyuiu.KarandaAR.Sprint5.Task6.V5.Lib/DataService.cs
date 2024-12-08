using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KarandaAR.Sprint5.Task6.V5.Lib
{
    public class DataService : ISprint5Task6V5
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    for (int i = 0; i < line.Length; i++)
                    {
                        if (line[i] >= 'A' && line[i] <= 'Z')
                        {
                            count++;
                        }
                    }
                }
            }
            return count;
        }
    }
}
