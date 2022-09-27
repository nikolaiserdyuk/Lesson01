// Напишите программу которая выводит случайноe число из отрезка [10, 99] и показывает наибольшую цифру числа
// 78 -> 8
// 12 -> 2
// 85 -> 8

int n = new Random().Next(10, 100);
Console.WriteLine("Здравствуй, пользователь!");
Console.WriteLine("Загадано число ");
Console.WriteLine(n);

int a = n / 10;
int b = n % 10;

Console.WriteLine("Максимальная цифра: ");
if(a  > b)
{
    Console.WriteLine(a);
}
else
{
    Console.WriteLine(b);
}