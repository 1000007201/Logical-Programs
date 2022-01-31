using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgram
{
    public class FibonacciSeries
    {
        public void Fibonacci()
        {
            Console.WriteLine("Enter number of terms you need:");
            int number = Convert.ToInt32(Console.ReadLine());
            int first_num = 1, second_num = 1,third_num;
            Console.Write(first_num+"\t"+second_num);
            for (int i = 0; i < number; i++)
            {
                third_num = first_num + second_num;
                first_num = second_num;
                second_num = third_num;
                Console.Write("\t"+third_num);
            }
            Console.WriteLine();
        }
    }
}
