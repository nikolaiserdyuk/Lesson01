// Напишите метод, который принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());

void FindCube(int n)
{
    int count = 1;
    if (n > 0)
    {
        while(count <= n)
        {
            Console.WriteLine($"{count, 3} => {Math.Pow((count),3)}");
            count++;
        }
    }
    else
    {
        Console.WriteLine("Введенно отрицательное значение");
    }
}
FindCube(num);