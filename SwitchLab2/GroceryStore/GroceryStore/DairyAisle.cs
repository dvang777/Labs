using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryStore
{
    class DairyAisle
    {
        public void aisleNumber()
        {
            foreach (string product in Enum.GetNames(typeof(DairyProducts))){
                Console.WriteLine(product + " Dairy Aisle # 14");
            }
        }
    }
}
