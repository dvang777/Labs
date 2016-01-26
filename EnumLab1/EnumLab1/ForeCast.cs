using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumLab1
{
    public class ForeCast
    {
        string condition;
        public enum Forecast { Sunny, Rainy, Cloudy, Snow, Windy, Clear, Foggy };
        

        public string weather()
        {
            foreach(string condition in Enum.GetNames(typeof(Forecast)))
            {
                return (condition);
            }
            return condition;
        }
    }
}
