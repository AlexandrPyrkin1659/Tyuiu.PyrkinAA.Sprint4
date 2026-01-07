using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.PyrkinAA.Sprint4.Task1.V25.Lib
{
    public class DataService : ISprint4Task1V25
    {
        public int Calculate(int[] array)
        {
            int sumEven = 0;

            foreach (int num in array)
            {
                if (num % 2 == 0) 
                {
                    sumEven += num;
                }
            }

            return sumEven;
        }
    }
}

