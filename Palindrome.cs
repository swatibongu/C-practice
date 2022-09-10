using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharpconcepts
{
    internal class Palindrome
    {
        public class palindrome
        {
            public static void CheckPalindrome()
            {
                int rem, result = 0, temp;
                Console.WriteLine("Enter the number");
                int num = Convert.ToInt32(Console.ReadLine());
                temp = num;
                while(num!= 0)
                {
                    rem = num % 10;
                    result = result * 10 + rem;
                    num = num / 10;
                }
                if (temp == num)
                    Console.WriteLine("It is palindrome");
                else
                    Console.WriteLine("It is not a palindrome number");
            }
        }
    }
}
