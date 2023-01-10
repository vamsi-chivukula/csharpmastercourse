

string? userResponse;
do
{
    Console.Write("Enter your name:\t");
    string? name = Console.ReadLine();

    if (name.ToLower() == "tim")
    {
        Console.WriteLine($"Welcome to the class Prof. {name}");
    }
    else
    {
        Console.WriteLine($"Welcome to the class {name}");
    }

    Console.Write("\n\n Do you want to continue?\t");
    userResponse = Console.ReadLine();

} while (userResponse.ToLower() == "yes");