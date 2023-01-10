// string[] firstNames = new string[5];

// firstNames[0] = "Tim";
// firstNames[1] = "Sue";
// firstNames[2] = "Bob";
// firstNames[4] = "Jane";

// System.Console.WriteLine($"First names are {firstNames[0]}, {firstNames[1]}, {firstNames[2]}, and {firstNames[4]}");

// firstNames[0] = "Timothy";

// System.Console.WriteLine(firstNames[0]);


// single quotes identifies a char
// double quotes identifies a string
string data = "Tim,Sue,Bob,Jane,Frank";
string[] firstNames = data.Split(',');

System.Console.WriteLine(firstNames.Length);

string[] lastNames = new string[] { "Chivukula", "Smith", "Jones" };

int[] ages = new int[] { 2, 3, 4 };
