// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

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

// Расчёт среднеарифметического в каждом столбце

for (int j = 0; j < arrayColumnLength; j++)
{
    double sum = 0;
    for (int i = 0; i < arrayRowLength; i++)
    {
        sum = sum + array[i, j];
    }   
    double result = Convert.ToDouble(sum / arrayRowLength);
    Console.Write(" " + result);
}

