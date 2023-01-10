// bool isComplete = true;

// if (isComplete) 
// {
//     System.Console.WriteLine("The statemet was true.");
// }
// else
// {
//     System.Console.WriteLine("The statement was false");

// }

System.Console.Write("What is your first name:\t");
// System.Console.WriteLine("What is your last name:\t");
string? firstName = Console.ReadLine();
if (firstName.ToLower() == "vamsi")
{
    System.Console.WriteLine("Hello Mr. Chivukula");   
}
else
{
    System.Console.WriteLine($"Hello {firstName}");
}


System.Console.WriteLine("End of program");