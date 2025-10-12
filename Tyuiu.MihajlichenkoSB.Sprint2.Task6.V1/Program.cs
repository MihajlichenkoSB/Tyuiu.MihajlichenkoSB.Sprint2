using Tyuiu.MihajlichenkoSB.Sprint2.Task6.V1.Lib;
namespace Tyuiu.MihajlichenkoSB.Sprint2.Task6.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 |  Выполнил: Михайличенко С.Б. | ИИПб-25-1";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #1                                                                *");
            Console.WriteLine("* Тема: Получение результата из Switch                                     *");
            Console.WriteLine("* Задание #6                                                               *");
            Console.WriteLine("* Вариант #1                                                               *");
            Console.WriteLine("* Выполнил: Михайличенко Сергей Борисович | ИИП6-25-1                      *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Написать программу, которая использует сокращенную форму записи          *");
            Console.WriteLine("* оператора switch вычисляет требуемое значение и возвращает результат.    *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* x = 1075;                                                                *");
            Console.WriteLine("* y = 754;                                                                 *");
            Console.WriteLine("****************************************************************************");

            Console.Write("Введите номер месяца (1–12): ");
            if (int.TryParse(Console.ReadLine(), out int month))
  

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");

            try
            {
                int days = ds.FindMonthDaysCount(month);
                Console.WriteLine($"Количество дней: {days}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}