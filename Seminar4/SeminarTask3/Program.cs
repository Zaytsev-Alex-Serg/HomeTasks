// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N

int Promt (string message)
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int Result (int num)
{
    int i = 1;
    int k = 1;
    while (num > 0)
    {
        i = i * k;
        k += 1;
        num -= 1;
    }

    return i;
}



int num = Promt("Введите число N: ");
Console.Write (Result(num));