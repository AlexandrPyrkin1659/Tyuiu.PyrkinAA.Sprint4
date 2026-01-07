using Tyuiu.PyrkinAA.Sprint4.Task4.V23.Lib;
namespace Tyuiu.PyrkinAA.Sprint4.Task4.V23
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[,]
            {
                { 8, 7, 5, 8, 7 },
                { 8, 3, 3, 6, 4 },
                { 4, 4, 5, 5, 4 },
                { 3, 4, 7, 7, 3 },
                { 6, 8, 3, 6, 7 }
            };

            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Массив 5x5:");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }

            int res = ds.Calculate(array);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Сумма нечётных элементов массива = {res}");
            Console.ReadKey();
        }
    }
}