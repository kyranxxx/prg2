//==========================================================
// Student 1: Bryan (S10275435F)
// Student 2: Kyran (S10275200K)
//==========================================================

using S10275435_PRG2Assignment;
using System.Collections.Generic;

namespace S10275435_PRG2Assignment
{
    public class Restaurant
    {
        public string RestaurantID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public List<FoodItem> Menu { get; set; }
        public Queue<Order> OrderQueue { get; set; }

        public Restaurant(string id, string name, string email)
        {
            RestaurantID = id;
            Name = name;
            Email = email;
            Menu = new List<FoodItem>();
            OrderQueue = new Queue<Order>();
        }

        public void AddFoodItem(FoodItem item)
        {
            Menu.Add(item);
        }

        public override string ToString()
        {
            return $"{Name} ({RestaurantID})";
        }
    }
}