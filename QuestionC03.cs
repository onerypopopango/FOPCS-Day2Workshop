using System;
using System.Threading;

namespace Day2Workshop
{
    class QuestionC03
    {
        static void Main()
        {
            int twoseconds = 2000;

            Console.Write("Hello there, what did you get for your exam yesterday (out of 100): ");
            string scoreinput = Console.ReadLine();

            double score = Double.Parse(scoreinput);

            Console.WriteLine("\n******************");
            Console.WriteLine("\nOne moment please...");

            Thread.Sleep(twoseconds);

            if ((80 <= score) && (score <= 100)) Console.WriteLine("\nYou scored {0} marks which is A grade.", score);
            else if ((60 <= score) && (score < 80)) Console.WriteLine("\nYou scored {0} marks which is B grade.", score);
            else if ((40 <= score) && (score < 60)) Console.WriteLine("\nYou scored {0} marks which is C grade.", score);
            else if ((0 <= score) && (score < 40)) Console.WriteLine("\nYou scored {0} marks which is F grade.", score);
            else Console.WriteLine("\n**ERROR**");

        }
    }
}
