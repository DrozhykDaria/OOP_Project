using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food_delivery
{
    public class CartItem
    {
        public FoodItem Item { get; set; }
        public int Quantity { get; set; }

        public decimal TotalPrice => Item != null ? Item.GetPriceAsDecimal() * Quantity : 0;
    }

    public class Cart
    {
        public List<CartItem> Items { get; private set; } = new();

        // 🔸 Делегат для події
        public delegate void ItemAddedEventHandler(object sender, CartItem newItem);

        // 🔸 Подія, що буде викликатись при додаванні елемента
        public event ItemAddedEventHandler ItemAdded;

        public void AddItem(FoodItem item, int quantity = 1)
        {
            var existing = Items.FirstOrDefault(i => i.Item.Name == item.Name);
            if (existing != null)
            {
                existing.Quantity += quantity;

                // 🔸 Подія також викликається при оновленні кількості
                ItemAdded?.Invoke(this, existing);
            }
            else
            {
                var newItem = new CartItem { Item = item, Quantity = quantity };
                Items.Add(newItem);

                ItemAdded?.Invoke(this, newItem);
            }
        }

        public decimal GetTotal()
        {
            return Items.Sum(i => i.TotalPrice);
        }

        public void Clear()
        {
            Items.Clear();
        }
    }
}
