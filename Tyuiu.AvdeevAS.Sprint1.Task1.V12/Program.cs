using Tyuiu.AvdeevAS.Sprint1.Task1.V12.Lib;
namespace Tyuiu.AvdeevAS.Sprint1.Task1.V12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Авдеев А.С. | ИБКСБ-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                  Спринт #1                              *");
            Console.WriteLine("* Тема: <Базовые навыки работы С#>                                        *");
            Console.WriteLine("*                              Задание #1                                 *");
            Console.WriteLine("*                              Вариант #12                                *");
            Console.WriteLine("* Выполнил: Авдеев Андрей Сергеевич    | ИБКСБ-24-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                  УСЛОВИЕ:                               *");
            Console.WriteLine("*Написать программу, которая запрашивает у пользователя исходные данные,  *");
            Console.WriteLine("* вычисляет результат по формуле (x+y)/6 и печатает его на экране.        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                               ИСХОДНЫЕ ДАННЫЕ:                          *");
            Console.WriteLine("***************************************************************************");

            
            

            Console.WriteLine("Введите a: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите b: ");
            double y = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("РЕЗУЛЬТАТ:                                                                *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("z = " + ds.Calculate(x,y));


            Console.ReadKey();
        }
    }
}
