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
                // Чтение всех строк из файла
                string[] lines = File.ReadAllLines(path);

                // Преобразуем все строки в массив чисел (вещественные числа)
                var numbers = lines
                    .SelectMany(line => line.Split(new char[] { ' ', '\t', ',', ';' }, StringSplitOptions.RemoveEmptyEntries)) // Разделяем по пробелам, табуляции, запятой, точке с запятой
                    .Select(str =>
                    {
                        double num;
                        return double.TryParse(str, out num) ? num : (double?)null; // Преобразуем строку в число
                    })
                    .Where(num => num.HasValue) // Убираем null-значения
                    .Select(num => num.Value)
                    .ToList();

                // Ищем минимальное число, которое делится на 5
                var minDivisibleByFive = numbers
                    .Where(num => num % 5 == 0) // Фильтруем числа, которые делятся на 5
                    .OrderBy(num => num) // Сортируем по возрастанию
                    .FirstOrDefault(); // Берем первое минимальное (или 0, если нет)

                // Если число найдено, округляем до 3 знаков после запятой и возвращаем его
                if (minDivisibleByFive != 0)
                {
                    return Math.Round(minDivisibleByFive, 3);
                }
                else
                {
                    // Если числа, которые делятся на 5, нет, возвращаем -1 или какое-то другое значение
                    return 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при обработке файла: {ex.Message}");
                return 0;
            }
        }
    }
}
