using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgram
{
    public class Calender
    {
        public static int DayOfWeek(int month ,int day,int year)
        {
            int year_not = year - (14 - month) / 12;
            int x = year_not + year_not / 4 - year_not / 100 + year_not / 400;
            int month_not = month + 12 * ((14 - month) / 12) - 2;
            int day_not = (day + x + 31 * month_not / 12) % 7;
            return (int)day_not;
        }
    }
}
