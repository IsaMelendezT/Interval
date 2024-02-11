using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interval
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Asking input from the user
            Console.WriteLine("Please enter a real number: ");
            double x = Double.Parse(Console.ReadLine());

            // Declaring boolean variable to see if the user input belongs to the set
            bool belong = ((x >= -10) && (x <= -2)) || ((x >= 2) && (x < 3)) || ((x > 0) && (x <= 1));

            // Using if-else to determine which answer to prompt according to the boolean variable
            if (belong)
            {
                Console.WriteLine("{0} x belongs to I ...", x);
            }
            else
            {
                Console.WriteLine("{0} x does not belong to I ...", x);
            }

        }
    }
}
