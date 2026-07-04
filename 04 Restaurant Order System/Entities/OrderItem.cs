using System;
using System.Collections.Generic;
using System.Text;

namespace _04_Restaurant_Order_System.Entities
{
    internal class OrderItem
    {
        public MenuItem MenuItem { get; set; }
        public int Quantity { get; set; }
        public string SpecialInstructions { get; set; }
        public OrderItem(MenuItem item, int quantity, string specialinstructions)
        {
            MenuItem = item;
            Quantity = quantity;
            SpecialInstructions = specialinstructions;
        }

        public double GetSubtotal()
        {
            return MenuItem.Price * Quantity;
        }

        public string GetOrderItemDetails()
        {
            return $"";
        }
    }
}
