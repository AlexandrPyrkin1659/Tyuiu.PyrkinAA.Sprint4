using Tyuiu.PyrkinAA.Sprint4.Task5.V15.Lib;
namespace Tyuiu.PyrkinAA.Sprint4.Task5.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethodIC()
        {
      
            DataService ds = new DataService();
            int[,] array = new int[,]
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };
            int expected = 45; 

           
            int actual = ds.Calculate(array); 
           
            Assert.AreEqual(expected, actual);
        }
    }
}
