
string[]CreateArray(int size)
{
    string [] newArray = new string [size];
    for(int i = 0; i<size; i++)
    {
        Console.Write("Enter string: ");
        newArray[i] = Console.ReadLine();
    }
    return newArray;
}
void PrintArray(string[]arr)
{
    for(int i = 0; i < arr.Length; i++)
        Console.Write(arr[i] + "  ");
    Console.WriteLine();
}
void LessThreeChar(string[]arr)
{
    for(int i =0; i<arr.Length; i++)
    {
        int x = 3; // Значение из условия задачи
        if(arr[i].Length <= x)
            Console.Write(arr[i] + " , ");
    }
    Console.WriteLine();
}

Console.WriteLine("Enter quantity string: ");
int len = Convert.ToInt32(Console.ReadLine());
string[]myArr = CreateArray(len);
PrintArray(myArr);
LessThreeChar(myArr);