// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

number = number /10;
int result = (number % 10); 

Console.WriteLine(result);