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
        public void AddFoodItem_ShouldFail()
        {
            var foodItem = new FoodItem();

            Assert.Fail("Test not implemented");
        }
        // перевірка видалення страви з меню
        [TestMethod]
        public void RemoveFoodItem_ShouldFail()
        {
            string itemName = "Pizza";

            Assert.Fail("Test not implemented");
        }
    }
}
