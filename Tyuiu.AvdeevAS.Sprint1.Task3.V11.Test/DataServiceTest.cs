using Tyuiu.AvdeevAS.Sprint1.Task3.V11.Lib;
namespace Tyuiu.AvdeevAS.Sprint1.Task3.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.AreEqual(19,ds.TriangleArea(-2,5,1,7,5,-3));
        }
    }
}