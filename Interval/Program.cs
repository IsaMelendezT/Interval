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
            Console.WriteLine("Please enter a real number: ");
            double x = Double.Parse(Console.ReadLine());

            bool belong = ((x >= -10) && (x <= -2)) || ((x >= 2) && (x < 3)) || ((x > 0) && (x <= 1));

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
