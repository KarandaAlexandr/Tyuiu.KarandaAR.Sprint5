using Tyuiu.KarandaAR.Sprint5.Task5.V15.Lib;

namespace Tyuiu.KarandaAR.Sprint5.Task5.V15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Каранда А. Р. | АСОиУб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Работа с файлами                                                  *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выполнил: Каранда Александр Романович | АСОиУб-24-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл C:\\DataSprint5\\InPutDataFileTask5V15.txt                     *");
            Console.WriteLine("* (файл взять из архива согласно вашему варианту).                        *");
            Console.WriteLine("* Создать папку вручную C:\\DataSprint5\\ и скопировать в неё файл.       *");
            Console.WriteLine("* В файле содержится набор вещественных значений.                         *");
            Console.WriteLine("* Найти минимальное вещественное число в файле, которое делится на 5.     *");
            Console.WriteLine("* Полученный результат вывести на консоль.                                *");
            Console.WriteLine("* У вещественных значений округлить до трёх знаков после запятой.         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("***************************************************************************");
            string path = @"C:\DataSprint5\InPutDataFileTask5V15.txt";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            double res = ds.LoadFromDataFile(path);

            Console.WriteLine("Минимальное вещественное число в файле, которое делится на 5 = " + res);
            Console.ReadKey();
        }
    }
}
