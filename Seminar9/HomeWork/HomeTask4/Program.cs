// Даны два положительных целых числа, представленных в виде строк. 
// Необходимо получить сумму чисел, которые представлены этими строками. Причем полученная сумма должна быть преобразована в строку.
// Для решения этой задачи запрещено преобразовывать входные строки сразу напрямую в целое число при помощи встроенной функции. 
// Необходимо сделать это самостоятельно.


string Promt (string message)
{
    Console.Write(message);
    string s = Console.ReadLine();
    return s;
}

/*char [] ConvertToArray (string num)
{
    char [] arrayS = new char [num.Length];

    int index = 0;
    for(int i = 0; i < num.Length; i++)
    {
        arrayS[index] = (num[i]);
        index++;
    }

    return arrayS;
}*/

int [] ConvertToInt (string num)
{
    int [] arrInt = new int [num.Length];
    for (int i = 0; i < num.Length; i++)
    {
        arrInt[i] = Convert.ToInt32(num.Substring(i, 1));
    }
    return arrInt;
}

int CombineInt (int [] arrInt)
{
    int combine = 0;

    for (int i = 0; i < arrInt.Length; i++)
    {
        combine += arrInt[i] * Convert.ToInt32(Math.Pow(10, arrInt.Length-i-1));
    }
    return combine;
}

int Sum (int num1, int num2)
{
    int result = num1 + num2;
    return result;
}

------------------------------------------------------------------------------------

string num1 = Promt("Введите первое число: ");
string num2 = Promt("Введите второе число: ");

int [] arrInt1 = new int [num1.Length];
int [] arrInt2 = new int [num2.Length];

arrInt1 = ConvertToInt(num1);
arrInt2 = ConvertToInt(num2);

int num1Int =  CombineInt(arrInt1);
int num2Int =  CombineInt(arrInt2);

int result = Sum(num1Int, num2Int);

Console.WriteLine(result.ToString());