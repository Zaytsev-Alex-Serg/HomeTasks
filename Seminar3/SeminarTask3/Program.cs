// Напишите программу, которая по номеру четверти будет передавать диапазон 
// возможных координат в этой четверти

void GetCoordinate (int i)
{
    switch (i) 
    {
        case 1:
            Console.WriteLine("[x > 0, y > 0]");
            break;

        case 2:
            Console.WriteLine("[x < 0, y > 0]");
            break;
        
        case 3:
            Console.WriteLine("[x < 0, y < 0]");
            break;
        case 4:
            Console.WriteLine("[x > 0, y < 0]");
            break;
    }
}

// ------------------------------------------

Console.Write("Введите номер четверти: ");
int i = int.Parse(Console.ReadLine());

if (i == 0)
{
    Console.WriteLine("Нулевой четверти не существует");
}

GetCoordinate(i);
