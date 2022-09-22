// Напишите программу, которая принимает на вход семь чисел, и находит их среднее арифметическое
// вариант 1: у пользователя ничего не спрашиваем.
//Console.WriteLine("Введите семь чисел: ");
//int[] array = Convert.ToInt32(Console.ReadLine[]); ????????

int[] array = {10, 20, 30, 40, 50, 60, 70};
int n = array.Length;
n = 7;
int index = 0;
int sum = 0;

while(index < n)
{
    sum = array[index] + sum;
    index++;
}
int middle = sum / n;
Console.WriteLine(middle);
