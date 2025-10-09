using Tyuiu.MihajlichenkoSB.Sprint2.Task2.V2.Lib;
namespace Tyuiu.MihajlichenkoSB.Sprint2.Task2.V2
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 |  Выполнил: Михайличенко С.Б. | ИИПб-25-1";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #2                                                                *");
            Console.WriteLine("* Тема: Оператор if - полная и короткая форма записи                                                *");
            Console.WriteLine("* Задание #2                                                               *");
            Console.WriteLine("* Вариант #2                                                               *");
            Console.WriteLine("* Выполнил: Михайличенко Сергей Борисович | ИИП6-25-1                      *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Написать программу на, которая запрашивает целые значения с клавиатуры   *");
            Console.WriteLine("* и вычисляет находится ли точка с координатами X,Y в                      *");
            Console.WriteLine("* заштрихованной области.                                                  *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");

            Console.WriteLine("Введите координаты точки (X, Y) от 1 до 15:");

            Console.Write("X = ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Y = ");
            int y = int.Parse(Console.ReadLine());

            bool inside = ds.CheckDotInShadedArea(x, y);

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            if (inside)
                Console.WriteLine("Точка находится в заштрихованной области.");
            else
                Console.WriteLine("Точка находится вне заштрихованной области.");

            Console.ReadKey();
        }
    }
}
