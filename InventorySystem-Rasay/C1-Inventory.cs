using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem_Rasay
{
    class Inventory
    {
        private List<string> snacks;
        private List<string> bathEssentials;
        private List<string> cannedGoods;
        private List<string> beverages;

        public Inventory()
        {
            snacks = new List<string>();
            bathEssentials = new List<string>();
            cannedGoods = new List<string>();
            beverages = new List<string>();
        }
    }
}