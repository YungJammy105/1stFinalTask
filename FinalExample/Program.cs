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
