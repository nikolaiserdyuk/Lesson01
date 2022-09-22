// Напишите программу, которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа

Console.WriteLine("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int firstdigit = num / 100;
int seconddigit = (num /10) % 10;
int thirddigit = num % 10;


Console.WriteLine(seconddigit);