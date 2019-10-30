using System;

namespace Human
{
    class Program
    {
        static void Main(string[] args)
        {
            Human Sombat = new Human ("Sombat");
            Human Target = new Human ("Target");
            Console.WriteLine(Sombat.AccessHealth);
            Console.WriteLine(Target.AccessHealth);
            Sombat.Attack(Target);
            Console.WriteLine(Target.AccessHealth);
        }
    }
}
