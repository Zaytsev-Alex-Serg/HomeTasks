// Напишите программу, которая на вход принимает 2 числа A и B, и возводит число A в целую степень B с помощью рекурсии

int Promt (string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int DegreeNum (int num1, int num2)
{
    int result = 1;
    for(int i = 0; i < num2; i++)
    {
        result = result * num1;
    }

    return result;
}

int DegreeRecNum (int num1, int num2)
{
    if (num2 == 0) return 1;

    int tempResult = 0;
    tempResult = num1 * DegreeRecNum(num1, num2 - 1);
    return tempResult;
}


int num1 = Promt("Введите первое число: ");

int num2 = Promt("Введите второе число: ");

Console.WriteLine($"Число {num1} в степени {num2} равно: {DegreeNum(num1, num2)}");

Console.WriteLine($"Число {num1} в степени {num2} равно: {DegreeRecNum(num1, num2)}");
