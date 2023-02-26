
Console.Write("What is your first name?: ");
string? firstName = Console.ReadLine();

Console.Write("What is your last name?: ");
string? lastName = Console.ReadLine();

if (firstName.ToLower() == "josh" && lastName.ToLower() == "o'connor")
{
    Console.WriteLine("Hello Mr. O'Connor");
}
else if (lastName.ToLower() == "o'connor")
{
    Console.WriteLine("You have a cool last  name!");
}
else if (firstName.ToLower() == "josh")
{
    Console.WriteLine("You have a great first name!!");
}
else
{
    Console.WriteLine("Sorry you dont have a cooler name! :P");
}