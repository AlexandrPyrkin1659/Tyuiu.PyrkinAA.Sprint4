using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.PyrkinAA.Sprint6.Task6.V12.Lib
{
    public class DataService : ISprint4Task6V12
    {
        public string[] Calculate(string[] array)
        {
       
            string[] mas = Array.FindAll(array, x => x != null && x.Length == 7);

            return mas;
        }
    }
}