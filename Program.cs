void PrintArray(string[] array)
{
    System.Console.Write("[");
    if (array.Length == 0)
        System.Console.Write("]");
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1)
            System.Console.Write("\"" + array[i] + "\"" + "]");
        else
            System.Console.Write("\"" + array[i] + "\"" + ", ");
    }
    System.Console.WriteLine();
}

string[] CreateNewArray(string[] array)
{
    int newArrayLength = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
            newArrayLength++;
    }
    string[] newArray = new string[newArrayLength];
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[count++] = array[i];
        }
    }
    return newArray;
}
string[] array = {"1234", "1567", "-2", "computer science"};
PrintArray(array);
PrintArray(CreateNewArray(array));