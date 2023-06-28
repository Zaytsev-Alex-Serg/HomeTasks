// Ввод данных
Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());
//Определение дня недели
if (a == 1){
    Console.WriteLine("Понедельник");
}
if (a == 2){
    Console.WriteLine("Вторник");
}
if (a == 3){
    Console.WriteLine("Среда");
}
if (a == 4){
    Console.WriteLine("Четверг");
}
if (a == 5){
    Console.WriteLine("Пятница");
}
if (a == 6){
    Console.WriteLine("Суббота");
}
if (a == 7){
    Console.WriteLine("Воскресенье");
}
if (a > 7 || a < 1) {
    Console.WriteLine("Не правильно введено число");
}