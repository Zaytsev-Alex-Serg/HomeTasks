// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи 0 и 1

int Promt (string message)
{
    Console.Write(message);
    int result = int.Parse(Console.ReadLine());
    return result;
}


int num = Promt("Введите количество чисел ряда Фибоначчи: ");
int FiboOne = 0;
int FiboTwo = 1;
Console.Write($"{FiboOne} {FiboTwo}");
for (int i = 0; i + 2 < num; i++)
    {
        int FiboResult = FiboOne + FiboTwo;
        FiboOne = FiboTwo;
        FiboTwo = FiboResult;
        Console.Write($" {FiboResult}");
    }