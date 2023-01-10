using System.Globalization;

DateTime today = DateTime.Now;

// DateTime birthday = DateTime.Parse("6/15/1998");

// DateTime birthday = DateTime.ParseExact("6/11/1998", "d/M/yyyy", CultureInfo.InvariantCulture);

DateOnly birthday = DateOnly.ParseExact("6/11/1998", "d/M/yyyy", CultureInfo.InvariantCulture);

Console.WriteLine(birthday);
// Console.WriteLine(today.ToString("MMMM dd, yyyy hh:mm tt zzz"));
Console.WriteLine($"Today full format: {today}");
Console.WriteLine($"Today just date: {today.Date}");
Console.WriteLine($"Birtday: {birthday}");

TimeOnly opensAt = TimeOnly.Parse("8:00 AM");
TimeOnly rightNow = TimeOnly.FromDateTime(DateTime.Now);
Console.WriteLine(opensAt);
Console.WriteLine(rightNow);