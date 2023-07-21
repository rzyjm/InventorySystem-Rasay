// Rasay, James MIguel A.
// BSCPE BN 1-1

using InventorySystem_Rasay;
using System;
using System.Collections.Generic;

class Inventory
{
    static string pinCode = "0221";
    static InventorySystem_Rasay.Inventory inventory = new InventorySystem_Rasay.Inventory();

    public static void Main(string[] args)
    {
        Console.Write("Enter PIN Code: ");
        string userInput = Console.ReadLine();

        while (userInput != "0")
        {
            if (userInput == pinCode)
            {
                Console.WriteLine("~ Welcome to Inventory ~");
                Console.WriteLine("_____________________");
                Console.WriteLine("Enter 1 to View Inventory");
                Console.WriteLine("Enter 2 to Deposit Items");
                Console.WriteLine("Enter 3 to Exit Inventory");
                Console.WriteLine("-------------------------");
                Console.Write("Enter your choice: ");
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        inventory.ViewInventory();
                        break;
                    case "2":
                        DepositItems();
                        break;
                    case "3":
                        Console.WriteLine("Exiting Inventory...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid PIN Code. Please try again.");
            }

            Console.WriteLine("_____________________");
            Console.Write("Do you want to continue (y/n)? ");
            string continueChoice = Console.ReadLine();

            if (continueChoice.ToLower() == "n")
            {
                Console.WriteLine("Exiting Inventory...");
                return;
            }

            Console.Write("Enter PIN Code: ");
            userInput = Console.ReadLine();
        }
    }

    public static void DepositItems()
    {
        Console.WriteLine("~~~Deposit Items~~~");
        Console.WriteLine("Enter the category [Snacks, Bath Essentials, Canned Goods, or Beverages]: ");
        string category = Console.ReadLine();

        Console.WriteLine("Enter the item name: ");
        string itemName = Console.ReadLine();

        inventory.DepositItems(category, itemName);
    }
}