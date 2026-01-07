using Tyuiu.PyrkinAA.Sprint4.Task2.V22.Lib;
namespace Tyuiu.PyrkinAA.Sprint4.Task2.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] array = { 1, 2, 3, 4, 5, 6, 1, 2, 3, 4, 5, 6, 1 }; 
            int res = ds.Calculate(array);
            int wait = 225;

            Assert.AreEqual(wait, res);
        }
    }
}
