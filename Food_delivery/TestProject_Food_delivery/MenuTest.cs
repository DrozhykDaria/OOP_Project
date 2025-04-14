using Food_delivery;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject_Food_delivery
{
    [TestClass]
    public class MenuTest
    {
        private Menu _menu;

        [TestInitialize]
        public void Setup()
        {
            _menu = new Menu();
        }

        // перевірка додавання страви до меню
        [TestMethod]
        public void AddFoodItem_ShouldAddItemToMenu()
        {
            var foodItem = new FoodItem("Pizza", "Delicious cheese pizza", 10.99m);
            bool result = _menu.AddFoodItem(foodItem);
            Assert.IsTrue(result); 
            Assert.AreEqual(1, _menu.Items.Count); 
            Assert.AreEqual(foodItem, _menu.Items[0]);
        }
        // перевірка видалення страви з меню
        [TestMethod]
        public void RemoveFoodItem_ShouldNotAddDuplicateItem()
        {
            var foodItem = new FoodItem("Pizza", "Delicious cheese pizza", 10.99m);
            _menu.AddFoodItem(foodItem); 
            bool result = _menu.AddFoodItem(foodItem); 
            Assert.IsFalse(result);
            Assert.AreEqual(1, _menu.Items.Count); 
        }
        /*// перевірка видалення страви з меню
        [TestMethod]
        public void RemoveFoodItem_ShouldRemoveItemFromMenu()
        {
            // Arrange
            var foodItem = new FoodItem("Pizza", "Delicious cheese pizza", 10.99m);
            _menu.AddFoodItem(foodItem); 

            // Act
            bool result = _menu.RemoveFoodItem("Pizza");

            // Assert
            Assert.IsTrue(result); 
            Assert.AreEqual(0, _menu.Items.Count); 
        }
        // пперевірка видалення страви, якої немає в меню
        [TestMethod]
        public void RemoveFoodItem_ShouldNotRemoveNonExistentItem()
        {
            bool result = _menu.RemoveFoodItem("Pizza");

            Assert.IsFalse(result); 
            Assert.AreEqual(0, _menu.Items.Count); 
        }*/
    }
}
