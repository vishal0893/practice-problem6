using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramsD6
{
    internal class Problem1
    {
        public static void Fibonacci()
        {
            int FirstNo = 0, SecondNo = 1, Nextno, NumItems;
            Console.Write("Enter the number of items");
            NumItems = Convert.ToInt32(Console.ReadLine());
            if (NumItems < 2)
                Console.Write("please enter a no. greater than two");
            else
            {
                //enter the two number
                Console.Write(FirstNo + " " + SecondNo + " ");
                for(int i=2; i<NumItems; i++)
                {
                    Nextno=FirstNo+SecondNo;
                    Console.Write(Nextno + " ");
                    FirstNo=SecondNo;
                    SecondNo = Nextno;
                }
                Console.ReadKey();
            }
        }
    }
}
