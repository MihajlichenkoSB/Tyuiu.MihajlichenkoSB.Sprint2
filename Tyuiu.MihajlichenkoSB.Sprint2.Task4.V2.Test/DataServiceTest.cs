using Tyuiu.MihajlichenkoSB.Sprint2.Task4.V2.Lib;
namespace Tyuiu.MihajlichenkoSB.Sprint2.Task4.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {

            DataService ds = new DataService();

            double result = ds.Calculate(10, 2);
            double expected = 10 + (10 + 1) / 2.0;
            Assert.AreEqual(System.Math.Round(expected, 3), result);

            double res = ds.Calculate(4, 3);
            double exp = (3 + 5) / (3 + 2.0);
            Assert.AreEqual(System.Math.Round(expected, 3), result);
        }
    }
}
