﻿// Ввод данных

Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine());

if (b * b == a){
    Console.WriteLine("ДА");
}
else{
    Console.WriteLine("НЕТ");
}