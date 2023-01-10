
Console.Write("Enter your age: ");
string? ageText = Console.ReadLine();

bool isValidInt = int.TryParse(ageText, out int age);

Console.WriteLine($"You have entered {age}. In 25 years you would be {age + 25} years old and 25 years ago you were {age - 25} years old.");