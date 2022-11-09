
// Ask use input
Console.WriteLine("Welcome.");
Console.Write("Eneter your name: ");
string? firstName = Console.ReadLine();
Console.Write("Enter your age: ");
string? getAge = Console.ReadLine();

string formattedName;

if(int.TryParse(getAge, out int age))
{
    if(firstName.ToLower()=="bob" || firstName.ToLower() == "sue")
    {
        formattedName = $"Professor {firstName}";
    }
    else
    {
        formattedName = firstName;
    }

    if(age < 21)
    {
        Console.WriteLine($"I recommend you wait {21-age} years, {formattedName}");
    }
    else
    {
        Console.WriteLine($"Welcome to class {formattedName}");
    }
}
else
{
    Console.WriteLine("You did not provide a valid age");
}





