//==========================================================
// Student 1: Bryan (S10275435F)
// Student 2: Kyran (S10275200K)
//==========================================================

using S10275435_PRG2Assignment;
using System.Collections.Generic;

public class Customer
{
    public string Name { get; set; }
    public string Email { get; set; }

    public List<Order> OrderList { get; set; }

    public Customer(string name, string email)
    {
        Name = name;
        Email = email;
        OrderList = new List<Order>();
    }

    public override string ToString()
    {
        return $"{Name} ({Email})";
    }
}