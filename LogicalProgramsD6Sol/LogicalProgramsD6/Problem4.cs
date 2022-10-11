using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramsD6
{
    internal class Problem4
    {
        public static void ReverseNo()
        {
            int n, rev = 0, Temp;
            Console.Write("Enter your number");
            n = Convert.ToInt32(Console.ReadLine());
            while(n!=0)
            {
                Temp = n % 10;
                rev = rev * 10 + Temp;
                n /= 10;
            }
            Console.Write("the reverse of the number is " + rev);
            Console.ReadLine();
        }
    }
}
