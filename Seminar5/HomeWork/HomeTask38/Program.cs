// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива

double [] array = new double [5] {5.1, 6.3, 1.4, 3.0, 0.1}; 

double min = array[0];
double max = array[0];
double result = 0;

for (int i = 0;  i < array.Length; i++)
{
    if (array[i] < min)
    {
        min = array[i];
    }
    if (array[i] > max)
    {
        max = array[i];
    }
}

result = max - min;

Console.WriteLine ($"Разница между максимальным и минимальным значениями равны: {result}");
