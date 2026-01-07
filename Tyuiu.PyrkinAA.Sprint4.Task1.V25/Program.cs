using Tyuiu.PyrkinAA.Sprint4.Task1.V25.Lib;
namespace Tyuiu.PyrkinAA.Sprint4.Task1.V25
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int[] numsArray = { 6, 3, 6, 4, 7, 4, 6, 5, 2, 3, 6, 3, 6, 2 };

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Массив: " + string.Join(", ", numsArray));

            int res = ds.Calculate(numsArray);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Сумма чётных элементов массива = {res}");
            Console.ReadKey();
        }
    }
}
