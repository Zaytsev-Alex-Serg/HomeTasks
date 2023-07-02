// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 2D пространстве

double GetDistance (int x1, int y1, int x2, int y2)
{
    double result = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));

    return result;
}

// ----------------------------------------------

Console.Write ("Введите x координату точки 1: ");
int x1 = int.Parse(Console.ReadLine());

Console.Write ("Введите y координату точки 1: ");
int y1 = int.Parse(Console.ReadLine());

Console.Write ("Введите x координату точки 2: ");
int x2 = int.Parse(Console.ReadLine());

Console.Write ("Введите y координату точки 2: ");
int y2 = int.Parse(Console.ReadLine());

Console.WriteLine ($"Расстояние между точками равно: {GetDistance(x1, y1, x2, y2)}");