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
            double res = 10000;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;


                while ((line = reader.ReadLine()) != null)
                {
                    foreach (char element in line)
                    {
                        if (element == ',')
                        {
                            if (Convert.ToDouble(line) % 5 == 0 && res > Convert.ToDouble(line))
                            {
                                res = Convert.ToDouble(line);
                                res = Math.Round(res, 3);


                            }
                        }

                    }

                }
            }
            return res;

        }
    }
}