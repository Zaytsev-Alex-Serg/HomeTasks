// Напишите программу, которая будет создавать копию заданного массива с помошью поэлементного копирования

int [] OrigArray = new int [6] {0, 1, 2, 3, 4, 5};
int [] CloneArray = new int [OrigArray.Length];
OrigArray.CopyTo (CloneArray, 0);
Console.WriteLine (String.Join(",", CloneArray));