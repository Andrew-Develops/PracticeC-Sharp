
Console.WriteLine("Hello. Welcome to my application");
Console.WriteLine("Do you want to know you age in 25 years? what about 25 years ago? ");
Console.Write("What is your age: ");
string? ageInput = Console.ReadLine();
int? age = int.Parse(ageInput);

Console.WriteLine();
Console.WriteLine($"In 25 years you will be {age + 25} years old.");
Console.WriteLine();
Console.WriteLine($"25 years ago you were {age - 25}.");
Console.Read();
