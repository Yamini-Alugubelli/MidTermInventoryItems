using System;

public class InventoryItem
{
    // Properties
    public string ItemName { get; set; }
    public int ItemId { get; set; }
    public double Price { get; set; }
    public int QuantityInStock { get; set; }

    // Constructor
    public InventoryItem(string itemName, int itemId, double price, int quantityInStock)
    {
        ItemName = itemName;
        ItemId = itemId;
        Price = price;
        QuantityInStock = quantityInStock;

    }

    // Methods

    // Update the price of the item
    public void UpdatePrice(double newPrice)
    {
        if (newPrice >= 0)
        {
            Price = newPrice;
        }
        else
        {
            Console.WriteLine("Error : New Price cannot be neagative");
        }
    }

    // Restock the item
    public void RestockItem(int additionalQuantity)
    {
        if (additionalQuantity >= 0)
        {
            QuantityInStock += additionalQuantity;
        }
        else
        {
            Console.WriteLine("Error : Additional Quantity cannot be neagative");
        }

    }

    // Sell an item
    public void SellItem(int quantitySold)
    {
        if (quantitySold > 0)
        {
            QuantityInStock -= quantitySold;
            if (QuantityInStock < 0)
            {
                QuantityInStock = 0;
            }
        }
        else
        {
            Console.WriteLine("Error: Quatity sold cannot be neagative");
        }
    }

    // Check if an item is in stock
    public bool IsInStock()
    {
        return QuantityInStock > 0;
    }

    // Print item details
    public void PrintDetails()
    {
        Console.WriteLine($"Name: {ItemName}");
        Console.WriteLine($"ID: {ItemId}");
        Console.WriteLine($"Price: {Price}");
        Console.WriteLine($"QuantityInStock: {QuantityInStock}");
    }
}
class Program
{
    static void Main(string[] args)
    {
        // Creating instances of InventoryItem
        InventoryItem item1 = new InventoryItem("Laptop", 101, 1200.50, 10);
        InventoryItem item2 = new InventoryItem("Smartphone", 102, 800.30, 15);

        item1.UpdatePrice(15.0);
        Console.WriteLine("Updated price: " + item1.Price);

        item1.RestockItem(3);
        Console.WriteLine("Updated quantity: " + item1.QuantityInStock);

        item1.SellItem(2);
        Console.WriteLine("Updated quantity after selling: " + item1.QuantityInStock);

        Console.WriteLine("Is in stock: " + item1.IsInStock());

        item1.PrintDetails();

        item2.PrintDetails();




    }
}
