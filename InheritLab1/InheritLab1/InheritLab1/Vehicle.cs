using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritLab1
{
    public abstract class Vehicle
    {
        int mpg;
        int horsePower;
        bool transmission;
        
        public void trans()
        {
            if(transmission == true)
            {
                Console.WriteLine("Automatic Transmission");
            }
            else if(transmission == false)
            {
                Console.WriteLine("Manual Transmission");
            }
        }
    }
}
