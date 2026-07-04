using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace _04_Restaurant_Order_System.Entities
{
    internal class Order
    {
        public string  OrderId { get; set; }
        public int TableNumber { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        public DateTime OrderTime { get; set; }
        public OrderStatus Status { get; set; }

        public Order(string orderid, int tablenumber, DateTime date, OrderStatus status)
        {
            OrderId = orderid;
            TableNumber = tablenumber;
            OrderTime = date;
            Status = status;
        }

        //addItem(menuItem, quantity, instructions) : Adds item to order
        public void AddItem(MenuItem item, int quantity, string specialinstructions)
        {
            OrderItems.Add(new OrderItem(item, quantity, specialinstructions));
        }

        //removeItem(itemId): Removes item from order
        public void RemoveItem(string id)
        {
            foreach(OrderItem item in OrderItems)
            {
                if(item.MenuItem.ItemId == id)
                {
                    OrderItems.Remove(item);
                    break;
                }
            }
        }

        //getSubtotal(): Sum of all order items
        public double GetSubTotal()
        {
            double total = 0;
            foreach(OrderItem item in OrderItems)
            {
                total += item.GetSubtotal();
            }
            return total;
        }

        //getTax(): Calculate tax(e.g., 8% of subtotal)
        public double GetTax()
        {
            return 0.8 * GetSubTotal();
        }

        //getTotal() : Subtotal + tax
        public double GetTotal()
        {
            return GetSubTotal() + GetTax(); 
        }

        //calculateTip(percentage): Calculate tip based on percentage
        public double CalculateTip(int percentage)
        {
            return percentage * GetTotal() / 100;
        }
        
        //updateStatus(newStatus): Updates order status
        public void GetStatus(OrderStatus newstatus)
        {
            Status = newstatus;
        }

        //getOrderSummary(): Returns formatted order details
        public string GetOrderSummary()
        {
            return $"";
        }
        
    }

    enum OrderStatus
    {
        Pending,
        Preparing,
        Ready,
        Served,
        Completed
    }
}
