string firstName = string.Empty;
string lastName = string.Empty;
string filePath = string.Empty;

firstName = "Vamsi";
lastName = "Chivukula";
// filePath = "C:\\Temp\\Demo";
filePath = @"C:\Temp\Demo"; // @ - string literal character
string testString = $@"The file for {firstName} is at C:\SampleFiles";

// Console.WriteLine(firstName + lastName);
Console.WriteLine($"{firstName} {lastName}");
Console.WriteLine(filePath);
Console.WriteLine(testString);