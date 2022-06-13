/* Напишите программу, которая
принимает на вход координаты двух точек и
находит расстояние между ними в 2D
пространстве.
 */

 Console.WriteLine("введите координату X1");
 int X1 = int.Parse(Console.ReadLine());

 Console.WriteLine("введите координату Y1");
 int Y1 = int.Parse(Console.ReadLine());

  Console.WriteLine("введите координату X2");
 int X2 = int.Parse(Console.ReadLine());

 Console.WriteLine("введите координату Y2");
 int Y2 = int.Parse(Console.ReadLine());

double result = Math.Sqrt (Math.Pow (X1 -X2,2) + Math.Pow (Y1 - Y2,2));

Console.WriteLine(result);

