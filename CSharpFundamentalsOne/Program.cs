using System;

namespace CSharpFundamentalsOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            for (int i = 1; i <= 255; i++)
            {
                Console.WriteLine(i); // Create a Loop that prints all values from 1-255
            }

            int i2 = 1;
            while (i2 <= 255)
            {
                Console.WriteLine(i2); // Create a Loop that prints all values from 1-255
                i2 = i2 + 1;
            }

            for (int j = 1; j <= 100; j++)
            {
                if (j % 3 == 0 || j % 5 == 0)
                {
                    if (!(j % 3 == 0 && j % 5 == 0))
                    {
                        Console.WriteLine(j); // Create a new loop that prints all values from 1-100 that are divisible by 3 or 5, but not both
                    }
                }
            }

            int j2 = 1;
            while (j2 <= 100)
            {
                if (j2 % 3 == 0 || j2 % 5 == 0)
                {
                    if (!(j2 % 3 == 0 && j2 % 5 == 0))
                    {
                        Console.WriteLine(j2); // Create a new loop that prints all values from 1-100 that are divisible by 3 or 5, but not both
                    }
                }
                j2 = j2 + 1;
            }

            for (int k = 1; k <= 100; k++)
            {
                if (k % 3 == 0 || k % 5 == 0)
                {
                    if (k % 3 == 0 && k % 5 != 0)
                    {
                        Console.WriteLine("Fizz"); // Print "Fizz" if multiple of 3 and not 5
                    }
                    else if (k % 3 != 0 && k % 5 == 0)
                    {
                        Console.WriteLine("Buzz"); // Print "Buzz" if multiple of 5 and not 3
                    }
                    else
                    {
                        Console.WriteLine("FizzBuzz"); // Print "FizzBuzz" if multiple of 3 and 5
                    }
                }
            }

            int k2 = 1;
            while (k2 <= 100)
            {
                if (k2 % 3 == 0 || k2 % 5 == 0)
                {
                    if (k2 % 3 == 0 && k2 % 5 != 0)
                    {
                        Console.WriteLine("Fizz"); // Print "Fizz" if multiple of 3 and not 5
                    }
                    else if (k2 % 3 != 0 && k2 % 5 == 0)
                    {
                        Console.WriteLine("Buzz"); // Print "Buzz" if multiple of 5 and not 3
                    }
                    else
                    {
                        Console.WriteLine("FizzBuzz"); // Print "FizzBuzz" if multiple of 3 and 5
                    }
                }
                k2 = k2 + 1;
            }
        }
    }
}
