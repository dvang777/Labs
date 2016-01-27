using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryStore
{
    class Program
    {
        static void Main(string[] args)
        {
            DairyAisle dairyAisle = new DairyAisle();
            ProduceAisle produceAisle = new ProduceAisle();



            dairyAisle.aisleNumber();
            produceAisle.aisleNumber();
        }
    }
}
