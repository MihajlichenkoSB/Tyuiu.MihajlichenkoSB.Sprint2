using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MihajlichenkoSB.Sprint2.Task1.V10.Lib
{
    public class DataService : ISprint2Task1V10
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] results = new bool[6];

            results[0] = (a == b);

            results[1] = (a != c * d);

            results[2] = (b < a) && (c > d);

            results[3] = (a <= b) || (c >= d);

            results[4] = !(a < b) & (d > c);

            results[5] = (a > b) ^ (c < d);

            return results;
        }
    }
}
