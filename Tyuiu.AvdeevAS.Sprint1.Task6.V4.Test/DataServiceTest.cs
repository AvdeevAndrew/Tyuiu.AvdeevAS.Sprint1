using Tyuiu.AvdeevAS.Sprint1.Task6.V4.Lib;
namespace Tyuiu.AvdeevAS.Sprint1.Task6.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.AreEqual("�������� ����������", ds.CheckDoubleN("�������, �������� ������ ������� �������� ����������"));
        }
    }
}