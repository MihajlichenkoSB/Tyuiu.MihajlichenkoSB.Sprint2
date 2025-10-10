using Tyuiu.MihajlichenkoSB.Sprint2.Task3.V11.Lib;
namespace Tyuiu.MihajlichenkoSB.Sprint2.Task3.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestCalculateFunction()
        {
            // Arrange
            DataService ds = new DataService();

            // Act & Assert
            double result1 = ds.Calculate(1);
            Assert.AreEqual(Math.Round(1 + Math.Pow((1 - 15) / (1 - 19), 1), 3), result1);

            double result2 = ds.Calculate(0);
            Assert.AreEqual(Math.Round((0 - Math.Cos(0) + 10) / (0 - Math.Sin(0) + 12), 3), result2);

            double result3 = ds.Calculate(-1);
            Assert.AreEqual(Math.Round(Math.Pow(1 + 1 / Math.Pow(-1, 2), -1), 3), result3);

            double result4 = ds.Calculate(-20);
            Assert.AreEqual(Math.Round(-20 + 10 * (-20) - (1.0 / -20), 3), result4);
        }
    }
}