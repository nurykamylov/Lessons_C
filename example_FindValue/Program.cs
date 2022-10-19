int[]array = {13,21,33,42,51,65,71,84,19};
int find = 51;
int n = array.Length;
int index = 0;
while(index<n)
    {
        if (find == array[index])
        {
            Console.WriteLine(index);
        }
        index++;
    } 