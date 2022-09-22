// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным

Console.WriteLine("Напишите число от 1 до 7 чтобы узнать выходной ли сегодня день: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num >= 6 && num <= 7)
{
    Console.WriteLine("Да");
}
if(num <= 5)
{
    Console.WriteLine("Нет");
}
else if( num > 7)
{
    Console.WriteLine("В неделе всего 7 дней :)");
}