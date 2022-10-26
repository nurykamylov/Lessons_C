/*
string text = "Key difference: How About You and What About You are two questions ";
Console.WriteLine(text);
            

string ChangingCases(string text, char oldValue, char newValue)
{

    string result = String.Empty;
    int length = text.Length;

    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = $"{text[i]}";
    }  
    return result; 
}

string newtext = ChangingCases(text, 'a', 'A' );
Console.WriteLine(newtext);



for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i*j}");
    }
    Console.WriteLine();
}
*/

int [] arr = { 1, 8, 3, 4, 7, 9, 5, 3};

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}");
    }
}



void Replace(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int miniposition = i;
        for (int j = i+1; j < array.Length; j++)
        {
            if ( array[j] < array[miniposition]) miniposition = j;
        }
        int temp = array[i];
        array[i] = array[miniposition];
        array[miniposition] = temp;
    }
}

PrintArray(arr);

Replace(arr);
Console.WriteLine();

PrintArray(arr);