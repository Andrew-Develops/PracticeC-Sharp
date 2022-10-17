



Console.WriteLine("Welcome.");
Console.Write("Please input your first name: ");
string? firstName = Console.ReadLine();
Console.Write("Please input your last name: ");
string? lastName = Console.ReadLine();

if ((firstName.ToLower() == "tim" || firstName.ToLower() == "timothy") && lastName.ToLower() == "corey")
{
    Console.WriteLine("Welcome professor");
}
else
{
    Console.WriteLine("Welcome student");
}

switch (firstName.ToLower())
{
    case "tim" or "timothy":
        if (lastName.ToLower() == "corey")
        {
            Console.WriteLine("Welcome professor");
        }
        else
        {
            Console.WriteLine("Welcome student");
        }
        break;
    default:
        Console.WriteLine("Welcome student");
        break;

}
