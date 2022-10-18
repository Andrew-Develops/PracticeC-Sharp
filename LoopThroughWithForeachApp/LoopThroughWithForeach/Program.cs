

Console.WriteLine("Hello");
List<string> list = new List<string>();
bool endOfList = false;
do
{
    Console.Write("Enter a person name: ");
    string name = Console.ReadLine();
    list.Add(name);
    Console.WriteLine("Press 'y' to add another person or 'n'.");
    string input = Console.ReadLine();
    if (input == "n") 
    { 
        endOfList = true; 
    }

} while (endOfList == false);

foreach(string name in list)
{
    Console.WriteLine($"Hello {name}");
}
