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
            try
            {
                // Чтение данных из файла
                string[] lines = File.ReadAllLines(path);

                // Преобразуем все строки в массив чисел (вещественные числа)
                var numbers = lines
                    .SelectMany(line => line.Split(new char[] { ' ', '\t', ',' }, StringSplitOptions.RemoveEmptyEntries)) // Разделение по пробелам, табуляции и запятой
                    .Select(str =>
                    {
                        double num;
                        return double.TryParse(str, out num) ? num : (double?)null;
                    })
                    .Where(num => num.HasValue)
                    .Select(num => num.Value)
                    .ToList();

                // Ищем минимальное число, которое делится на 5
                var minDivisibleByFive = numbers
                    .Where(num => num % 5 == 0) // Фильтруем числа, которые делятся на 5
                    .OrderBy(num => num) // Сортируем по возрастанию
                    .FirstOrDefault(); // Берем первое минимальное

                if (minDivisibleByFive != 0)
                {
                    return minDivisibleByFive;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }

        }
    }
}