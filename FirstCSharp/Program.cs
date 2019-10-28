using System;

namespace FirstCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string place = "Coding Dojo";
            Console.WriteLine($"Hello {place}");
            Console.WriteLine("Using Console.WriteLine, you can output any string to the terminal/console");
            Console.WriteLine("The value of pi is " + 3.14159);
            Console.WriteLine("My name is {0}, I am " + 28 + " years old", "Tim");
            Console.WriteLine($"My name is {0}, I am " + 28 + " years old", "Tim");
        }
    }
}
