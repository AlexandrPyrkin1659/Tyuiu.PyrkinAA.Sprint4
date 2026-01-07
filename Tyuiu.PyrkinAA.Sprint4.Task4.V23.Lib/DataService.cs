using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.PyrkinAA.Sprint4.Task4.V23.Lib
{
    public class DataService : ISprint4Task4V23
    {
        public int Calculate(int[,] array)
        {
            int sumOdd = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] % 2 != 0)
                    {
                        sumOdd += array[i, j];
                    }
                }
            }

            return sumOdd;
        }
    }
}
