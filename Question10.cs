using System;
using System.Threading;

namespace Day2Workshop
{
    class Question10
    {
        static void Main()
        {
            int onesecond = 1000;
            int twoseconds = 2000;

            Console.WriteLine("Area of Triangle Calculator.");
            Console.Write("Please type in side A of your triangle: ");
            string sideAinput = Console.ReadLine();
            Console.Write("Please type in side B of your triangle: ");
            string sideBinput = Console.ReadLine();
            Console.Write("Please type in side C of your triangle: ");
            string sideCinput = Console.ReadLine();

            Thread.Sleep(onesecond);
            Console.WriteLine("\n******************");
            Console.WriteLine("\nOne moment please...");

            double sideA = Double.Parse(sideAinput);
            double sideB = Double.Parse(sideBinput);
            double sideC = Double.Parse(sideCinput);
            double s = (sideA + sideB + sideC) / 2;

            double sA = s - sideA;
            double sB = s - sideB;
            double sC = s - sideC;

            double S = s * sA * sB * sC;
            double area = Math.Sqrt(S);

            Thread.Sleep(twoseconds);

            if (S <= 0)
            {
                Console.WriteLine("\n******************");
                Console.WriteLine("I'm sorry, something seems to be wrong. Please try again later.");
            }

            else
            {
                Console.WriteLine("\n******************");
                Console.WriteLine("\nThe area of your triangle is {0}", area);
            }
           

        }
    }
}
