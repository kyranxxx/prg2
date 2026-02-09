//==========================================================
// Student 1: Bryan (S10275435F)
// Student 2: Kyran (S10275200K)
//==========================================================

using System;
using System.Collections.Generic;

namespace S10275435_PRG2Assignment
{
    public class Order
    {
        public int OrderID { get; set; }
        public Customer Customer { get; set; }
        public Restaurant Restaurant { get; set; }
        public List<OrderItem> Items { get; set; }
        public string Address { get; set; }
        public DateTime DeliveryDateTime { get; set; }
        public string Status { get; set; }
        public double TotalAmount { get; set; }
        public Payment Payment { get; set; }

        public Order(int orderId, Customer customer, Restaurant restaurant)
        {
            OrderID = orderId;
            Customer = customer;
            Restaurant = restaurant;
            Items = new List<OrderItem>();
            Status = "Pending";
        }

        public void CalculateTotal()
        {
            double total = 0;
            foreach (OrderItem oi in Items)
            {
                total += oi.GetSubTotal();
            }
            TotalAmount = total + 5.0; // delivery fee
        }
    }
}