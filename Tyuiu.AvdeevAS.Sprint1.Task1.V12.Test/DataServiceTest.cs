using Tyuiu.AvdeevAS.Sprint1.Task1.V12.Lib;
namespace Tyuiu.AvdeevAS.Sprint1.Task1.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedValid()
        {
            DataService ds = new DataService();

            Assert.AreEqual(1, ds.Calculate(5 , 1));
        }
    }
}