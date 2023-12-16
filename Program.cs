using System;
using System.Collections.Generic;

// Define the base class representing a product
public class Product
{
    // Property in the base class
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public int Tiers { get; set; }

    // Constructor of the base class
    public Product()
    {
        Console.WriteLine("Bakery Inventory");
    }
}

// Define the derived class representing Cake
public class Cake : Product
{
    // Property in the derived class
    public string Flavor { get; set; }

    // Additional property in the derived class
    public string Frosting { get; set; }

    // Constructor of the derived class
    public Cake()
    {
        Console.WriteLine("Cakes For sale");
    }

    // Override ToString() to provide custom string representation
    public override string ToString()
    {
        return $"Name: {Name}, Description: {Description}, Price: {Price:C}, Tiers: {Tiers}, Flavor: {Flavor}, Frosting: {Frosting}";
    }

}

class Program
{
    static void Main()
    {
        Console.WriteLine("How many records of cake do you want to add? ");
        var numberOfRecords = int.Parse(Console.ReadLine());

        var cakeList = new List<Cake>();
        for (int i = 0; i < numberOfRecords; i++)
        {
            // In this loop, populate the object's properties using Console.ReadLine()
            var cake = new Cake(); // create an object of the derived class

            Console.WriteLine("What is the name of the cake?: ");
            cake.Name = Console.ReadLine();

            Console.WriteLine("Enter the price of the cake: ");
            cake.Price = decimal.Parse(Console.ReadLine());

            Console.WriteLine("How many tiers is this cake?");
            cake.Tiers = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Description of the Cake");
            cake.Description = Console.ReadLine();

            Console.WriteLine("What is the flavor of the cake?");
            cake.Flavor = Console.ReadLine();

            Console.WriteLine("What type of frosting does the cake have?");
            cake.Frosting = Console.ReadLine();

            cakeList.Add(cake);
        }

        // Print out list of records using Console.WriteLine()
        foreach (var item in cakeList)
        {
            Console.WriteLine(item.ToString());
        }
    }
}
