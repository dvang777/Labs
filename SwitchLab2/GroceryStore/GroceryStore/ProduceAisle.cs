using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryStore
{
    class ProduceAisle
    {
        public void aisleNumber()
        {
            foreach(string item in Enum.GetNames(typeof(Produce)))
            {
                Console.WriteLine(item + " Produce Aisle # 3.");
            }
        }
    }
}
