using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharpconcepts
{
    internal class Reverse
    {
         public class DoReverse
        {
            public static void CheckReverse()
            {
                int rem, result = 0;
                Console.WriteLine("Enter a number:");
                int num = Convert.ToInt32(Console.ReadLine());
                while (num!=0)
                {
                    rem = num % 10;
                    result = result * 10 + rem;
                    num = num / 10;
                }
                Console.WriteLine("The reverse number is {0}",result);
            }
        }
    }
}

