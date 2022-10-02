
//индексация двумерного массива тоже с 0
                      //
string[,] table = new string[2, 5];
//String.Empty
//table[0, 0]   table[0, 1]  table[0, 2]  table[0, 3]  table[0, 4]
//table[1, 0]   table[1, 1]  table[1, 2]  table[1, 3]  table[1, 4]



//table[1, 2]="слово";
//
//for(int rows = 0; rows < 2; rows++)
//{
//    for(int columns = 0; columns < 5; columns++)
//    {
//        Console.WriteLine($"-{table[rows, columns]}-");
//    }
//}


//int[,] matrix = new int[3, 4];
//
//for(int rows = 0; rows < matrix.GetLength(0); rows++)
//{
//    for(int columns = 0; columns < matrix.GetLength(1); columns++)
//    {
//        Console.Write($"{matrix[rows, columns]} ");
//    }
//Console.WriteLine();
//}


// !Создадим метод который создает двумерный массив и заполняет его!


void PrintArray(int[,] matr)     //так мы создали метод который создает матрицу
{
    for(int rows = 0; rows < matr.GetLength(0); rows++)
    {
        for(int columns = 0; columns < matr.GetLength(1); columns++)
        {
            Console.Write($"{matr[rows, columns]} ");
        }
    Console.WriteLine();    
    }
}

void FillArray(int[,] matr)                // так мы создаем метод который заполняет нашу матрицу !случайными! числами !
{
    for(int rows = 0; rows < matr.GetLength(0); rows++)
    {
        for(int columns = 0; columns < matr.GetLength(1); columns++)
        {
            matr[rows, columns] = new Random().Next(1, 10);    //[1, 10)
        }
    }
}


int[,] matrix = new int[3, 4];
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);