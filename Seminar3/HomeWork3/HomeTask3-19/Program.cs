// Напишите программу, которая принимает на вход пятизначное число и
// проеверяет, является ли оно палиндромом

int Promt (string message)
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

/*void CheckNum (int num)
{
    for (int i = 0; i < 5; i++)
    {
        num = num/10;
    }
    if (num != 0)
    {
        Console.Write("Вы ввели не пятизначное число");
    }

}*/

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

/*bool CheckPali (int num, int numRev)
{
    if (num == numRev)
    {
        return true;
    }
    if (num != numRev)
    {
        return false;
    }
}*/

int num = Promt("Введите пятизначное число: ");
//CheckNum(a);
int numRev = Reverse(num);
int numCheck = num;
for (int i = 0; i < 5; i++)
    {
        numCheck = numCheck/10;
    }
    if (numCheck != 0)
    {
        Console.Write("Вы ввели не пятизначное число");
    }
    if (numCheck == 0)
    {
        Reverse(num);
    }
    if (num == numRev)
    {
        Console.Write($"Число {num} палиндром");
    }
    if (num != numRev)
    {
        Console.Write($"Число {num} НЕ палиндром");
    }

