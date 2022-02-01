using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgram
{
    public class SquareRoot
    {
        public void Root()
        {
            Console.WriteLine("Enter Number: ");
            double number = Convert.ToDouble(Console.ReadLine());
            double x = number;
            double root = 0;
            while(Math.Abs(x-number/x)>(1e-15)*x)
            {
                root =(double)0.5 * ((number / x) + x);
                x = root;
            }
            Console.WriteLine(root);

        }
    }
}
