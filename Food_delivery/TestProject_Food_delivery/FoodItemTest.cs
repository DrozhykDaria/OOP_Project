using Food_delivery;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject_Food_delivery
{
    [TestClass]
        public class FoodItemTest
        {
            private FoodItem _foodItem;

            [TestInitialize]
            public void Setup()
            {
                _foodItem = new FoodItem("Pizza", "Delicious cheese pizza", 120.50m);
            }
        // перевірка назви страви
        [TestMethod]
            public void GetName_ShouldReturnCorrectName()
            {
                var result = _foodItem.GetName();
                Assert.AreEqual("Pizza", result);
            }
        //опис страви
        [TestMethod]
            public void GetDescription_ShouldReturnCorrectDescription()
            {
                var result = _foodItem.GetDescription();
                Assert.AreEqual("Delicious cheese pizza", result);
            }
        // перевірка ціни страви
        [TestMethod]
            public void GetPrice_ShouldReturnFormattedPrice()
            {
                var result = _foodItem.GetPrice();
                Assert.AreEqual("120,50", result);
            }
        //додавання інгредієнта до страви 
        [TestMethod]
            public void AddIngredient_ShouldAddIngredientSuccessfully()
            {
                string ingredient = "Cheese";
                var added = _foodItem.AddIngredient(ingredient);
                var ingredients = _foodItem.GetIngredients();

                Assert.IsTrue(added);
                CollectionAssert.Contains(ingredients, ingredient);
            }
        }
}
