// See https://aka.ms/new-console-template for more information
using System;

namespace Csharpconcepts
{ 
    public class Program
    {
        public static void Main(String[] args)
        {
            
            Console.WriteLine("\n1.CheckPrime\n2.Reverse\n3.Palindrome\n4.CheckGreater");
         
            Console.WriteLine("Select a choice:");
            int program = Convert.ToInt32(Console.ReadLine());
            

            switch (program)
            {
                case 1:
                    CheckPrime.CheckThePrime.CheckPrimeOrNot();
                    break;
                case 2:
                    Reverse.DoReverse.CheckReverse();
                    break;
                case 3:
                    Palindrome.palindrome.CheckPalindrome();
                    break;
                case 4:
                    CheckGreater.CheckGreaterOrNot.CheckTheGreater();
                    break;
                default:
                    Console.WriteLine("No program exit.");
                    break;

            }
        }
    }




}


