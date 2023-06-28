// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// Ввод данных
Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine());  

Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine());  

Console.Write("Введите третье число: ");
int c = int.Parse(Console.ReadLine());  

// Определение большего числа

if (a > b && a > c){
    Console.WriteLine($"Самое большое число {a}");
}
if (a < c && c > b){
    Console.WriteLine($"Самое большое число {c}");
}
if (a < b && b > c){
    Console.WriteLine($"Самое большое число {b}");
}