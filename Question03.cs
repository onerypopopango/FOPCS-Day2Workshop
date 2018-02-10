using System;

namespace Day2Workshop
{
    class Question03
    {
        static void Main()
        {
            string name;

            Console.Write("What is your name: ");
            name = Console.ReadLine();

            Console.Write("What is your current salary: ");
            string sala = Console.ReadLine();

            double salary = Double.Parse(sala);
            double housing = salary * 0.1;
            double transport = salary * 0.03;
            double totalincome = salary + housing + transport;
            
            Console.WriteLine("\n******************");
            Console.WriteLine("\n{0}, your total income is: {1}", name, totalincome);

        }
    }
}
