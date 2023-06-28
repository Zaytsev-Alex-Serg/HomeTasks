// Напишите программу, которая на вход принимает число (число больше 10-ти)
// и выдает его квадрат (число умноженное само на себя)


// Исходное число
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

if (number <= 10){
Console.WriteLine("Ваше число не соответствует условию: число должно быть больше 10-ти");
}
else{
// Результат. Квадрат исходного числа
int result = 0; 
result = number * number;

Console.WriteLine($"Квадрат Вашего числа = {result}");
}

Console.WriteLine("Конец программы");