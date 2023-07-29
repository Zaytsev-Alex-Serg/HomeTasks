// Факториала 

int GetFactorial (int n)
{
    int result = 1;
    for(int i = 1; i <= n; i++)
    {
        result = result * i;
    }

    return result;
}

int GetRecFactorial (int n)
{
    if (n == 1) return 1;

    int temp = n * GetRecFactorial(n - 1);
    return temp;
}


Console.WriteLine(GetRecFactorial(5));