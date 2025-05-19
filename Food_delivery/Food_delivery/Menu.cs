using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food_delivery
{
    public class Menu
    {
        public ObservableCollection<FoodItem> Items { get; private set; } = new ObservableCollection<FoodItem>();

        public Menu()
        {
            Items = new ObservableCollection<FoodItem>();
        }
        public bool AddFoodItem(FoodItem item)
        {
            if (item == null || Items.Contains(item))
                return false;

            Items.Add(item);
            return true;
        }

        public void RemoveFoodItem(FoodItem item)
        {
            if (item != null && Items.Contains(item))
                Items.Remove(item);
        }
    }
}