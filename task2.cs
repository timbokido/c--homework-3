// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.WriteLine("координаты первой точки:");
int x1 = Convert.ToInt16(Console.ReadLine());
int y1 = Convert.ToInt16(Console.ReadLine());
int z1 = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("координаты второй точки:");
int x2 = Convert.ToInt16(Console.ReadLine());
int y2 = Convert.ToInt16(Console.ReadLine());
int z2 = Convert.ToInt16(Console.ReadLine());

double distance = Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2) + Math.Pow(z2-z1, 2));
Console.WriteLine(distance);