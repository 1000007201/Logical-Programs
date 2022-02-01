using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgram
{
    public class StopTimer
    {
        public void Timer()
        {
            Stopwatch time = new Stopwatch();
            Console.WriteLine("Timer Starts now\nEnter 1 to stop");
            time.Start();
            int option = Convert.ToInt32(Console.ReadLine());
            if (option == 1)
                time.Stop();
            Console.WriteLine("Time Elapsed: {0:hh\\:mm\\:ss}", time.Elapsed);
        }
    }
}
