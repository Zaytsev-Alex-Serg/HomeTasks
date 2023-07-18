// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

/*Console.Write("Введите количество строк: ");
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
}*/


Console.Write("Введите количество строк: ");
int countRow = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int countColumn = int.Parse(Console.ReadLine());

double[,] array = new double[countRow, countColumn];

// Получение размерности массива
int arrayRowLength = array.GetLength(0);
int arrayColumnLength = array.GetLength(1);


// Заполнение массива случайными элементами
for (int i = 0; i < arrayRowLength; i++)
{
    for (int j = 0; j < arrayColumnLength; j++)
    {
        array[i, j] = Math.Round(new Random().NextDouble(), 1) * new Random().Next(-2, 2);
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


// Ввод искомого числа
Console.Write("Введите число для поиска в массиве: ");
double num = double.Parse(Console.ReadLine());

// Поиск искомого числа в массиве
for (int i = 0; i < arrayRowLength; i++)
{
    for (int j = 0; j < arrayColumnLength; j++)
    {
        if(array[i, j] == num)
        {
            Console.WriteLine($"Искомое число {num} присутствует в массиве");
            return;
        }
    }   
}
Console.WriteLine($"Искомое число {num} отсутствует в массиве");