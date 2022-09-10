using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharpconcepts
{
    internal class CheckGreater
    {
        public class CheckGreaterOrNot
        {
            public static void CheckTheGreater()
            {
                 
                Console.WriteLine("Enter the 1st number:");
                int x = Convert.ToInt32(Console.ReadLine());
                
                Console.WriteLine("Enter the 2nd number:");
                int y = Convert.ToInt32(Console.ReadLine());

                if (x > y)
                    Console.WriteLine("The greater number is {0}",x);
                else
                    Console.WriteLine("No it is not greater");
            }
        }
    }
}
