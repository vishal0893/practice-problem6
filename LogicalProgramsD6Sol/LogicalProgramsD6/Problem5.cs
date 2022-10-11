using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramsD6
{
    internal class Problem5
    {
        public static void CuponGenerator()
        {
            int n = 1, CuponNumber, count = 0;
            Console.WriteLine("enter the cupon no");
            CuponNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number of digits");
            int Digits=Convert.ToInt32(Console.ReadLine());
            int[] cuponsList = new int[CuponNumber + 1];;

            Random random = new Random();
            for (int i = 1; i <= CuponNumber; i++)
            {
                count++;
                int a = Convert.ToInt32(Math.Pow(10, Digits - 1));
                int b = Convert.ToInt32(Math.Pow(10, Digits));
                int randomCoupon = random.Next(a, b);
                if (cuponsList.Contains(randomCoupon))
                {
                    i--;
                    n += 1;
                }
            
                else
            {
                    cuponsList[i] = randomCoupon;
                Console.WriteLine($"Number of random numbers generated to get Coupon number {i} are {n}");
                n = 1;
            }
        }
        Console.Write("the randomly generated cupon count " + count);
            
        }
    }
}
