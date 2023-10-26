using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1_Digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("input a number: ");
            int theNumber = Convert.ToInt32(Console.ReadLine());

            int numberCopy = theNumber;
            int digitCounter;

            digitCounter = 0;

            while (numberCopy >= 1)
            {
                digitCounter++;
                numberCopy = (int) numberCopy/10;
            }

            
            int[] numberCase;
            numberCase = new int[digitCounter];

            numberCopy = theNumber;

            for(int i = 0; i < digitCounter; i++) 
            {
                numberCase[digitCounter-i-1] = numberCopy % 10;
                numberCopy = (int) numberCopy / 10;

            }

            Console.Write("\nDigits of the number : ");

            for(int i = 0; i < digitCounter; i++) 
            {
                Console.Write("" + numberCase[i]);
                Console.Write("   ");

            }






             Console.ReadLine();







        }
    }
}
