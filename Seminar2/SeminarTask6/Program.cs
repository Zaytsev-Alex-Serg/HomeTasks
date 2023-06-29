// Напишите программу, которая примет от пользователя число (int), и выведет на экран количество цифр в этом числе.
// Число может быть любой разрядности (до int)

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

int count = 0;

while (number != 0){
    number = number / 10;
    count += 1;
}
Console.WriteLine(count);
