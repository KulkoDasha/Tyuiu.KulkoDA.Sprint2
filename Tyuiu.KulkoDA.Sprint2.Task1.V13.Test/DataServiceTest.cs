using Tyuiu.KulkoDA.Sprint2.Task1.V13.Lib;

namespace Tyuiu.KulkoDA.Sprint2.Task1.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            bool[] res = new bool[6];
            int a = 145;
            int b = 916;
            int c = 164;
            int d = 137;
            res = ds.GetLogicOperations(a, b, c, d);
            bool[] wait = new bool[6] { true, true, true, true, true, false };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}