using Tyuiu.MihajlichenkoSB.Sprint2.Task1.V10.Lib;
namespace Tyuiu.MihajlichenkoSB.Sprint2.Task1.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpress()
        {
            DataService ds = new DataService();
            int a = 455, b = 335, c = 14, d = 17;
            bool[] expected = { true, false, false, false, true, false };

            bool[] actual = ds.GetLogicOperations(a, b, c, d);

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
