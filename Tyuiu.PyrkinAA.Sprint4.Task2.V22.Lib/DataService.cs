using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.PyrkinAA.Sprint4.Task2.V22.Lib
{
    public class DataService : ISprint4Task2V22
    {
        public int Calculate(int[] array)
        {
            int product = 1;
            bool hasOdd = false;

            foreach (int num in array)
            {
                if (num % 2 != 0) 
                {
                    product *= num;
                    hasOdd = true;
                }
            }
            return hasOdd ? product : 0;
        }
    }
}
