using System;
using System.Collections.Generic;

class Program
{
    static List<string> snacks = new List<string>();
    static List<string> bathEssentials = new List<string>();
    static List<string> cannedGoods = new List<string>();
    static List<string> beverages = new List<string>();

    static string pinCode = "0221";

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
                        ViewInventory();
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

    public static void ViewInventory()
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

    public static void DepositItems()
    {
        Console.WriteLine("~~~Deposit Items~~~");
        Console.WriteLine("Enter the category [Snacks, Bath Essentials, Canned Goods, or Beverages]: ");
        string category = Console.ReadLine();

        Console.WriteLine("Enter the item name: ");
        string itemName = Console.ReadLine();

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