using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_1
{
    internal static class IntExtention
    {
        // [extension methods]  ---->  (used as a class member method or object member method )
        public static int reverse(this int number)
        {

            int reversedNumber = 0;
            int lastDigit = 0;

            while(number > 0)
            {
                lastDigit = number  % 10;
                reversedNumber = reversedNumber * 10 + lastDigit;
                number = number / 10;

            }

            return reversedNumber;
        }

        public static long reverse(this long number)
        {

            long reversedNumber = 0;
            long lastDigit = 0;

            while (number > 0)
            {
                lastDigit = number % 10;
                reversedNumber = reversedNumber * 10 + lastDigit;
                number = number / 10;

            }

            return reversedNumber;
        }




    }
}
