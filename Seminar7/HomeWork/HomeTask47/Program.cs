// Задайте двумерный массив m*n, заполенный случайными ыещественными числами

Console.Write("Введите количество строк: ");
int countRow = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int countColumn = int.Parse(Console.ReadLine());

double[,] array = new double[countRow, countColumn];

// Получение размерности массива
int arrayRowLength = array.GetLength(0);
int arrayColumnLength = array.GetLength(1);


// Заполнение массива случайными элементами
for (int i = 0; i < countRow; i++)
{
    for (int j = 0; j < countColumn; j++)
    {
        array[i, j] = Math.Round(new Random().NextDouble(), 2) * new Random().Next(-11, 11);
    }   
}

// Вывод массива на экран
for (int i = 0; i < countRow; i++)
{
    for (int j = 0; j < countColumn; j++)
    {
        Console.Write(array[i, j] + " ");
    }   
    Console.WriteLine();
}