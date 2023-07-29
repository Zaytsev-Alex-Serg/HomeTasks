// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента

int count = 10;

int[,,] array = new int[2, 2, 2];

// Получение размерности массива
int arrayRowLength = array.GetLength(0); 
int arrayColumnLength = array.GetLength(1);
int arrayElementLength = array.GetLength(2);


// Заполнение массива случайными элементами
for (int i = 0; i < arrayRowLength; i++)
{
    for (int j = 0; j < arrayColumnLength; j++)
    {
        for(int k = 0; k < arrayElementLength; k++)
        {
            array[k, i, j] += count;
            count += 3;
        }  
    }   
}

// Вывод массива на экран
for (int i = 0; i < arrayRowLength; i++)
{
    for (int j = 0; j < arrayColumnLength; j++)
    {
        for(int k = 0; k < arrayElementLength; k++)
        {
            Console.Write(array[i, j, k] + " ");
        }        
    }   
    Console.WriteLine();
}

for (int i = 0; i < arrayRowLength; i++)
{
    for (int j = 0; j < arrayColumnLength; j++)
    {
        Console.WriteLine();
        for (int k = 0; k < arrayElementLength; k++)
        {
            Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
        }
    }
}