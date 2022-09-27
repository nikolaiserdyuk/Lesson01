//Methods

//Вид 1 Метод ничего не принимает и ничего не возвращает
void Method1()
{
    Console.Writeline("Author ...");
}
Method1();    //так метод можно вызвать. нужно не забыть про круглые скобки, иначе выдаст ошибку





//Вид 2.1 Метод принимает какие-то аргументы, но ничего не возвращает
void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2("Текст сообщения"); //так можно вызвать метод

//Вид 2.2 Метод принимает аргументы текста и числовые
void Method2(string msg, int count)
{
    int i = 0;
    while(i < count)
    {
        Console.WriteLine(msg);
        i++;     // увеличение счетчика на 1 называется "инкриментом". а уменьшение счетчика на 1 называют "декриментом"
    }
}
Method2("Текст", 4); //так можно вызвать метод, текст "текст" будет прописан четыре раза.
Method2(count: 4, msg : "новый текст"); //а можно и так, используя "именнованные" аргументы


// Вид 3. Метод ничего не принимает, но возвращает
//если метод что-то возвращает, обязательно указать тип данных!

int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();   //так мы переменной присваеваем работу метода которую он произвел выше.
Console.WriteLine(year);


// Вид 4. Метод что-то принимает и что-то возвращает. Самый важный и нужный метод. 

string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;

    while (i < count)
    {
        result = result + text; 
        i++;
    }
    return result;
}
string res = Method4(10, "z");
Console.WriteLine(res);


// ЦИКЛЫ WHILE AND FOR
// FOR ---------------    позволяет условно "упростить" 4 вид метода
// for(int i = 0, i < 10, i++)
// {
//      Console.WriteLine(i);   
// }

string Method4(int count, string text)
{
    string result = String.Empty;
    for( int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string res = Method4(10, "z");
Console.WriteLine(res);


// ЦИКЛЫ В ЦИКЛАХ
// for (int i = 0; i < 10; i++)
//{
//    for (int j = 0; j < 10, i++)
//    {
//         Console.WriteLine(i*j);
//    }
//    Console.WriteLine();
//}

// ПОСТРОИМ ТАБЛИЦУ УМНОЖЕНИЯ ЧЕРЕЗ ЦИКЛ В ЦИКЛЕ:

for (int i = 2; i <= 10; i++)         //i начинаем с 2 как в таблице умножения
{
    for(int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}");
    }
    Console.WriteLine();              // просто переходна новую строчку для таблицы умножения. по идее, таблицу умножения мы уже написали.
}