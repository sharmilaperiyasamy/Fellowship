using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs_CS
{
    class Reverse_of_Number
    {
        public static void reverseOfNumber()
        {
            Console.WriteLine("Program to reverse the given number");
            int num = Convert.ToInt32(Console.ReadLine());
            string sum = string.Empty;
            int remainder = 0, N;
            N = num;
            while (num != 0)
            {
                remainder = num % 10;
                sum = sum + remainder.ToString();
                num = num / 10;
            }
            Console.WriteLine("The reverse value of given number is = {0}", sum);
            Console.ReadLine();
        }
    }
}
