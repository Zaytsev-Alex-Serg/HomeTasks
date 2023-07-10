// Задайте массив. Напишите программу, которая определяет присутствует ли заданное число в массиве (с методом)

// Ввод значения для поиска его в массиве

int Promt (string message)
{
    Console.Write(message);
    int result = int.Parse(Console.ReadLine());
    return result;
}

// Метод с заданным массивом и поиском значения, введённого пользователем

bool Search (int k)
{
    bool result = false;
    int [] array = new int [] {1, 2, 3, 4};
    Console.WriteLine (array);

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == k)
        {
            result = true;
            break;
        }
        if (array[i] != k)
        {
            result = false;
        }
    }

    return result;
}



int num = Promt("Введите искомое число: ");
bool result = Search(num);

Console.WriteLine(result);
