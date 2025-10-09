using Tyuiu.MihajlichenkoSB.Sprint2.Task0.V14.Lib;
namespace Tyuiu.MihajlichenkoSB.Sprint2.Task0.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 |  Выполнил: Михайличенко С.Б. | ИИПб-25-1";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #1                                                                *");
            Console.WriteLine("* Тема: Работа со строками класса String                                   *");
            Console.WriteLine("* Задание #6                                                               *");
            Console.WriteLine("* Вариант #13                                                              *");
            Console.WriteLine("* Выполнил: Михайличенко Сергей Борисович | ИИП6-25-1                      *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Написать программу: пользователь вводит текст. Проверить,                *");
            Console.WriteLine("* что буквы строки упорядочены по алфавиту.                                *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* x = 1075;                                                                *");
            Console.WriteLine("* y = 754;                                                                 *");
            Console.WriteLine("****************************************************************************");
            int x = 1075;
            int y = 754;
            bool[] results = ds.GetCompareOperations(x, y);

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            Console.WriteLine(string.Join(", ", results));

            Console.ReadKey();
        }
    }
}