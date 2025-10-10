using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MihajlichenkoSB.Sprint2.Task3.V11.Lib
{
    public class DataService : ISprint2Task3V11
    {
        public double Calculate(double x)
        {
            double y;

            if (x > 0)
            {
                y = x + Math.Pow((x - 15) / (x - 19), x);
            }
            else if (x == 0)
            {
                y = (Math.Pow(x, 2) - Math.Cos(Math.Pow(x, 2)) + 10) /
                    (Math.Pow(x, 2) - Math.Sin(Math.Pow(x, 2)) + 12);
            }
            else if (x > -15 && x < 0)
            {
                y = Math.Pow(1 + 1 / Math.Pow(x, 2), x);
            }
            else // x < -15
            {
                y = x + 10 * x - (1 / x);
            }

            return Math.Round(y, 3);
        }
    }
}
