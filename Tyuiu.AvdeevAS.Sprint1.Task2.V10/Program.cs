using Tyuiu.AvdeevAS.Sprint1.Task2.V10.Lib;
namespace Tyuiu.AvdeevAS.Sprint1.Task2.V10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Авдеев А.С. | ИБКСБ-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                  Спринт #1                              *");
            Console.WriteLine("* Тема: <Арифметические операции С#>                                      *");
            Console.WriteLine("*                              Задание #2                                 *");
            Console.WriteLine("*                              Вариант #10                                *");
            Console.WriteLine("* Выполнил: Авдеев Андрей Сергеевич    | ИБКСБ-24-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                  УСЛОВИЕ:                               *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                               ИСХОДНЫЕ ДАННЫЕ:                          *");
            Console.WriteLine("***************************************************************************");




            Console.WriteLine("Введите метры: ");
            int x = Convert.ToInt32(Console.ReadLine());

            


            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("РЕЗУЛЬТАТ:                                                                *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("inch = " + ds.ConvertMetreToInchs(x));


            Console.ReadKey();
        }
    }
}
