﻿// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// Ввод данных 
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine());

// Вводим счётчик цикла
int i = 0;

//Цикл в котором счётчик увеличивается на 1, пока не станет равным числу N. Выводятся только числа, при делении по модулю на 2 остаток которых равен 0 (не беря 0)
while (i <= N){
    if (i > 0 && i % 2 == 0){
        Console.Write($"{i} ");
        i += 1;
    }
    else {
        i += 1;
    }
} 
