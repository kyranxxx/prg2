//==========================================================
// Student 1: Bryan (S10275435F)
// Student 2: Kyran (S10275200K)
//==========================================================

using S10275435_PRG2Assignment;
using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static List<Restaurant> restaurants = new List<Restaurant>();

    static void Main()
    {
        LoadRestaurants();
        LoadFoodItems();

        Console.WriteLine("Welcome to the Gruberoo Food Delivery System");
        Console.WriteLine($"{restaurants.Count} restaurants loaded!");

        while (true)
        {
            Console.WriteLine("\n===== Gruberoo Food Delivery System =====");
            Console.WriteLine("1. List all restaurants and menu items");
            Console.WriteLine("0. Exit");
            Console.Write("Enter your choice: ");

            string choice = Console.ReadLine();

            if (choice == "1")
                ListRestaurants();
            else if (choice == "0")
                break;
            else
                Console.WriteLine("Invalid choice.");
        }
    }

    static void LoadRestaurants()
    {
        string[] lines = File.ReadAllLines("restaurants.csv");

        foreach (string line in lines)
        {
            string[] parts = line.Split(',');
            Restaurant r = new Restaurant(parts[0], parts[1], parts[2]);
            restaurants.Add(r);
        }
    }

    static void LoadFoodItems()
    {
        string[] lines = File.ReadAllLines("fooditems.csv");

        for (int i = 1; i < lines.Length; i++) // skip header
        {
            string[] parts = lines[i].Split(',');

            string restId = parts[0].Trim();
            string name = parts[1].Trim();
            string desc = parts[2].Trim();

            // Price is always column 3
            double price = double.Parse(parts[3].Trim());

            Restaurant r = restaurants.Find(x => x.RestaurantID == restId);
            if (r != null)
            {
                r.AddFoodItem(new FoodItem(name, desc, price));
            }
        }
    }

    static void ListRestaurants()
    {
        Console.WriteLine("\nAll Restaurants and Menu Items");
        Console.WriteLine("==============================");

        foreach (Restaurant r in restaurants)
        {
            Console.WriteLine($"\nRestaurant: {r.Name} ({r.RestaurantID})");
            foreach (FoodItem fi in r.Menu)
            {
                Console.WriteLine($"  - {fi}");
            }
        }
    }
}
