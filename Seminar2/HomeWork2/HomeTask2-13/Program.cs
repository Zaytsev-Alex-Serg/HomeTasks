//  Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

int counter = 0;
int result = 0;

if (number / 100 == 0){
    Console.WriteLine("Третьей цифры нет");
}
else{
    while (number > 1000){
        number = number / 10;
        Console.WriteLine(number);
    }
result = number % 10;
Console.WriteLine("Третья цифра: " + result);
}

