using System;
using BL;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppForTesting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var handler = new Handler();
            string input = string.Empty;
            while (input != "q")
            {
                int i = 1.5451;
                Console.WriteLine("Type a number, please");
                input = Console.ReadLine();
                if (int.TryParse(input, out int number))
                {
                    Console.WriteLine(handler.DetermineNumber(number));
                }
                else
                {
                    Console.WriteLine("It's not a number!");
                }
            }
        }
    }
}
