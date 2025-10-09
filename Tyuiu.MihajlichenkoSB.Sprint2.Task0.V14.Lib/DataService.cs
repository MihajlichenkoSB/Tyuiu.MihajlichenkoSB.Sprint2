using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.MihajlichenkoSB.Sprint2.Task0.V14.Lib
{
    public class DataService : ISprint2Task0V14
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            return new bool[]
            {
                1075 > 754,   // True
                1075 == 754,  // False
                1075 != 754,  // True
                1075 <= 754,  // False
                1075 >= 754,  // True
                1075 < 754    // False
            };
        }
    }
}