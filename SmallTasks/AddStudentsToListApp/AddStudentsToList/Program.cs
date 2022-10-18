
Console.WriteLine("Welcome");
List<string> studentList = new List<string>();
bool endOfList = true;

do
{
    Console.Write("Type the name of the student to add them to the list: ");
    string addName = Console.ReadLine();
    studentList.Add(addName);
    Console.Write("If you want to add another student type 'y' or 'n'. ");
    string input = Console.ReadLine();
    if(input == "n")
    {
        endOfList = false;
    }
} while (endOfList);

Console.WriteLine(studentList.Count());
