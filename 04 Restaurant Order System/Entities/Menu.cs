using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace _04_Restaurant_Order_System.Entities
{
    internal class Menu
    {
        public string ResturantName { get; set; }
        public List<MenuItem> MenuItems { get; set; }

        public Menu(string resturantname)
        {
            ResturantName = resturantname;
            MenuItems = new List<MenuItem>();
        }

        //addMenuItem(item) : Adds item to menu

        public void AddItem(MenuItem item)
        {
            MenuItems.Add(item);
        }

        //removeMenuItem(itemId): Removes item from menu
        public void RemoveItem(string id)
        {
            foreach (MenuItem item in MenuItems)
            {
                if (item.ItemId == id)
                {
                    MenuItems.Remove(item);
                    break;
                }
            }
        }

        //getItemsByCategory(category): Returns items in specific category
        public List<MenuItem> GetItemsByCategory(ItemCategory category)
        {
            List<MenuItem> categorizeditems = new List<MenuItem>();
            foreach(MenuItem item in MenuItems)
            {
                if(item.Category == category)
                    categorizeditems.Add(item);
            }
            return categorizeditems;
        }

        //searchItems(keyword): Search items by name
        public MenuItem SearchItem(string id)
        {
            foreach(MenuItem item in MenuItems)
            {
                if(item.ItemId == id)
                {
                    return item;
                }
            }
            return null;
        }
        //displayMenu(): Shows all available menu items organized by category
        public void DisplayMenu()
        {
            foreach(var category in Enum.GetValues<ItemCategory>())
            {
                Console.WriteLine(category);
                foreach(var item in MenuItems)
                {
                    Console.WriteLine(item.GetItemInfo());
                }
            }
        }

    }
}
