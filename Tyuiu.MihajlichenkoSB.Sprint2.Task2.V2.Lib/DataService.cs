using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MihajlichenkoSB.Sprint2.Task2.V2.Lib
{
    public class DataService : ISprint2Task2V2
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            (int X, int Y)[] shadedCells =
            {
                (3,3),(9,3),(12,3),
                (3,4),(4,4),(5,4),(6,4),(7,4),(8,4),(9,4),(10,4),(11,4),(12,4),
                (4,5),(5,5),(6,5),(7,5),(8,5),(9,5),(10,5),(11,5),(12,5),
                (7,6),(8,6),(9,6),
                (7,7),(8,7),(9,7),(10,7),
                (9,8),
                (9,9),(10,9),(11,9),
                (2,10),(3,10),(4,10),(9,10),(10,10),(11,10),
                (2,11),(3,11),(4,11),(5,11),
                (2,12),(3,12),(4,12),(5,12)
            };

            foreach (var cell in shadedCells)
            {
                if (cell.X == x && cell.Y == y)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
