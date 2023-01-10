

System.Console.WriteLine("What is your firstName:\t");
string firstName = Console.ReadLine();

if (firstName.ToLower() == "tim" || firstName.ToLower() == "timothy")
{
    System.Console.WriteLine("Hello Professor");
}
else
{
    System.Console.WriteLine("Hello student");
}

switch (firstName.ToLower())
{
    case "tim":
    case "timothy":
        System.Console.WriteLine("Hello Professor (switch)");
        break;
    default:
        System.Console.WriteLine("Hello student (switch)");
        break;
}