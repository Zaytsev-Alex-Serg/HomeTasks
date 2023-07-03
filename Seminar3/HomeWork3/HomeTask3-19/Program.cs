// Напишите программу, которая принимает на вход пятизначное число и
// проеверяет, является ли оно палиндромом

int Promt (string message)
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

void CheckNum (int num)
{
        num = num/100000;
    
    if (num != 0)
    {
        Console.Write("Вы ввели не пятизначное число");
        System.Environment.Exit(int.Parse(Console.ReadLine()));
    }
}

int Reverse (int a)
{
    int pali = 0;
    int k = 0;
    for (int i = 0; i < 5; i++)
    {
        k = k * 10;
        pali = a % 10;
        k += pali;
        a = a / 10;       
    }

    return k;
}

void CheckPali (int num, int numRev)
{
    if (num == numRev)
    {
        Console.Write($"Число {num} палиндром");
    }
    if (num != numRev)
    {
        Console.Write($"Число {num} НЕ палиндром");
    }
}

int num = Promt("Введите пятизначное число: ");
if (num < 0)
{
    Console.Write("Отрицательное число не может быть палиндромом");
    System.Environment.Exit(int.Parse(Console.ReadLine()));

}
CheckNum(num);
int numRev = Reverse(num);
CheckPali(num, numRev);

