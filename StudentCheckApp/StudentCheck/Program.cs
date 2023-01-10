System.Console.Write("Enter your name:\t");
string name = Console.ReadLine();
System.Console.Write("\nEnter your age:\t");
string ageText = Console.ReadLine();

if (int.TryParse(ageText, out int age) != true)
{
    System.Console.WriteLine("Please enter valid age");
    return;
}

if (name.ToLower() == "bob" || name.ToLower() == "sue")
{
    name = $"Professor {name}";
    System.Console.WriteLine($"Welcome {name}");
}
else
{
    System.Console.WriteLine($"Welcome to the class, {name}!");
}

if (age < 21)
{
    System.Console.WriteLine($"You have to wait for {21 - age}, {name}");
}