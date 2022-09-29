// Задание 19. Напишите метод, который принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

int ReadDigit(string digit)
{
    Console.WriteLine(digit);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
string PalindromeOrNot(int number)
{
    if(number / 10000 == number % 10 && (number / 1000) % 10 == (number / 10) % 10)
    return "да";
    else
    {
        return "нет";
    }
}
int number = ReadDigit("Введите пятизначное число: ");
if(number > 9999 && number < 100000)
{
    string result = PalindromeOrNot(number);
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Ошибка: число не пятизначное!");
}