using Food_delivery;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject_Food_delivery
{
        [TestClass]
        public class AdminTest
        {
            private Admin _admin;

            [TestInitialize]
            public void Setup()
            {
                _admin = new Admin();
            }
        // тест перевіряє управління користувачами
        [TestMethod]
            public void ManageUsers_ShouldFail()
            {
                var users = new List<Customer>();

                Assert.Fail("Test not implemented");
            }
        // перевірка управління меню
        [TestMethod]
            public void ManageMenu_ShouldFail()
            {
                
                var items = new List<FoodItem>();

                Assert.Fail("Test not implemented");
            }
        }
        // тестовий клас для клієнтів
        [TestClass]
        public class CustomerTests
        {
        // Тест перевіряє методи клієнта
        [TestMethod]
            public void CustomerMethod_ShouldFail()
            {
                Assert.Fail("Test not implemented");
            }
        }
        // тестовий клас для страв
        [TestClass]
        public class FoodItemTests
        {
        // перевірка методів для страв
        [TestMethod]
            public void FoodItemMethod_ShouldFail()
            {
                Assert.Fail("Test not implemented");
            }
        }
}