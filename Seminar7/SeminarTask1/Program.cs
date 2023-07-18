// Задайте двумерный массив m*n, заполенный случайными целыми числами

Console.Write("Введите количество строк: ");
int countRow = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int countColumn = int.Parse(Console.ReadLine());

int[,] array = new int[countRow, countColumn];

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

// Сумма элементов массива каждой строки
for (int i = 0; i < arrayRowLength; i++)
{
    int sum = 0;
    for (int j = 0; j < arrayColumnLength; j++)
    {
        sum = sum + array[i, j];
    }   
    Console.Write($"В строке под номерм {i} сумма элементов равна: {sum}");
    Console.WriteLine();

}