//Напишите программу, которая принимает на вход семь чисел, и находит их среднее арифметическое
// Вариант 2: спрашиваем числа у пользователя


int[] array = new int[7];
int n = array.Length;
n = 7;
int index = 0;
int sum = 0;

while(index < n)
{
    Console.WriteLine("Введите число: ");
    array[index] = Convert.ToInt32(Console.ReadLine());
    sum = array[index] + sum;
    index++;
}
int middle = sum / n;
Console.WriteLine(middle);