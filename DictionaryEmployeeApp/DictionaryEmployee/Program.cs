

Console.WriteLine("Hello");

Dictionary<string,string> employees = new Dictionary<string,string>();
bool endOfList = true;
do
{
    Console.Write("Enter employee id: ");
    string getId = Console.ReadLine();
    Console.Write("Enter employee name: ");
    string getName = Console.ReadLine();
    Console.Write("To add another employee press 'y' or 'n'. ");
    string endList = Console.ReadLine();
    employees.Add(getId, getName);
    if(endList.ToLower() == "n")
    {
        endOfList = false;
    }
} while (endOfList);

Console.WriteLine($"You added: {employees.Count} employee.");
