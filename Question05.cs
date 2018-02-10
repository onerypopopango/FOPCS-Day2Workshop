using System;

namespace Day2Workshop
{
    class Question05
    {
        static void Main()
        {
            Console.Write("Give me a number: ");
            string input = Console.ReadLine();

            double x = Double.Parse(input);
            double xsquare = x * x;
            double a = 5 * xsquare;
            double b = 4 * x;
            double y = a - b + 3;
            
            Console.WriteLine("\n******************");
            Console.WriteLine("\nUsing the formulae where y = 5x^2 – 4x + 3 where x is the number you gave...");
            Console.WriteLine("y = {0}", y);

        }
    }
}
