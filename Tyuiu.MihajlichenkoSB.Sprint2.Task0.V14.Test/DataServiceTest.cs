using Tyuiu.MihajlichenkoSB.Sprint2.Task0.V14.Lib;
namespace Tyuiu.MihajlichenkoSB.Sprint2.Task0.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidEpression()
        {
            DataService ds = new DataService();
            int x = 1075;
            int y = 754;
            bool[] expected = { true, false, true, false, true, false };

            var result = ds.GetCompareOperations(x, y);

            CollectionAssert.AreEqual(expected, result);
        }
    }
}