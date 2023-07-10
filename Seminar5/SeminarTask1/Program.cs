// Задайте массив из 12 элементов, заполенных случайными числами [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива

int [] array = new int [12];


for (int i = 0; i < array.Length; i++)
{
    array [i] = new Random().Next(-9, 10);

    Console.Write (array[i] + " ");
} 
Console.WriteLine ();

// Подсчёт суммы отрицательных и положительных элементов

int sumPositive = 0;
int sumNegative = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
        sumPositive = sumPositive + array [i];

    if (array[i] < 0)
        sumNegative = sumNegative + array[i];  
}

Console.WriteLine ($"Сумма положительных чисел : {sumPositive}");
Console.WriteLine ($"Сумма отрицательных чисел : {sumNegative}");