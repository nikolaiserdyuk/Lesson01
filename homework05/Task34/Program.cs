// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество четных чисел в массиве.

// 1. Задать массив 
// 2. Заполнить случайными положительными трёхзначными числами
// 3. Написать программу, которая покажет количество четных чисел в массиве

int RandomCollection(int min, int max)
{
  return new Random().Next(min, max);
}

int[] CreateArray(int size)
{
  return new int[size];
}

void Fill(int[] array)
{
  int size = array.Length;
  int i = 0;

  while (i < size)
  {
    array[i] = RandomCollection(100, 999);
    i++;
  }
}

void Print(int[] array)
{
  int i = 0;
  int size = array.Length;
  while (i < size)
  {
    Console.Write(array[i] + " ");
    i++;
  }
  Console.WriteLine();
}

int SearchNumberEvenElements(int[] array)
{
  int count = 0;
  int size = array.Length;
  int i = 0;
  while (i < size)
  {
    if (array[i] % 2 == 0)
    {
      count += 1;
    }
    i++;
  }
  return count;
}

int length = RandomCollection(10, 20);
int[] col = CreateArray(length);
Print(col);
Fill(col);
Print(col);
int count = SearchNumberEvenElements(col);
Console.Write(count);