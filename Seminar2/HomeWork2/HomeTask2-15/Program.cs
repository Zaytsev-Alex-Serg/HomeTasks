// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

if (number < 6){
    Console.WriteLine("Нет");
}
if(number == 6 || number == 7){
    Console.WriteLine("Да");
}