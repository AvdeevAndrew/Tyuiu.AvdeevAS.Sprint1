
using Tyuiu.AvdeevAS.Sprint1.Task0.V23.Lib;
namespace Tyuiu.AvdeevAS.Sprint1.Task0.V23
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
            Console.WriteLine("*                              Задание #0                                 *");
            Console.WriteLine("*                              Вариант #23                                *");
            Console.WriteLine("* Выполнил: Авдеев Андрей Сергеевич    | ИБКСБ-24-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                  УСЛОВИЕ:                               *");
            Console.WriteLine("*      Написать программу, которая вычисляет выражение (15/5*4)+1         *");
            Console.WriteLine("*                    и печатает результат на экране.                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                               ИСХОДНЫЕ ДАННЫЕ:                          *");
            Console.WriteLine("***************************************************************************");

            int a = 15;
            int b = 5;
            int c = 4;
            int d = 1;

            Console.WriteLine("a = " + a); 
            Console.WriteLine("b = " + b);
            Console.WriteLine("c = " + c);
            Console.WriteLine("d = " + d);
            Console.WriteLine("x = (a/b*c)+d");


            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("РЕЗУЛЬТАТ:                                                                *");
            Console.WriteLine("***************************************************************************");
            
            Console.WriteLine("x = " + ds.Calculate());

            Console.ReadKey();


        }


    }
}
