// Напишите программу, которая принимает на вход 2 числа и проверяет является ли одно число квадратом другого

Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine());

if (a == b *b || b == a * a){
    Console.Write("Ура");
}
else{
    Console.Write("Не ура");
}