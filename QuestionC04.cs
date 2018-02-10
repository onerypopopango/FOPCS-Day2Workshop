using System;
using System.Threading;

namespace Day2Workshop
{
    class QuestionC04
    {
        static void Main()
        {
            int onesecond = 1000;
            int twoseconds = 2000;

            Console.WriteLine("Welcome to ABC Taxi Services.");
            Thread.Sleep(twoseconds);

            Console.WriteLine("You have selected the Fare Prediction services.");
            Thread.Sleep(onesecond);
            Console.Write("Please type in the distance to your destination in km: ");
            string inputdist = Console.ReadLine();

            Thread.Sleep(onesecond);
            Console.WriteLine("\n******************");
            Console.WriteLine("\nInput detected, one moment please...");

            double distint = Double.Parse(inputdist);
            double distintround = Math.Ceiling(distint * 10);
            double dist = distintround / 10;
            double fare = 0;

            if (dist <= 0.5)
            {
                fare = 2.4;
            }

            else if ((0.5 < dist) && (dist <= 9))
            {
                double dist100M = (dist - 0.5) * 10;
                fare = 2.4 + (dist100M * 0.04);
            }

            else if ((9 < dist)) 
            {
                double dist100M = dist * 10;
                double extradist = dist100M - 90;
                fare = 2.4 + (85 * 0.04) + (extradist * 0.05);
            }


            Console.WriteLine("\n******************");
            Console.WriteLine("\nOne moment please...");

            Thread.Sleep(twoseconds);

            Console.WriteLine("Your fare for your journey would be {0:C}", fare);

        }
    }
}
