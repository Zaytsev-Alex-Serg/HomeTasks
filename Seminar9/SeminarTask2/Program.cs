// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр

int Promt (string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int GetSum (int num)
{
    int tempSum = 0;
    while (num > 0)
    {
        tempSum = tempSum + (num % 10);
        num = num/10;
    }

    return tempSum;
}

int GetRecSum (int num)
{
    if (num == 0) return 0;

    int tempSum = 0;
    tempSum = (num % 10) + GetRecSum(num / 10);
    return tempSum;
}

int num = Promt("Введите число: ");

Console.WriteLine($"Количество цифр в числе: {GetSum(num)}");

Console.WriteLine($"Количество цифр в числе: {GetRecSum(num)}");