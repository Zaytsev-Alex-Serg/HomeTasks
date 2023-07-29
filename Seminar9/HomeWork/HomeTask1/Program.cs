// Дан одномерный массив целых чисел, элементом которого, может быть либо 1, либо 0.
// Ваша задача вывести на экран максимальное количество следующих друг за другом 1

int[] array = new int [7] {1, 1, 1, 1, 0, 1, 1};

int arrayLength = array.GetLength(0);

int counter = 0;
int counterMax = 0;
for(int i = 0; i < arrayLength; i++)
{
    if(array[i] == 1)
    {
        if(counter <= counterMax || counter == 1)
        {
            counter += 1;
        }
        if(counter > 1 && counter > counterMax)
        {
            counterMax = counter;
        }
    }
    if(array[i] == 0)
    {
        counter = 0;
    }
}

Console.WriteLine($"Количество элементов с значением 1 следующих друг за другом: {counterMax}");
