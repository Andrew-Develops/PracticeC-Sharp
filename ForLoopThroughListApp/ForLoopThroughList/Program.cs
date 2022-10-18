

Console.WriteLine("Hello");
Console.WriteLine("Enter a list of names separated by comma");
string getList = Console.ReadLine();

List<string> firstNames = getList.Split(',').ToList();
for (int i = 0; i < firstNames.Count; i++)
{
    Console.WriteLine($"Hello {firstNames[i]}");
}
Console.WriteLine("End.");
