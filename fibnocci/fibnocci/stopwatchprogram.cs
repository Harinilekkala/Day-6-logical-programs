using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace fibnocci
{
    internal class stopwatchprogram
    {
        Stopwatch stopwatchnew = new Stopwatch();
        public void calculatetime()
        {
            stopwatchnew.Start();
            Console.WriteLine("wait till to press any key 'y' key to stop timer");
            if (Console.ReadKey().Key == ConsoleKey.S)
            {
                stopwatchnew.Stop();
            }
            TimeSpan time = stopwatchnew.Elapsed;
            Console.WriteLine("\nElapsed Time is {0:00}M:{1:00}S",  time.Minutes, time.Seconds);
        
        }
    
    }
}
