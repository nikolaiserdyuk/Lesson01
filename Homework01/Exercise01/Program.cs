﻿// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

int a = -9;
int b = -3;

if(a > b) 
{
    Console.Write("max = ");
    Console.WriteLine(a);
    Console.Write("min = ");
    Console.WriteLine(b);
}
else
{
    Console.Write("max = ");
    Console.WriteLine(b);
    Console.Write("min = ");
    Console.Write(a);
}

// пытался написать код для любых чисел, но без знания синтаксиса весь терминал красным пылает. получилось сделать такой алгоритм только в третьей задаче. 
// также отмечу что по условию задачи нужно указать какое число больше, а какое меньше, поэтому в две строки, а не просто указатель макса.