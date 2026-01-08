using Tyuiu.PyrkinAA.Sprint4.Task6.V12.Lib;
namespace Tyuiu.PyrkinAA.Sprint4.Task6.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethodIOC()
        {
            DataService ds = new DataService();


            var countries = new string[] { "Россия", "Украина", "Беларусь", "Казахстан", "Молдова", "Латвия", "Эстония" };


            string[] res = ds.Calculate(countries);

            int actualLength = res.Length;


            int wait = 3;

            Assert.AreEqual(wait, actualLength);
        }
    }
}