using Tyuiu.MihajlichenkoSB.Sprint2.Task1.V10.Lib;
namespace Tyuiu.MihajlichenkoSB.Sprint2.Task1.V10
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 |  Выполнил: Михайличенко С.Б. | ИИПб-25-1";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #2                                                                *");
            Console.WriteLine("* Тема: Логические операции                                                *");
            Console.WriteLine("* Задание #1                                                               *");
            Console.WriteLine("* Вариант #10                                                              *");
            Console.WriteLine("* Выполнил: Михайличенко Сергей Борисович | ИИП6-25-1                      *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=,          *");
            Console.WriteLine("* последовательность можно чередовать, но использовать один раз в          *");
            Console.WriteLine("* выражении) и логических операций (|, &, ||, &&, !, ^, последовательность *");
            Console.WriteLine("* операций не должна нарушаться), а также арифметических выражений,        *");
            Console.WriteLine("* которая вернет логическую последовательность(массив): (True, False,      *");
            Console.WriteLine("* False, False, True, False), при a = 455, b = 335, c = 14, d = 17         *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* x = 1075;                                                                *");
            Console.WriteLine("* y = 754;                                                                 *");
            Console.WriteLine("****************************************************************************");
           
            int a = 455, b = 335, c = 14, d = 17;

            bool[] results = ds.GetLogicOperations(a, b, c, d);

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            Console.WriteLine(string.Join(", ", results));

            Console.ReadKey();
        }
    }
}
