using Tyuiu.MihajlichenkoSB.Sprint2.Task4.V2.Lib;
internal class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #1 |  Выполнил: Михайличенко С.Б. | ИИПб-25-1";
        Console.WriteLine("****************************************************************************");
        Console.WriteLine("* Спринт #2                                                                *");
        Console.WriteLine("* Тема: Оператор if - полная и короткая форма записи                       *");
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

        Console.WriteLine("Введите значение x:");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите значение y:");
        double y = Convert.ToDouble(Console.ReadLine());

        double result = ds.Calculate(x, y);

        Console.WriteLine("****************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
        Console.WriteLine("****************************************************************************");

        Console.WriteLine(" z = {result}");

        Console.ReadKey();
    }
}