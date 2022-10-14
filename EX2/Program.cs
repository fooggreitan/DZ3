// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Ведите число xa:");
int XA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ведите число ya:");
int YA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ведите число za:");
int ZA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ведите число xb:");
int XB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ведите число yb:");
int YB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ведите число zb:");
int ZB = Convert.ToInt32(Console.ReadLine());

double D = Math.Sqrt(Math.Pow((XB-XA), 2) + Math.Pow((YB-YA), 2) + Math.Pow((ZB-ZA), 2));

double d = Math.Round(D,2);

Console.WriteLine($"Расстояние между двумя точками: {d}");