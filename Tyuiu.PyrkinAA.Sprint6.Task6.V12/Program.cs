using Tyuiu.PyrkinAA.Sprint6.Task6.V12.Lib;
namespace Tyuiu.PyrkinAA.Sprint6.Task6.V12
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            string[] inputArray = { "Россия", "Украина", "Беларусь", "Казахстан" };
            string[] result = ds.Calculate(inputArray);

            Console.WriteLine("Результат:");
            if (result.Length == 0)
            {
                Console.WriteLine("Нет элементов длиной 7 символов.");
            }
            else
            {
                foreach (string item in result)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}