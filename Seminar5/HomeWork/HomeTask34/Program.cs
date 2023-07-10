// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// Идентифицируем массив

int [] array = new int [8];

// Заполняем массив случайными трёхзначными числами

for (int i = 0; i < array.Length; i++) 
{
    array [i] = new Random().Next(100, 1000);

    Console.Write(array[i] + " ");
}   

Console.WriteLine();

// Считаем чётные и нечётные числа и их количество

int sumEven = 0;
int sumNotEven = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array [i] % 2 == 0)
    {
        sumEven++;
    }
    if (array [i] % 2 != 0)
    {
        sumNotEven++;
    }
}

Console.WriteLine($"Количество чётных чисел равно: {sumEven}");
Console.WriteLine($"Количество не чётных чисел равно: {sumNotEven}");