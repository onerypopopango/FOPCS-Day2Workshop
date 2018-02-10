using System;

namespace Day2Workshop
{
    class Question01
    {
        static void Main()
        {
            Console.Write("Give me a number: ");
            string num = Console.ReadLine();

            double numb = Double.Parse(num);
            double sqrt = System.Math.Sqrt(numb);

            Console.WriteLine("\n******************");
            Console.WriteLine("\nThe square root is: {0}", sqrt);

        }
    }
}
