using System;

Console.Write("Who would you like to say hello to? ");

string name = Console.ReadLine();

if (string.IsNullOrWhiteSpace(name))
{
    Console.WriteLine("Fine, don't say 'hello'!");
}
else
{
    Console.WriteLine($"Hello, {name}!");
}

Console.Write("What's your first Name?");
string firstName = Console.ReadLine();

// Console.Write(firstName[8]);
// Console.Write(firstName[7]);
// Console.Write(firstName[6]);
// Console.Write(firstName[5]);
// Console.Write(firstName[4]);
// Console.Write(firstName[3]);
// Console.Write(firstName[2]);
// Console.Write(firstName[1]);
// Console.WriteLine(firstName[0]);

Console.Write("What's your last Name?");
string lastName = Console.ReadLine();

// Console.Write(lastName[3]);
// Console.Write(lastName[2]);
// Console.Write(lastName[1]);
// Console.WriteLine(lastName[0]);

//================================================

string reverse = "";
string fullName = firstName + " " + lastName;

for (int i = fullName.Length - 1; i >= 0; i--)
{
    reverse += fullName[i];
}

Console.WriteLine(reverse);

//================================================

for (int i = fullName.Length - 1; i >= 0; i--)
{
    Console.Write(fullName[i]);
}



// System.Console.Write("Who would you like to say hello to? ");

// string name = System.Console.ReadLine();

// if (string.IsNullOrWhiteSpace(name))
// {
//     System.Console.WriteLine("Fine, don't say 'hello'!");
// }
// else
// {
//     System.Console.WriteLine($"Hello, {name}!");
// }