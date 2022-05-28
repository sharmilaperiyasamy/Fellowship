using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs_CS
{
    public class LargestNumber
    {
        public static void LargestValue()
        {
            Console.WriteLine(".....Finding Maximum number among the three User inputs....");
            Console.WriteLine("Enter the First Number");
            int Firstnumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second Number");
            int Secondnumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Third Number");
            int Thirdnumber = Convert.ToInt32(Console.ReadLine());
            if (Firstnumber.CompareTo(Secondnumber) > 0 && Firstnumber.CompareTo(Thirdnumber) > 0)
            {
                Console.WriteLine("The Largest Number is " + Firstnumber);
            }
            else if (Secondnumber.CompareTo(Firstnumber) > 0 && Secondnumber.CompareTo(Thirdnumber) > 0)
            {
                Console.WriteLine("The Largest Number is " + Secondnumber);
            }
            else if (Thirdnumber.CompareTo(Firstnumber) > 0 && Thirdnumber.CompareTo(Secondnumber) > 0)
            {
                Console.WriteLine("The Largest Number is " + Thirdnumber);
            }
            else
            {
                Console.WriteLine("All the numbers are same");
            }
        }
    }
}
