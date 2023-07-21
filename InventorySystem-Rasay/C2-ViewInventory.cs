using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem_Rasay
{
    public void ViewInventory()
    {
        Console.WriteLine("Inventory:");
        Console.WriteLine("Snacks:");
        if (snacks.Count == 0)
        {
            Console.WriteLine("No items in this category.");
        }
        else
        {
            foreach (string item in snacks)
            {
                Console.WriteLine(item);
            }
        }

        Console.WriteLine("Bath Essentials:");
        if (bathEssentials.Count == 0)
        {
            Console.WriteLine("No items in this category.");
        }
        else
        {
            foreach (string item in bathEssentials)
            {
                Console.WriteLine(item);
            }
        }

        Console.WriteLine("Canned Goods:");
        if (cannedGoods.Count == 0)
        {
            Console.WriteLine("No items in this category.");
        }
        else
        {
            foreach (string item in cannedGoods)
            {
                Console.WriteLine(item);
            }
        }

        Console.WriteLine("Beverages:");
        if (beverages.Count == 0)
        {
            Console.WriteLine("No items in this category.");
        }
        else
        {
            foreach (string item in beverages)
            {
                Console.WriteLine(item);
            }
        }
    }
}
