using Tyuiu.MihajlichenkoSB.Sprint2.Task3.V11.Lib;
namespace Tyuiu.MihajlichenkoSB.Sprint2.Task3.V11
{
    class Program
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

            Console.Write("Введите значение x: ");
            if (double.TryParse(Console.ReadLine(), out double x))
            {
                double result = ds.Calculate(x);
                Console.WriteLine($"Результат: y = {result}");
            }

            else
            {
                Console.WriteLine("Ошибка: введите корректное число.");
            }

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");
            


            Console.ReadKey();
        }
    }
}
