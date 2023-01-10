

string[] firstNames = new string[3] { "Vamsi", "Bob", "Sue" };
string userInputString;
string userContinue;

do
{
    System.Console.WriteLine("Enter a number between 0 and 2: ");
    userInputString = Console.ReadLine();
    if (int.TryParse(userInputString, out int userInput) && userInput < 3)
    {
        System.Console.WriteLine(firstNames[userInput]);
    }
    else
    {
        System.Console.WriteLine("Enter a valid input");
    }
    System.Console.WriteLine("Do you want to continue? ");
    userContinue = Console.ReadLine();
} while (userContinue.ToLower() == "yes");