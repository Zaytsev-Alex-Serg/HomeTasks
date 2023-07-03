//  Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве

int Promt (string message)
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

void GetDistance (int x1, int y1, int z1, int x2, int y2, int z2)
{
    double result = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));

    Console.Write($"Расстояние между точками равняется: {result}");
}






int x1 = Promt("Введите координату x1 для первой точки: ");
int y1 = Promt("Введите координату y1 для первой точки: ");
int z1 = Promt("Введите координату z1 для второй точки: ");
int x2 = Promt("Введите координату x2 для второй точки: ");
int y2 = Promt("Введите координату y2 для второй точки: ");
int z2 = Promt("Введите координату z2 для второй точки: ");
GetDistance(x1, y1, z1, x2, y2, z2);