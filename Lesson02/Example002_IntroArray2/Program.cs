int[] array = {1, 122, 23, 4, 54, 63, 122, 72, 81};

int n = array.Length;
int find = 122;

int index = 0;
while(index < n)
{
    
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    // index = index + 1;
    index++;
}