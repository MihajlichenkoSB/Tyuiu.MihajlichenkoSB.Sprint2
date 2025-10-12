using Tyuiu.MihajlichenkoSB.Sprint2.Task6.V1.Lib;

namespace Tyuiu.MihajlichenkoSB.Sprint2.Task6.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Создаём экземпляр класса, который тестируем
            DataService ds = new DataService();

            Assert.AreEqual(31, ds.FindMonthDaysCount(1));
            Assert.AreEqual(31, ds.FindMonthDaysCount(12));
        }
    }
}