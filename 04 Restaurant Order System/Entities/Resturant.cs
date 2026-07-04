using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace _04_Restaurant_Order_System.Entities
{
    internal class Resturant
    {
        public string Name { get; set; }
        public Menu Menu { get; set; }
        public List<Order> Orders { get; set; }
        public double TaxRate { get; set; }

        private int _orderscount = 0;
        public Resturant(string name, double taxrate)
        {
            Name = name;
            TaxRate = taxrate;
        }

        //createOrder(tableNumber) : Creates a new order
        public void CreateOrder(int tablenumber)
        {
            Orders.Add(new Order($"ORD:{_orderscount:D3}",tablenumber, DateTime.Now, OrderStatus.Pending));
        }

        //getOrder(orderId): Finds and returns an order
        public Order GetOrder(string orderid)
        {
            return Orders.FirstOrDefault(o => o.OrderId == orderid);
        }

        //getOrdersByStatus(status): Returns filtered orders
        public List<Order> GetOrdersByStatus(OrderStatus status)
        {
            return Orders.Where(o=> o.Status == status).ToList();
        }
        

        //getActiveOrders(): Returns all non - completed orders
        public List<Order> GetActiveOrders()
        {
            return Orders.Where(o => o.Status != OrderStatus.Completed).ToList();
        }
        
        //completeOrder(orderId): Marks order as completed
        public void CompleteOrder(string orderid)
        {
            foreach(Order o in Orders)
            {
                if (o.OrderId == orderid)
                {
                    o.Status = OrderStatus.Completed;
                    return;
                }
            }
        }
        //getTotalRevenue(): Sum of all completed orders
        public double GetTotalRevenue()
        {
            return Orders.Sum(o => o.GetTotal());
        }

        //getPopularItems(count): Returns most ordered items
        public List<(MenuItem, int)> GetPopularItems(int count)
        {
            var MostPopularItems = Orders
                .SelectMany(Os => Os.OrderItems)
                .GroupBy(oi => oi.MenuItem.ItemId)
                .Select(g => (g.First().MenuItem, g.Sum(i => i.Quantity)))
                .ToList();
            return MostPopularItems;
        }
    }
}
