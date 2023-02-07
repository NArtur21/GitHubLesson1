// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();

Console.WriteLine("Введите координаты точки a1: ");
int a1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координаты точки b1: ");
int b1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координаты точки c1: ");
int c1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координаты точки a2: ");
int a2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координаты точки b2: ");
int b2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координаты точки c2: ");
int c2 = int.Parse(Console.ReadLine()!);

double Distans = Math.Sqrt(Math.Pow(a1 - a2, 2) + Math.Pow(b1 - b2, 2) + Math.Pow(c1 - c2, 2));
Console.WriteLine($"Расстояние между точками A и B: {Distans:f2}");
