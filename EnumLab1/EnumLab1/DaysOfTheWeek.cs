using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumLab1
{
    public class DaysOfTheWeek
    {
        enum Days { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday };


        public void thisDay(string weather)
        {
            foreach (int today in Enum.GetValues(typeof(Days)))
            {
            Console.WriteLine(((Days)today).ToString() + "'s forcast is " + weather);
            }
        }
        }

      
}
