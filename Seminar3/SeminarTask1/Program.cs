// [Возвращаемый тип метода] [Имя метода - глагол]([Параметры метода])
// {
//      Код метода
// }

int GetSum(int a, int b)
{
    int sum = a + b;
    return sum;
}


//
int mySum = GetSum(10, 15);
Console.WriteLine(mySum);