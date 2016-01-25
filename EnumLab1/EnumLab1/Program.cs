using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumLab1
{
    class Program
    {
        static void Main(string[] args)
        {
            DaysOfTheWeek daysOfTheWeek = new DaysOfTheWeek();
            ForeCast foreCast = new ForeCast();

            daysOfTheWeek.thisDay(foreCast.weather());
            //foreCast.weather();
        }
    }
}
