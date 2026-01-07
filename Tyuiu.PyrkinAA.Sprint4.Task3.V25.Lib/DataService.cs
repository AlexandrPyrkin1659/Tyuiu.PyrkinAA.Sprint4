using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.PyrkinAA.Sprint4.Task3.V25.Lib
{
    public class DataService : ISprint4Task3V25
    {
        public int Calculate(int[,] array)
        {
            int columnIndex = 3; 
            int product = 1;
            for (int row = 0; row < array.GetLength(0); row++)
            {
                product *= array[row, columnIndex];
            }

            return product;
        }
    }
}
