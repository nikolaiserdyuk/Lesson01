// Напишите метод, который принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.WriteLine("Введите координату точки 1 по оси х: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату точки 1 по оси y: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату точки 1 по оси z: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату точки 2 по оси х: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату точки 2 по оси y: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату точки 2 по оси z: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double CoordinateLenghtAB(int coordx1, int coordy1, int coordz1, int coordx2, int coordy2, int coordz2)
{
    int x = coordx2 - coordx1;
    int y = coordy2 - coordy1;
    int z = coordz2 - coordz1;
    return Math.Sqrt(x * x + y * y + z * z);
}
double lengthAB = CoordinateLenghtAB(x1, y1, z1, x2, y2, z2);
lengthAB = Math.Round(lengthAB, 2, MidpointRounding.ToZero);
Console.WriteLine($"A ({x1}, {y1}, {z1}), B ({x2}, {y2}, {z2}) -> {lengthAB}");