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
            throw new NotImplementedException();
        }

        public bool RemoveFoodItem(string itemName)
        {
            throw new NotImplementedException();
        }
    }
}
