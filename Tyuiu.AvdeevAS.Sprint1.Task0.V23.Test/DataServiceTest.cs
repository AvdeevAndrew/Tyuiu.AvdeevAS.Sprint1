using Tyuiu.AvdeevAS.Sprint1.Task0.V23.Lib;
namespace Tyuiu.AvdeevAS.Sprint1.Task0.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedValid()
        {
            Assert.AreEqual(13, DataService.Exercise(15, 5, 4, 1));
        }
    }
}