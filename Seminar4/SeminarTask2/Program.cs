// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе

int Promt (string message)
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int Counter (int num)
{
    int i = 0;
    while (num > 0)
    {
        num = num/10;
        i += 1;
    }

    return i;
}

int num = Promt("Введите число: ");
Console.WriteLine(Counter(num));