using System;

namespace Day2Workshop
{
    class Question06
    {
        static void Main()
        {
            Console.Write("For the first point, give me its x position: ");
            string inputx1 = Console.ReadLine();
            Console.Write("Now give me its y position: ");
            string inputy1 = Console.ReadLine();

            Console.Write("\nFor the second point, give me its x position: ");
            string inputx2 = Console.ReadLine();
            Console.Write("Now give me its y position: ");
            string inputy2 = Console.ReadLine();

            double x1 = Double.Parse(inputx1);
            double y1 = Double.Parse(inputy1);
            double x2 = Double.Parse(inputx2);
            double y2 = Double.Parse(inputy2);

            double a = x2 - x1;
            double a2 = a * a;
            double b = y2 - y1;
            double b2 = b * b;
            double c = a2 + b2;
            double distance = Math.Sqrt(c);

            int milliseconds = 2000;
            System.Threading.Thread.Sleep(milliseconds);
            
            Console.WriteLine("\n******************");
            Console.WriteLine("\nThe distace between the two points is: {0}", distance);
           

        }
    }
}
