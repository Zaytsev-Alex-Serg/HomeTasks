// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке

using System;


int[] myArray = new int[8];
Random RandNum = new Random();
for (int i = 0; i < 8; i++)
{
    myArray[i] = RandNum.Next(2);
    Console.WriteLine(myArray[i]);
}

