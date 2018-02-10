using System;
using System.Threading;

namespace Day2Workshop
{
    class QuestionC02
    {
        static void Main()
        {
            int twoseconds = 2000;

            Console.Write("Hello there, what is your name: ");
            string nameinput = Console.ReadLine();
            Console.Write("How old are you: ");
            string ageinput = Console.ReadLine();
            Console.Write("Please indicate your gender, M/F: ");
            string genderinput = Console.ReadLine();

            int age = Int32.Parse(ageinput);

            Console.WriteLine("\n******************");
            Console.WriteLine("\nOne moment please...");

            Thread.Sleep(twoseconds);

            if (age < 40)
            {
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

            else
            {
                if (genderinput == "M")
                {
                    Console.WriteLine("\n******************");
                    Console.WriteLine("\nGood morning Uncle {0}", nameinput);
                }

                else
                {
                    Console.WriteLine("\n******************");
                    Console.WriteLine("\nGood morning Aunty {0}", nameinput);
                }
            }
           

        }
    }
}
