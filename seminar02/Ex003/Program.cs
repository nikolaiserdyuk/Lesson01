// Определить присутствует ли в заданном массиве некоторое число
// 1. массив задается автоматически
// 2. искомое число загадывается компьютером

int count = 10;
int[] array = new int[count];
int find = new Random().Next(1, 21);
int index = 0;
Console.Write("Ищем = ");
Console.WriteLine(find);
Console.WriteLine("Массив: ");

while (index < count)
{
    array[index] = new Random().Next(1, 101);
    Console.WriteLine(array[index] + " ");
    index++;
}

index = 0;
while (index < count)
{
    if(array[index] = find)
    {
        Console.WriteLine("Такой элемент есть");
    }
    index++;
}
Console.WriteLine("\nEnd");