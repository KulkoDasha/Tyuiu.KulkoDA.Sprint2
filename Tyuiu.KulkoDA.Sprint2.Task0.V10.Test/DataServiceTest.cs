using Tyuiu.KulkoDA.Sprint2.Task0.V10.Lib;

namespace Tyuiu.KulkoDA.Sprint2.Task0.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 1305;
            int y = 475;
            bool [] res = new bool [6];
            res = ds.GetCompareOperations(x,y);
            bool[] wait = { false, true, false, true, false, true };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}