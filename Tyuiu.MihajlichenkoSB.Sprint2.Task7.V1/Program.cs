using Tyuiu.MihajlichenkoSB.Sprint2.Task7.V1.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #1 |  Выполнил: Михайличенко С.Б. | ИИПб-25-1";
        Console.WriteLine("****************************************************************************");
        Console.WriteLine("* Спринт #1                                                                *");
        Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                  *");
        Console.WriteLine("* Задание #7                                                               *");
        Console.WriteLine("* Вариант #1                                                               *");
        Console.WriteLine("* Выполнил: Михайличенко Сергей Борисович | ИИП6-25-1                      *");
        Console.WriteLine("****************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                 *");
        Console.WriteLine("* Написать программу на C#, которая запрашивает исходные данные            *");
        Console.WriteLine("* (вещественные значения) и вычисляет, находится ли точка с координатами   *");
        Console.WriteLine("* X, Y в заштрихованной области.                                           *");
        Console.WriteLine("****************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
        Console.WriteLine("****************************************************************************");

        Console.WriteLine("Введите координаты точки:");
        Console.Write("X = ");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.Write("Y = ");
        double y = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("****************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
        Console.WriteLine("****************************************************************************");

        bool result = ds.CheckDotInShadedArea(x, y);

        if (result)
            Console.WriteLine("Точка находится в заштрихованной области.");
        else
            Console.WriteLine("Точка находится вне заштрихованной области.");

        Console.ReadKey();
    }
}
