using System;
using System.Threading;

namespace Day2Workshop
{
    class QuestionC05
    {
        static void Main()
        {
            int onesecond = 1000;

            Console.WriteLine("We are going to input a three digit number.");
            Console.Write("Please type in the first digit: ");
            string input1 = Console.ReadLine();
            Console.Write("Please type in the second digit: ");
            string input2 = Console.ReadLine();
            Console.Write("Please type in the third digit: ");
            string input3 = Console.ReadLine();


            int num1 = Int32.Parse(input1);
            int num2 = Int32.Parse(input2);
            int num3 = Int32.Parse(input3);
            int sum = 0;

            int num = (num1 * 100) + (num2 * 10) + num3;

            Thread.Sleep(onesecond);
            Console.WriteLine("\n************************************");
            Console.WriteLine("\nInput detected, one moment please...");
            Thread.Sleep(onesecond);

            Console.Write("\nIs {0} your number, Y/N: ", num);
            string ans = Console.ReadLine();

            if (ans == "Y")
            {
                int num13 = num1 * num1 * num1;
                int num23 = num2 * num2 * num2;
                int num33 = num3 * num3 * num3;
                sum = num13 + num23 + num33;

                Thread.Sleep(onesecond);
                Console.WriteLine("\n************************************");
                Console.WriteLine("\nOne moment please...");
                Thread.Sleep(onesecond);

                if (sum == num)
                {
                    Console.WriteLine("\nThe number {0} is an Armstrong number, yay!", num); 
                }
                else
                {
                    Console.WriteLine("\nThe number {0} isn't an Armstrong number, awwwwww...", num);
                }
            }

            else 
            {
                Console.WriteLine("I'm sorry but it seems like I've encountered an error. Please try again next time.");
            }

        }
    }
}
