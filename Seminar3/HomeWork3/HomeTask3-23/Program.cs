// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

int Promt (string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

void GetSquare (int a)
{
    for (int i = 1; i <= a; i++)
        Console.Write($" {i * i * i}");
}

// -----------------------------------

int a = Promt("Введите число N: ");
GetSquare(a);