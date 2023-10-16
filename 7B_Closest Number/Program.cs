using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7B_Closest_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine(NumberClosestTo100(78, 95)); 
            Console.WriteLine(NumberClosestTo100(95, 95)); 
            Console.WriteLine(NumberClosestTo100(99, 70)); 

            Console.ReadLine();
        }

        static int NumberClosestTo100(int num1, int num2)
        {
            int idealValue = 100;

            // Calculate the  differences between the numbers and the target
            int diff1 = Math.Abs(idealValue - num1);
            int diff2 = Math.Abs(idealValue - num2);

            // Compare the differences and return the closest number
            if (diff1 > diff2)
            {
                return num2;
            }
            else if (diff2 > diff1)
            {
                return num1;
            }
            else
            {
                return 0; 
            }
        }
    }   }

