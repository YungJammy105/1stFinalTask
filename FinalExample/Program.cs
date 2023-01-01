Console.Clear();
string[] arr = InputStr();
Console.Write("Enter the maximum number of characters per string: ");
int characterLength = int.Parse(Console.ReadLine());
string[] FinalArray = OutputtingAnArrayWithValuesLessThanTwoCharacters(arr);
Thread.Sleep(1000);
Console.Clear();
Console.WriteLine("Your initial array:");
PrintArray(arr);
Console.Write("Loading");
Thread.Sleep(600);
Console.Write(".");
Thread.Sleep(600);
Console.Write(".");
Thread.Sleep(600);
Console.Write(".");
Thread.Sleep(1700);
Console.WriteLine();
if(FinalArray.Length > 0)
{
    Console.WriteLine($"Found values of length <= {characterLength}: {NumberOfCharactersNotExceedingLength(arr)}");
    PrintArray(FinalArray);
}
else
{
    Console.WriteLine("Values not find");
}

int NumberOfCharactersNotExceedingLength(string[] array)
{
    int character = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= characterLength) character++;
    }
    return character;
}

string[] OutputtingAnArrayWithValuesLessThanTwoCharacters(string[] coll)
{
    int index = 0;
    string[] secondArr = new string[NumberOfCharactersNotExceedingLength(coll)];
    for (int i = 0; i < coll.Length; i++)
    {
        if(coll[i].Length <= characterLength)
        {
            secondArr[index] = coll[i];
            index++;
        }
    }
    return secondArr;
}

void PrintArray(string[] arr)
{
    Console.WriteLine($"[{String.Join(", ", arr)}]");
}

string[] InputStr()
{
    Console.Write("Enter array values separated by spaces: ");
    string test = Console.ReadLine();
    string[] temp = test.Split(new Char[] {' '});
    return temp;
}
