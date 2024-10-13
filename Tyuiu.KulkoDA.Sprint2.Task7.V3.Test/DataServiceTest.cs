using Tyuiu.KulkoDA.Sprint2.Task7.V3.Lib;
namespace Tyuiu.KulkoDA.Sprint2.Task7.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 0.8;
            double y = 1.0;
            var res = ds.CheckDotInShadedArea(x, y);
            Assert.AreEqual(true, res); 
        }
    }
}