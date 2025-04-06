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
                _foodItem = new FoodItem();
            }
        // перевірка назви страви
        [TestMethod]
            public void GetName_ShouldFail()
            {
                Assert.Fail("Test not implemented");
            }
        //опис страви
        [TestMethod]
            public void GetDescription_ShouldFail()
            {
                Assert.Fail("Test not implemented");
            }
        // перевірка ціни страви
        [TestMethod]
            public void GetPrice_ShouldFail()
            {
                Assert.Fail("Test not implemented");
            }
        //додавання інгредієнта до страви 
        [TestMethod]
            public void AddIngredient_ShouldFail()
            {
                string ingredient = "Cheese";

                Assert.Fail("Test not implemented");
            }
        }
}
