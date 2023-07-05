int Promt (string message)
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int sumNum (int a)
{
    int num = 0;
    int k = 0;
    while (a > 0)
    {
        num = a % 10;
        k += num;
        a = a / 10;       
    }
    return k;
}


int num = Promt("Введите число: ");
Console.WriteLine(sumNum(num));