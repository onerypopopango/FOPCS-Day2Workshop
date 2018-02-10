using System;
using System.Threading;

namespace Day2Workshop
{
    class QuestionC01
    {
        static void Main()
        {
            int twoseconds = 2000;

            Console.Write("Hello there, what is your name: ");
            string nameinput = Console.ReadLine();
            Console.Write("Please indicate your gender, M/F: ");
            string genderinput = Console.ReadLine();

            Console.WriteLine("\n******************");
            Console.WriteLine("\nOne moment please...");

            Thread.Sleep(twoseconds);

            if (genderinput == "M")
            {
                Console.WriteLine("\n******************");
                Console.WriteLine("\nGood morning Mr.{0}", nameinput);
            }

            else
            {
                Console.WriteLine("\n******************");
                Console.WriteLine("\nGood morning Ms.{0}", nameinput);
            }
           

        }
    }
}
