using Tyuiu.AvdeevAS.Sprint1.Task4.V8.Lib;
namespace Tyuiu.AvdeevAS.Sprint1.Task4.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.AreEqual(0.490, ds.Calculate(2,2));
        }
    }
}
