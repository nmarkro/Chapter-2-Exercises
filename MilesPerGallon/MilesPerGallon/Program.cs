using System;

namespace MilesPerGallon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input number of miles driven: ");
            int milesDriven = int.Parse(Console.ReadLine());
            Console.Write("Input gallons of gas used: ");
            int gallonsUsed = int.Parse(Console.ReadLine());
            float milesPerGallon = (float)milesDriven / (float)gallonsUsed;
            Console.WriteLine("Your miles-per-gallon: " + milesPerGallon);
        }
    }
}
