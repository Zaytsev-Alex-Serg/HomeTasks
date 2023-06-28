// Ввод данных
Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine());

// Определение большего числа и вывод данных

if (a > b){
    Console.Write($"max = {a}");
}
if (b > a){
    Console.Write($"max = {b}");
}
if (a == b){
    Console.Write($"Числа {a} и {b} равны");
}
