using System;

namespace Divisible
{
    class Program
    {

        static int Divisible(int dividend, int divisibleCount)
        {
            int end = 100;
            int divisor = 3;
            if(dividend % divisor == 0) // check if the dividend is divisible. If so add one to the count.
            {
                divisibleCount += 1;
            }
            if(dividend <= end) //If the dividend is not at the limit we recursively call the function to check the next number up. Otherwise we return our count.
            {
                return(Divisible(++dividend, divisibleCount));
            }
            else
            {
                return(divisibleCount);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Divisible(1,0));
        }
    }
}
