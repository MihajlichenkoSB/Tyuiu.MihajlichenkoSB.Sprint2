using Tyuiu.MihajlichenkoSB.Sprint2.Task7.V1.Lib;
namespace Tyuiu.MihajlichenkoSB.Sprint2.Task7.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.IsTrue(ds.CheckDotInShadedArea(Math.PI / 4, 0.6)); // sin(π/4)=0.707
        }
    }
}
