using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs_CS
{
    class Perfect_Number
    {
        public static void perfectNumber()
        {
            Console.WriteLine("Perfect Numbers");
            int below = 10000, sum;
            for (int i = 1; i < below; i++)
            {
                sum = 0;
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        sum = sum + j;
                    }
                    else
                    {
                        continue;
                    }
                    if (i == sum)
                    {
                        Console.WriteLine("The number {0} is a Perfect Number", i);
                    }
                }
                Console.ReadKey();
            }
        }
    }
}
