// Напишите программу, которая принимает на вхо координаты x и y (они не равны нулю),
// и показывает в какой четверти находится точка с этими координатами

int GetAreNummber (int x, int y)
{
    int numberArea = 0;

    if (x > 0 && y > 0)
    {
        numberArea = 1;
    }

     if (x < 0 && y > 0)
    {
        numberArea = 2;
    }

     if (x < 0 && y < 0)
    {
        numberArea = 3;
    }

     if (x > 0 && y < 0)
    {
        numberArea = 4;
    }

    return numberArea;
}

// ---------------------------------------------------------

Console.Write("Введите координату x: ");
int x = int.Parse(Console.ReadLine());

Console.Write("Введите координату y: ");
int y = int.Parse(Console.ReadLine());

if (x == 0 || y == 0)
{
    Console.WriteLine("Координаты не должны быть равны нулю");
}

int result = GetAreaNummber(x, y);
Console.WriteLine($"Номер четверти: {result}");
