using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharpconcepts
{
    internal class CheckPrime
    {
        public class CheckThePrime
        {
            public static void CheckPrimeOrNot()
            {
                Console.WriteLine("Enter the number:");
                int n = Convert.ToInt32(Console.ReadLine());
                if (n % 2 == 0)
                    Console.WriteLine("It is not prime number.");
                else
                    Console.WriteLine("It is a prime number.");
            }
        }
    }
}
