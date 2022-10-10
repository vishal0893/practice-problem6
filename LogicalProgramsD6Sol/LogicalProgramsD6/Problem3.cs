using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramsD6
{
    internal class Problem3
    {
        public static void PrimeNumber()
        {
            int Prime, counter = 0;
            Console.Write("Enter your choice of number");
            Prime = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= Prime; i++)
            {
                if (Prime % i == 0)
                    counter++;
            }
            if (counter == 2)
                Console.Write(Prime + " is a prime number");
            else
                Console.Write(Prime + " is not a prime number");

        }
    }
}
