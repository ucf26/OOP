using System;
using System.Collections.Generic;
using System.Text;

namespace _04_Restaurant_Order_System.Entities
{
    internal class MenuItem
    {
        public string ItemId { get; }
        public string  Name { get; }
        public string Description { get; }
        public double Price { get; }
        public ItemCategory Category { get; }
        public bool IsAvailable { get; set; }
        

        public MenuItem(string itemid, string name, string description, double price, ItemCategory category)
        {
            ItemId = itemid;
            Name = name;
            Description = description;
            Price = price;
            Category = category;
            IsAvailable = true;
        }
        public string GetItemInfo()
        {
            return $"- {Name}: {Description} - ${Price:f2}";
        }

    }

    enum ItemCategory
    {
        Appetizer, 
        MainCourse, 
        Dessert, 
        Beverage
    }
}
