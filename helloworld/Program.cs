// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string firstName = "David";
string lastName = "Benshabbat";

// Ex Trim
Console.WriteLine($"Hello {firstName.Trim()} {lastName.Trim()} :)");


//Ex Replace
string fullName = firstName + " " + lastName;
Console.WriteLine(fullName);
Console.WriteLine(fullName.Replace(firstName,"DavidChen"));
Console.WriteLine(fullName);
Console.WriteLine(fullName.Replace("David","DavidChen"));
Console.WriteLine(fullName);
fullName = fullName.Replace(firstName,"DavidChen");
Console.WriteLine(fullName);


