// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
Console.WriteLine("Введите координаты точки А: ");
int[] pointA = new int[3];
pointA[0] = Convert.ToInt32(Console.ReadLine());
pointA[1] = Convert.ToInt32(Console.ReadLine());
pointA[2] = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B: ");
int[] pointB = new int[3];
pointB[0] = Convert.ToInt32(Console.ReadLine());
pointB[1] = Convert.ToInt32(Console.ReadLine());
pointB[2] = Convert.ToInt32(Console.ReadLine());

double distance = Math.Sqrt(Math.Pow(pointB[0] - pointA[0], 2) + Math.Pow(pointB[1] - pointA[1], 2) + Math.Pow(pointB[2] - pointA[2], 2));
System.Console.WriteLine(distance);