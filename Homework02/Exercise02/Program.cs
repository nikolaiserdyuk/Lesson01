// Напишите программу, которая выводит третью цифру заданного числа или сообщает что третьей цифры нет

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
string number = num.ToString();

int a = number.Length;

if(a < 3)
{
    Console.WriteLine("третьей цифры нет");
}
else if(a > 3)
{
    Console.WriteLine(number[2]);
}
