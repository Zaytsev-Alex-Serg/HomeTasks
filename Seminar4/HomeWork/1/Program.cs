using System;
 
class UseTypeof
{
    public static void Main()
    {
        int n;
        string str;
        Console.Write("Введите количество элементов массива ");
        try
        {
            str = Console.ReadLine();
            n = int.Parse(str);
        }
        catch(Exception exc)
        {
            Console.WriteLine(exc.Message);
            n = 0;
        }
 
        Console.WriteLine();
 
        int[] a = new int[n];
        for (int i = 0; i < n; i++)
        {
            a[i] = i;
            Console.WriteLine(a[i] + " ");
        }
    }
}