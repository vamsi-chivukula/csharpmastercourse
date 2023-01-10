

bool isValidAge;
int age;

do
{
    System.Console.Write("What is your age:\t");
    string ageText = Console.ReadLine();
    isValidAge = int.TryParse(ageText, out age);

    if (isValidAge == false)
    {
        System.Console.WriteLine("Enter valid age.");
    }
} while (isValidAge == false);


// do
// {
    
// } while (true);

// while (true)
// {
    
// }