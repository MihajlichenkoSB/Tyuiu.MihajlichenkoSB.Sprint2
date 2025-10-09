using Tyuiu.MihajlichenkoSB.Sprint2.Task2.V2.Lib;
namespace Tyuiu.MihajlichenkoSB.Sprint2.Task2.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.IsTrue(ds.CheckDotInShadedArea(9, 4));
            Assert.IsTrue(ds.CheckDotInShadedArea(3, 3));

            Assert.IsFalse(ds.CheckDotInShadedArea(1, 1));
            Assert.IsFalse(ds.CheckDotInShadedArea(15, 15));
        }
    }
}
