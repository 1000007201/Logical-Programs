using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgram
{
    public class DecimalToBinary
    {
        public void Binary()
        {
            Console.Write("Enter Number:");
            int[] array = new int[10];
            int number = Convert.ToInt32(Console.ReadLine());
            int i;
            int count = 0;
            for( i=0 ;number>0; i++)
            {
                array[i] = number % 2;
                number = number/ 2;

            }
            for (i=i-1; i >=0;i--)
            {
                Console.Write(array[i]);
            }
            Console.WriteLine();
        }
    }
}
