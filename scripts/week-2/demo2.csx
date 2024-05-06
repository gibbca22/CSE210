using System;

class Greeter
{
    public string name = "Stan";
   
    public static string Greet()
    {
        return $"Hello, {name}!";
    }
}

Console.WriteLine(Greeter.Greet());