using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs_CS
{
    public class EvenorOdd
    {
        public static void Even_Odd_Number()
        {
            int userInput;
            Console.Write("Enter a Number: ");
            userInput = Convert.ToInt32(Console.ReadLine());
            if(userInput % 2 == 0)
            {
                Console.Write("The Number is an Even Number");
                Console.Read();
            }
            else
            {
                Console.Write("The Number is an Odd Number");
                Console.Read();
            }
        }
    }
}
