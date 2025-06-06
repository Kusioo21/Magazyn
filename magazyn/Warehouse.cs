using System;
using System.Collections.Generic;
using System.Linq;

public class Warehouse
{
    private int Capacity { get; }
    private double MaxTotalWeight { get; }
    private List<Item> Items { get; }

    public Warehouse(int capacity, double maxTotalWeight)
    {
        Capacity = capacity;
        MaxTotalWeight = Math.Round(maxTotalWeight, 3);
        Items = new List<Item>();
    }

    public bool AddItem(Item item, out string message)
    {
        if (Items.Count >= Capacity)
        {
            message = "Warehouse is full.";
            return false;
        }

        double currentWeight = Items.Sum(i => i.WeightKg);
        if (currentWeight + item.WeightKg > MaxTotalWeight)
        {
            message = "Adding this item would exceed the maximum total weight.";
            return false;
        }

        Items.Add(item);
        message = "Item added successfully.";
        return true;
    }

    public void ListAllItems()
    {
        if (Items.Count == 0)
        {
            Console.WriteLine("Warehouse is empty.");
            return;
        }

        foreach (var item in Items)
        {
            Console.WriteLine(item.Describe());
        }
    }
}
