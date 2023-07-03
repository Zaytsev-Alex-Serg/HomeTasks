int Promt (string message)
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int num1 = Promt("Введите число 1: ");
int num2 = Promt("Введите число 2: ");

int k = num1;
for (int i = 1; i < num2; i++)
    {
        num1 = k * num1;
    }

Console.WriteLine(num1);