using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgram
{
    public class ReverseNumber
    {
        public void Reverse()
        {
            Console.WriteLine("Enter Number:");
            int number = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            while(number > 0)
            {
                sum = sum * 10 + number % 10;
                number /= 10;

            }
            Console.WriteLine(sum);
        }
    }
}
