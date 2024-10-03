using Tyuiu.AvdeevAS.Sprint1.Task7.V25.Lib;
namespace Tyuiu.AvdeevAS.Sprint1.Task7.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds  = new DataService();
            Assert.AreEqual(-6, 017, ds.Calculate(2, 2));
        }
    }
}