﻿// Напишите программу, которая принимает на вход 3 числа и проверяет, может ли существовать треугольник со сторонами такой длины 
// (каждая стороная треугольника меньше суммы двух других сторон)

int Promt (string message)
{
    Console.Write(message);
    int result = int.Parse(Console.ReadLine());
    return result;
}

int a = Promt("Введите первое число: ");
int b = Promt("Введите второе число: ");
int c = Promt("Введите третье число: ");

if (a + b < c)
{
    Console.WriteLine("Не может быть треугольника с такими длинами сторон");
}
if (b + c < a)
{
    Console.WriteLine("Не может быть треугольника с такими длинами сторон");
}
if (c + a < b)
{
    Console.WriteLine("Не может быть треугольника с такими длинами сторон");
}
else
{
    Console.WriteLine("Треугольник с заданными длинами сторон может существовать");
}



//Console.WriteLine($"{a}, {b}, {c}");