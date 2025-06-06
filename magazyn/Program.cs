using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter warehouse capacity: ");
        int capacity = int.Parse(Console.ReadLine());

        Console.Write("Enter maximum total weight (kg): ");
        double maxWeight = double.Parse(Console.ReadLine());

        Warehouse warehouse = new Warehouse(capacity, maxWeight);

        while (true)
        {
            Console.Write("\nChoose action: [add/list/exit]: ");
            string action = Console.ReadLine().Trim().ToLower();

            if (action == "add")
            {
                Console.Write("Item name: ");
                string name = Console.ReadLine();

                Console.Write("Item weight (kg): ");
                double weight = double.Parse(Console.ReadLine());

                Console.Write("Weirdness level (1-10): ");
                int weirdness = int.Parse(Console.ReadLine());

                Console.Write("Is it fragile? (yes/no): ");
                bool isFragile = Console.ReadLine().Trim().ToLower() == "yes";

                Item item = new Item(name, weight, weirdness, isFragile);
                bool success = warehouse.AddItem(item, out string message);
                Console.WriteLine(message);
            }
            else if (action == "list")
            {
                warehouse.ListAllItems();
            }
            else if (action == "exit")
            {
                break;
            }
            else
            {
                Console.WriteLine("Unknown command.");
            }
        }
    }
}
