using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.KarandaAR.Sprint5.Task3.V18.Lib
{
    public class DataService : ISprint5Task3V18
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(new string[] { Path.GetTempPath(), "OutPutFileTask3.bin" });
            double z = 2.12 * Math.Pow(x, 3) + 1.05 * Math.Pow(x, 2) + (4.1 * x) * 2;
            z = Math.Round(z, 3);
            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate)))
            {
                writer.Write(BitConverter.GetBytes(z));
            }

            return path;
        }
    }
}