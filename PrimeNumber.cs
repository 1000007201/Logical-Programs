using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgram
{
    public class PrimeNumber
    {
        public void PrimeCheck()
        {
            int count = 0 ;
            Console.WriteLine("Enter the number you have to check:");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= number/2; i++)
            {
                if (number % i == 0)
                    count++;
            }
            if (count > 1)
                Console.WriteLine("Number is not a Prime Number");
            else
                Console.WriteLine("Number is a Prime Number");
        }
    }
}
