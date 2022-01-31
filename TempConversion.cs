using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgram
{
    public class TempConversion
    {
        public static void TemperatureConversion()
        {
            Console.WriteLine("Enter 1 for Celcius or 0 for Farenhiet Input:");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Temperature:");
            double temp = Convert.ToDouble(Console.ReadLine());
            if (choice == 1)
            {
                double fahrenhiet = (temp * 9 / 5) + 32;
                Console.WriteLine(fahrenhiet);
            }
            else
            {
                double celcius = (temp - 32) * 5 / 9;
                Console.WriteLine(celcius);
            }
        }
    }
}
