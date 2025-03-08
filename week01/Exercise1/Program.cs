using System;

class Program
{
    static void Main(string[] args)
    {
    //  Console.WriteLine("Hello World! This is the Exercise1 Project.");

    //  Show on the screen phrase What is your first name?
    //  and accepting on screen the first name of the person
        Console.Write("What is your first name? ");
        string first = Console.ReadLine();

    //  Show on the screen phrase What is your last name?
    //  and accepting on screen the first name of the person
        Console.Write("What is your last name? ");
        string last = Console.ReadLine();

    //  Show on the screen phrase Your name is with last and first name
        Console.WriteLine($"Your name is {last}, {first} {last}.");    
    }
}