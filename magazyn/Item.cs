using System;

public class Item
{
    public string Name { get; }
    public double WeightKg { get; }
    public int WeirdnessLevel { get; }
    public bool IsFragile { get; }

    public Item(string name, double weightKg, int weirdnessLevel, bool isFragile)
    {
        Name = name;
        WeightKg = Math.Round(weightKg, 3);
        WeirdnessLevel = weirdnessLevel;
        IsFragile = isFragile;
    }

    public string Describe()
    {
        return "{\n" +
               $"\t\"name\": \"{Name}\",\n" +
               $"\t\"weight_kg\": {WeightKg},\n" +
               $"\t\"weirdness_level\": {WeirdnessLevel},\n" +
               $"\t\"is_fragile\": {(IsFragile ? "YES" : "NO")}\n" +
               "}";
    }
}
