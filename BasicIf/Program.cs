

//bool isComplete = true;

//if (isComplete)
//{
//    Console.WriteLine("The statement was True.");
//    Console.WriteLine("This line works in True.");
//}
//else
//{
//    Console.WriteLine("The statement was False.");
//    Console.WriteLine("This should also run.");
//}


Console.Write("What is your first name: ");
string? firstName = Console.ReadLine();

string lastName;

if (firstName.ToLower() == "tim")
{
    Console.WriteLine("Hello Mr. Corey.");
    lastName = "Corey";
}
else
{
    Console.WriteLine($"Hello {firstName}.");
    lastName = "Smith";
}

Console.WriteLine(lastName);
Console.WriteLine("End of program.");