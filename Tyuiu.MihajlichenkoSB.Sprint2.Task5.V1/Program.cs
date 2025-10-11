using Tyuiu.MihajlichenkoSB.Sprint2.Task5.V1.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #1 |  Выполнил: Михайличенко С.Б. | ИИПб-25-1";
        Console.WriteLine("****************************************************************************");
        Console.WriteLine("* Спринт #2                                                                *");
        Console.WriteLine("* Тема: Оператор Switch                                                    *");
        Console.WriteLine("* Задание #5                                                               *");
        Console.WriteLine("* Вариант #1                                                               *");
        Console.WriteLine("* Выполнил: Михайличенко Сергей Борисович | ИИП6-25-1                      *");
        Console.WriteLine("****************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                 *");
        Console.WriteLine("* Написать программу, которая использует оператор switch вычисляет         *");
        Console.WriteLine("* требуемое значение и возвращает результат.                               *");
        Console.WriteLine("****************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
        Console.WriteLine("****************************************************************************");

        Console.Write("Введите номер месяца (1–12): ");
        if (int.TryParse(Console.ReadLine(), out int month))


        Console.WriteLine("****************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
        Console.WriteLine("****************************************************************************");

            int days = ds.FindMonthDaysCount(month);
            Console.WriteLine($"В месяце №{month} — {days} дней.");

        Console.ReadKey();
    }
}