// Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8


int num = 8;
int number0 = 1;

while(number0 < num + 1) 
{
    if(number0 % 2 == 0)
        Console.WriteLine(number0);
        number0++;
}
