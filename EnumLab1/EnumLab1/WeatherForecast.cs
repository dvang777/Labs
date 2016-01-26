using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumLab1
{
    class WeatherForecast
    {
        public WeatherForecast()
        {

        }
        public void thisDay()
        {
            foreach (int today in Enum.GetValues(typeof(DaysOfTheWeek)))
            {
                Random rand = new Random(DateTime.Now.Millisecond);
                int num = rand.Next(0, 6);
                switch (num)
                {
                    case 0:
                        break;
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    default:
                        break;
                }
                {
                    Console.WriteLine(((DaysOfTheWeek)today).ToString() + "'s forecast is " + ((ForeCast)num).ToString());
                    
                }
            }
        }
    }
}

