using Tyuiu.PyrkinAA.Sprint4.Task5.V15.Lib;
namespace Tyuiu.PyrkinAA.Sprint4.Task5.V15
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int[,] matrix = new int[,]
            {
                { 1, -2, 3 },
                { -4, 5, -6 },
                { 7, -8, 9 }
            };

            int result = ds.Calculate(matrix);
            Console.WriteLine("Результат: " + result);
        }
    }
}