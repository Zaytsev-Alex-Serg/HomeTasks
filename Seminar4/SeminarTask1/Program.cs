// Напишите программу, которая на вход принимает число a, и выдаёт сумму чисел от 1 до a

int GetSum (int limit)
{
    int sum = 0 ;
    for (int i = 1; i <= limit; i++)
    {
        sum = sum + i;
    }

    return sum;
}

