using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MihajlichenkoSB.Sprint2.Task7.V1.Lib
{
    public class DataService : ISprint2Task7V1
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            double sinX = Math.Sin(x);
            return y >= 0.5 && y <= sinX && sinX >= 0.5;
        }
    }
}
