

Console.WriteLine("Hello");
string[] firstName = new string[] { "Mike", "John", "Bill" };
Console.WriteLine($"To pick a name type a number from 0 to {firstName.Length - 1}");
int number;
bool isValid;

do
{
    string? getNumber = Console.ReadLine();
    isValid = int.TryParse(getNumber, out number);
    if (isValid == false)
    {
        Console.WriteLine("You picked a wrong number, try again");
    }
} while (isValid == false);

if (number < 0 || number > firstName.Length)
{
    Console.WriteLine("Number too high or too low");
}
else
{
    Console.WriteLine($"You picked {firstName[number]}");
}
