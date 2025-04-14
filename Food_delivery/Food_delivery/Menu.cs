using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food_delivery
{
    public class Menu
    {
        public List<FoodItem> Items { get; set; } = new List<FoodItem>();

        public bool AddFoodItem(FoodItem item)
        {
            if (item == null || Items.Contains(item))
                return false;

            Items.Add(item);
            return true;
        }

        public bool RemoveFoodItem(string itemName)
        {
            if (string.IsNullOrWhiteSpace(itemName))
                return false;

            var itemToRemove = Items.FirstOrDefault(i => i.GetName() == itemName);
            if (itemToRemove != null)
            {
                Items.Remove(itemToRemove);
                return true;
            }

            return false;
        }
    }
}