using System;
//using Internal;

// This is equivalent to python's print statement
Console.WriteLine("What is your first name?");
string fname = Console.ReadLine();

Console.WriteLine("What is your last name?");

// This is equivalent to python's input function
string lname = Console.ReadLine();

// This is equivalent to pythons f-string
Console.WriteLine($"Your name is {lname}, {fname} {lname}!");