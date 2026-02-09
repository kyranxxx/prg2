//==========================================================
// Student 1: Bryan (S10275435F)
// Student 2: Kyran (S10275200K)
//==========================================================

namespace S10275435_PRG2Assignment
{
    public class OrderItem
    {
        public FoodItem Item { get; set; }
        public int Quantity { get; set; }

        public OrderItem(FoodItem item, int quantity)
        {
            Item = item;
            Quantity = quantity;
        }

        public double GetSubTotal()
        {
            return Item.Price * Quantity;
        }
    }
}