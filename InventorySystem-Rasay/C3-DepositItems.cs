using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem_Rasay
{
    public void DepositItems(string category, string itemName)
    {
        switch (category)
        {
            case "Snacks":
                snacks.Add(itemName);
                Console.WriteLine($"Deposited the item {itemName} in Snacks successfully.");
                break;
            case "Bath Essentials":
                bathEssentials.Add(itemName);
                Console.WriteLine($"Deposited the item {itemName} in Bath Essentials successfully.");
                break;
            case "Canned Goods":
                cannedGoods.Add(itemName);
                Console.WriteLine($"Deposited the item {itemName} in Canned Goods successfully.");
                break;
            case "Beverages":
                beverages.Add(itemName);
                Console.WriteLine($"Deposited the item {itemName} in Beverages successfully.");
                break;
            default:
                Console.WriteLine("Invalid category. Please choose a valid category.");
                break;
        }
    }
}