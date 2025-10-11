using Tyuiu.MihajlichenkoSB.Sprint2.Task5.V1.Lib;
namespace Tyuiu.MihajlichenkoSB.Sprint2.Task5.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int result = ds.FindMonthDaysCount(1);
            Assert.AreEqual(31, result);

            ds.FindMonthDaysCount(13);
        }
    }
}
