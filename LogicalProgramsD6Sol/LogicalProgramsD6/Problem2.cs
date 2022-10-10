using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramsD6
{
    internal class Problem2
    {
        public static void PerfectNumber()
        {
            int Pnum, Sum = 0;
            Console.Write("Enter the number:");
            Pnum =Convert.ToInt32(Console.ReadLine());  
            for(int i = 1; i < Pnum; i++)
            {
                if (Pnum % i == 0)
                {
                    Sum += i;
                    Console.Write(" " + i + " ");
                }

            }
            if (Sum == Pnum)
                Console.WriteLine(Pnum + " is a perfect number");
            else
                Console.Write(Pnum + " is not a perfect number");
        }
    }
}
