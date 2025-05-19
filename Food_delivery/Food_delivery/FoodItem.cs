using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food_delivery
{
    public class FoodItem
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        private List<string> _ingredients;

        public FoodItem()
        {
            _ingredients = new List<string>();
        }

        public FoodItem(string name, string description, decimal price) : this()
        {
            Name = name;
            Description = description;
            Price = price;
        }

        public bool AddIngredient(string ingredient)
        {
            if (string.IsNullOrWhiteSpace(ingredient)) return false;

            _ingredients.Add(ingredient);
            return true;
        }

        public List<string> GetIngredients()
        {
            return new List<string>(_ingredients);
        }

        public string GetPrice()
        {
            return Price.ToString("0.00");
        }

        public decimal GetPriceAsDecimal()
        {
            return Price;
        }

        public override string ToString() => $"{Name} - {Price} грн";
    }

}