// Напишите программу, которая будет преобразовывать десятичное число в двоичное
// (сформировать строчку и вернуть пользователю на экран)

string Promt (string message)
{
    Console.Write(message);
    int result = int.Parse(Console.ReadLine());
    string binary = Convert.ToString(result, 2); 
    return binary;
}

string num = Promt("Введите число: ");

Console.WriteLine(num);