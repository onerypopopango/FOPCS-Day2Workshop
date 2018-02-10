using System;
using System.Threading;

namespace Day2Workshop
{
    class QuestionC06
    {
        static void Main()
        {
            int onesecond = 1000;

            Console.Write("Please type in a three digit number: ");
            string input = Console.ReadLine();

            int num = Int32.Parse(input);

            Thread.Sleep(onesecond);
            Console.WriteLine("\n************************************");
            Console.WriteLine("\nInput detected, one moment please...");
            Thread.Sleep(onesecond);

            int num1 = num / 100;   //integer division
            int num2 = (num % 100) / 10;
            int num3 = num % 10;

            int num13 = num1 * num1 * num1;
            int num23 = num2 * num2 * num2;
            int num33 = num3 * num3 * num3;
            int sum = num13 + num23 + num33;

            if (sum == num)
            {
                    Console.WriteLine("\nThe number {0} is an Armstrong number, yay!", num); 
            }
            else
            {
                    Console.WriteLine("\nThe number {0} isn't an Armstrong number, awwwwww...", num);
            }

        }
    }
}
