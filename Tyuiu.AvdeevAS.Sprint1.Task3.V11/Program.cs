using Tyuiu.AvdeevAS.Sprint1.Task3.V11.Lib;
DataService ds = new DataService();

Console.Title = "Спринт #1 | Выполнил: Авдеев А.С. | ИБКСБ-24-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("*                                  Спринт #1                              *");
Console.WriteLine("* Тема: <Арифметические операции С#>                                      *");
Console.WriteLine("*                              Задание #3                                 *");
Console.WriteLine("*                              Вариант #11                                *");
Console.WriteLine("* Выполнил: Авдеев Андрей Сергеевич    | ИБКСБ-24-1                       *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("*                                  УСЛОВИЕ:                               *");
Console.WriteLine("* Написать программу, которая отвечает всем требованиям задания.          *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("*                               ИСХОДНЫЕ ДАННЫЕ:                          *");
Console.WriteLine("***************************************************************************");




Console.WriteLine("Введите координаты углов: ");

Console.Write("Введите координаты первой вершины (x1, y1): ");

double x1 = Convert.ToDouble(Console.ReadLine());
double y1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координаты второй вершины (x2, y2): ");

double x2 = Convert.ToDouble(Console.ReadLine());
double y2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координаты третьей вершины (x3, y3): ");

double x3 = Convert.ToDouble(Console.ReadLine());
double y3 = Convert.ToDouble(Console.ReadLine());




Console.WriteLine();
Console.WriteLine("***************************************************************************");
Console.WriteLine("РЕЗУЛЬТАТ:                                                                *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Площадь треугольников: " + ds.TriangleArea(x1, y1, x2, y2, x3, y3));


Console.ReadKey();
