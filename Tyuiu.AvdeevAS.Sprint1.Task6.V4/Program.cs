using Tyuiu.AvdeevAS.Sprint1.Task6.V4.Lib;
namespace Tyuiu.AvdeevAS.Sprint1.Task6.V4
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
            Console.WriteLine("*                              Задание #6                                 *");
            Console.WriteLine("*                              Вариант #4                                 *");
            Console.WriteLine("* Выполнил: Авдеев Андрей Сергеевич    | ИБКСБ-24-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                  УСЛОВИЕ:                               *");
            Console.WriteLine("* Написать программу, которая отвечает всем требованиям задания.          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                               ИСХОДНЫЕ ДАННЫЕ:                          *");
            Console.WriteLine("***************************************************************************");






            Console.Write("Введите строку: ");

            
            
            string x = Console.ReadLine();
            
           





            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("РЕЗУЛЬТАТ:                                                                *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Слова содержащие 'нн': " + ds.CheckDoubleN(x));


            Console.ReadKey();
        }
    }
}
