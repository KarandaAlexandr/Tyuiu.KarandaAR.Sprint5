using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.KarandaAR.Sprint5.Task0.V16.Lib
{
    public class DataService : ISprint5Task0V16
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(new string[] { Path.GetTempPath(), "OutPutFileTask0.txt" });
            double y = (2*x*x - 1) / Math.Sqrt(x*x - 2);
            y = Math.Round(y, 3);
            File.WriteAllText(path, Convert.ToString(y));
            return path;
        }
    }
}
