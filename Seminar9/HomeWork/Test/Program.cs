// See https://aka.ms/new-console-template for more information

int [] array =  new int [4] {1, 0, 10, 12};
string result = string.Concat(array);

Console.WriteLine(result);

int[] array2 = { 5, 6, 2, 4, 0 };
int combine = 0;

for (int i = 0; i < array2.Length; i++)
{
combine += array2[i] * Convert.ToInt32(Math.Pow(10, array2.Length-i-1));
}

Console.WriteLine(combine);
