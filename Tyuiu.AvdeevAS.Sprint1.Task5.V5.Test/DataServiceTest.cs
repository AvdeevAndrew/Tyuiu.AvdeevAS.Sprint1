using Tyuiu.AvdeevAS.Sprint1.Task5.V5.Lib;
namespace Tyuiu.AvdeevAS.Sprint1.Task5.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.AreEqual(8, ds.Calculate(32.897));
        }
    }
}