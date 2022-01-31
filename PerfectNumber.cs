using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgram
{
    public class PerfectNumber
    {
        public void Perfect()
        {
            Console.WriteLine("Enter number you have to check:");
            int number = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= number/2; i++)
            {
                if (number % i == 0)
                    sum += i;
            }
            if (sum == number)
                Console.WriteLine("Number is a Perfect Number");
            else
                Console.WriteLine("Number is not a Perfect Number");
        }
    }
}
