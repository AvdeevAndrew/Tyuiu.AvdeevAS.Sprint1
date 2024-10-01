using Tyuiu.AvdeevAS.Sprint1.Task2.V10.Lib;
namespace Tyuiu.AvdeevAS.Sprint1.Task2.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedValid()
        {
            DataService ds = new DataService();

            Assert.AreEqual(39.370, ds.Calculate(1,1));
        }
    }
}