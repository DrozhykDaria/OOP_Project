using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food_delivery
{
    public class FoodItem
    {
        private string _name;
        private string _description;
        private decimal _price;
        private List<string> _ingredients;
        public FoodItem()
        {
            _ingredients = new List<string>();
        }
        public FoodItem(string name, string description, decimal price) : this()
        {
           _name = name;
           _description = description;
           _price = price;
        }
        public string GetName()
        {
            return _name;
        }
        public string GetDescription()
        {
            return _description;
        }
        public string GetPrice()
        {
            return _price.ToString("0.00");
        }
        public bool AddIngredient(string ingredient)
        {
            if (string.IsNullOrWhiteSpace(ingredient)) return false;

            _ingredients.Add(ingredient);
            return true;
        }
        // метод для отримання списку інгредієнтів
        public List<string> GetIngredients()
        {
            return new List<string>(_ingredients);
        }
    }
}
