using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgram
{
    public class Payment
    {
        public static void MonthlyPayment(int principal,int year,double rate)
        {
            double n = 12 * year;
            double r = rate / (12 * 100);
            double payment = (principal * r) / 1 - Math.Pow((1 - r), -n);
            Console.WriteLine(payment);

        }
    }
}
