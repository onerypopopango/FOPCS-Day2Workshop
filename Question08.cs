using System;
using System.Threading;

namespace Day2Workshop
{
    class Question08
    {
        static void Main()
        {
            int onesecond = 1000;
            int twoseconds = 2000;

            Console.WriteLine("Welcome to ABC Taxi Services.");
            Thread.Sleep(twoseconds);

            Console.WriteLine("You have selected the Fare Prediction services.");
            Thread.Sleep(onesecond);
            Console.Write("Please type in the distance to your destination: ");
            string inputdist = Console.ReadLine();

            Thread.Sleep(onesecond);
            Console.WriteLine("\n******************");
            Console.WriteLine("\nInput detected, one moment please...");

            double dist = Double.Parse(inputdist);
            double cost = dist * 0.4;
            double totalcost = 2.40 + cost;
            double totalcostround = Math.Round(totalcost, 1);
            Thread.Sleep(twoseconds);

            Console.WriteLine("\n******************");
            Console.WriteLine("\nThe total cost for your journey would be ${0:0.00}", totalcostround);
           

        }
    }
}
