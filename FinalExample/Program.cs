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
