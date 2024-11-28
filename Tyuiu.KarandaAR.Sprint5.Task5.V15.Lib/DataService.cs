using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KarandaAR.Sprint5.Task5.V15.Lib
{
    public class DataService : ISprint5Task5V15
    {
        public double LoadFromDataFile(string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                List<double> positiveNumbers = new List<double>();

                string line;

                while ((line = reader.ReadLine()) != null)
                {

                    var values = line.Split(new[] { ' ', ',', ';', '\t' }, StringSplitOptions.RemoveEmptyEntries);


                    foreach (var value in values)
                    {
                        if (double.TryParse(value, out double number) && number % 5 == 0 && number > 0)
                        {
                            positiveNumbers.Add(number);
                        }
                    }
                }
                return (Math.Min(positiveNumbers.Average(), 3));
            }
        }
    }
}
