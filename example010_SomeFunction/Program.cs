int[] array =  new int [10];

void FillArray(int[] collection)
{
    int i = 0;
    int n  = collection.Length;
    while( i < n )
    {
        collection[i] = new Random().Next(1, 10);
        i++;
    }
}

void PrintArray(int[] Try)
{
    int i = 0;
    int n  = Try.Length;
    while( i < n )
    {
        Console.WriteLine(Try[i]);
        i++;
    }
}

FillArray (array);
PrintArray(array);

Console.WriteLine();

int Indexof(int[] Some_Array, int find)
{
    int index = 0;
    int n = Some_Array.Length;
    int H = 0;
    while(index<n)
    {
        if (find == Some_Array[index])
        {
            H = index;
            break;
        }
        index++;
    }
    return H;
}

int ex = Indexof(array, 7 );
Console.WriteLine(ex);