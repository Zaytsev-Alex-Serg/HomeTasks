// Дан одномерный массив целых однозначных чисел (элемент массива содержит число от 1 до 9).
// Ваша задача вывести на экран число, которое формируется элементами массива слева-направо + 1.

int[] array = new int [1] {9};

int sum = 0;
string tempString = "";

int arrayLength = array.GetLength(0);

for (int i = 0; i < arrayLength; i++)
{
    string arrString = array[i].ToString();
    tempString = tempString + arrString;
}
int tempConcat = int.Parse(tempString);
sum = tempConcat + 1;
Console.WriteLine(sum);