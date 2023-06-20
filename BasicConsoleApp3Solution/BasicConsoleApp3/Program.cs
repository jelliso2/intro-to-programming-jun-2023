

using GeneralUtilities;

Console.WriteLine("Enter your first name");
string firstName = Console.ReadLine();

Console.WriteLine("Enter your last name");
string lastName = Console.ReadLine();


string fullname = Formatters.FormatName(firstName, lastName);


Console.WriteLine($"Hello, {fullname}");