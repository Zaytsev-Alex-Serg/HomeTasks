// Ввод данных
Console.Write("Введите трёхзначное число: ");
int a = int.Parse(Console.ReadLine());

// Деление по модулю и получение остатка
int result = a % 10;

// Вывод результата
Console.Write($"Последняя цифра = {result}");