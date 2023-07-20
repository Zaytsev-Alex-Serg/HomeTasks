// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.


Console.Write("Введите количество строк: ");
int countRow = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int countColumn = int.Parse(Console.ReadLine());

int[,] array = new int[countRow, countColumn];
int minRow = 0;
int minSumRow = 0;
int sumRow = 0;

// Получение размерности массива
int arrayRowLength = array.GetLength(0);
int arrayColumnLength = array.GetLength(1);


// Заполнение массива случайными элементами
for (int i = 0; i < arrayRowLength; i++)
{
    for (int j = 0; j < arrayColumnLength; j++)
    {
        array[i, j] = new Random().Next(1, 11);
    }   
}

// Вывод массива на экран
for (int i = 0; i < arrayRowLength; i++)
{
    for (int j = 0; j < arrayColumnLength; j++)
    {
        Console.Write(array[i, j] + " ");
    }   
    Console.WriteLine();
}



for (int i = 0; i < arrayColumnLength; i++)
{
    minRow += array[0, i];
}
for (int i = 0; i < arrayRowLength; i++)
{
    for (int j = 0; j < arrayColumnLength; j++) sumRow += array[i, j];
    if (sumRow < minRow)
    {
        minRow = sumRow;
        minSumRow = i;
    }
    sumRow = 0;
}
Console.Write($"Наименьшая сумма найдена в строке: {minSumRow}");