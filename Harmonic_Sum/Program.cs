//Travis Kean
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harmonic_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            //Harmonic Sum from left to right
            double sum = 0; //initialize sum to 0
            for(int x = 1; x <= 50000; x++) 
            {
                sum = sum + (1.0 / x); //will sum each number together from 1/1 to 1/50000
            }

            Console.WriteLine("The harmonic sum from n=1 to n= 50,000, left to right is " + sum); //displays sum

            sum = 0;
            for(int x = 50000; x >= 1; x--)
            {
                sum = sum + (1.0 / x); //will sum each number together from 1/50000 to 1/1 
            }

            Console.WriteLine("The harmonic sum from n = 1 to n = 50,000, right to left is " + sum); //displays sum

            Console.ReadLine();
        }
    }
}
