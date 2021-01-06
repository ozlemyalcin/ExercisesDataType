using System;

namespace MoreNumericTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of miles: ");
            string milesInput = Console.ReadLine();
            int miles = int.Parse(milesInput);

            Console.WriteLine("Enter amount of gas: ");
            string gasInput = Console.ReadLine();
            int gas = int.Parse(gasInput);

            int milesPerGalon = (miles / gas);
            Console.WriteLine("Miles per galon: " + milesPerGalon);

        }
    }
}
