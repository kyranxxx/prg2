//==========================================================
// Student 1: Bryan (S10275435F)
// Student 2: Kyran (S10275200K)
//==========================================================

namespace S10275435_PRG2Assignment
{
    public class FoodItem
    {
        public string ItemName { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

        public FoodItem(string itemName, string description, double price)
        {
            ItemName = itemName;
            Description = description;
            Price = price;
        }

        public override string ToString()
        {
            return $"{ItemName}: {Description} - ${Price:F2}";
        }
    }
}