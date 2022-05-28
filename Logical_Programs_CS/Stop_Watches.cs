using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Logical_Programs_CS
{
    public class Stop_Watches
    {
        public static void stopWatches()
        {

            Stopwatch stopwatch = new Stopwatch();
        validation1:
            Console.WriteLine("To start the stopwatch enter S or s.");
#pragma warning disable CS8604 // Possible null reference argument.
            char start = Convert.ToChar(Console.ReadLine());
#pragma warning restore CS8604 // Possible null reference argument.
            stopwatch.Start();
            if (start == 's' || start == 'S')
            {
                
                Console.WriteLine("stopwatch started");
        validation2:
            Console.WriteLine("To stop the stopwatch enter Q or q.");
#pragma warning disable CS8604 // Possible null reference argument.
            char end = Convert.ToChar(Console.ReadLine());
#pragma warning restore CS8604 // Possible null reference argument.
                 if (end == 'q' || end == 'Q')
                 {
                      stopwatch.Start();
                      Console.WriteLine("stopwatch stopped, the time:" + stopwatch.Elapsed);
                 }
                 else
                 {
                      Console.WriteLine("Wrong Input");
                      goto validation2;
                 }
             }
             else
             {
                 stopwatch.Stop();
                  Console.WriteLine("Wrong Input");
                  goto validation1;
             }
         }
    }
}
