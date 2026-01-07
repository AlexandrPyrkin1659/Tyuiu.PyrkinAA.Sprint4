using Tyuiu.PyrkinAA.Sprint4.Task2.V22.Lib;
namespace Tyuiu.PyrkinAA.Sprint4.Task2.V22
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] array = new int[13];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(1, 7); 
            }

            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Массив: " + string.Join(", ", array));

            int res = ds.Calculate(array);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Произведение нечётных элементов массива = {res}");
            Console.ReadKey();
        }
    }
}