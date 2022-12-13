using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfDigits
{
    internal class SumOfDigitOfNum
    {
        public void Sum()
        {
            int rem, sum = 0;
            Console.WriteLine("Enter a Number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            while (num != 0)
            {
                rem = num % 10;
                sum = sum + rem;
                num = num / 10;
            }
            Console.WriteLine("Sum of digit is : {0}", sum);
        }
    }
    
}
