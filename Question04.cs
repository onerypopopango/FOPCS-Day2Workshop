using System;

namespace Day2Workshop
{
    class Question04
    {
        static void Main()
        {
            Console.Write("What is the current temperature in Centigrade: ");
            string input = Console.ReadLine();

            double centigrade = Double.Parse(input);
            double fahrenheit = (centigrade * 1.8) + 32;
            
            Console.WriteLine("\n******************");
            Console.WriteLine("\nThe current temperature in Fahrenheit is: {0}", fahrenheit);

        }
    }
}
