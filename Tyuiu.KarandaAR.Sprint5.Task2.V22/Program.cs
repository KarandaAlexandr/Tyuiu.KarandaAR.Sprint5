using Tyuiu.KarandaAR.Sprint5.Task2.V22.Lib;

namespace Tyuiu.KarandaAR.Sprint5.Task2.V22
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[,] mtrx = new int[3, 3] { { -8, -1, -9 },
                                          { 8, 5, 5 },
                                          { 9, 6, -2 } };
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;

            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Каранда А. Р. | АСОиУб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Работа с файлами                                                  *");
            Console.WriteLine("* Вариант #22                                                             *");
            Console.WriteLine("* Выполнил: Каранда Александр Романович | АСОиУб-24-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 3 на 3 элементов, заполненный        *");
            Console.WriteLine("* значениями с клавиатуры. Заменить положительные элементы массива на 1,  *");
            Console.WriteLine("* отрицательные на 0.                                                     *");
            Console.WriteLine("* Результат сохранить в файл OutPutFileTask2.csv и вывести на консоль.    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ВХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("* Массив:                                                                 *");
            Console.WriteLine("* -8, -1, -9                                                              *");
            Console.WriteLine("*  8,  5,  5                                                              *");
            Console.WriteLine("*  9,  6, -2                                                              *");
            Console.WriteLine("***************************************************************************");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{mtrx[i, j]} \t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = ds.SaveToFileTextData(mtrx);

            Console.WriteLine(" Файл: " + res);
            Console.WriteLine(" Создан!");
            Console.ReadKey();
        }
    }
}
