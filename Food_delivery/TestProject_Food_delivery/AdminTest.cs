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
            var result = _admin.ManageUsers(users);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ManageUsers_ShouldReturnFalse_WhenListIsEmpty()
        {
            var users = new List<Customer>();
            var result = _admin.ManageUsers(users);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ManageUsers_ShouldReturnTrue_WhenListHasUsers()
        {
            var users = new List<Customer> { new Customer() };
            var result = _admin.ManageUsers(users);
            Assert.IsTrue(result);
        }

        // перевірка управління меню
        // Тест перевіряє, що метод повертає false при пустому списку страв
        [TestMethod]
        public void ManageMenu_ShouldReturnFalse_WhenListIsEmpty()
        {
            var items = new List<FoodItem>();
            var result = _admin.ManageMenu(items);
            Assert.IsFalse(result);
        }

        // Тест перевіряє, що метод повертає true при наявності страв
        [TestMethod]
        public void ManageMenu_ShouldReturnTrue_WhenListHasItems()
        {
            var items = new List<FoodItem> { new FoodItem() };
            var result = _admin.ManageMenu(items);
            Assert.IsTrue(result);
        }
        // тестовий клас для клієнтів
        [TestClass]
        public class CustomerTests
        {
            // Тест перевіряє методи клієнта
            [TestMethod]
            public void Customer_Creation_ShouldSucceed()
            {
                var customer = new Customer();
                Assert.IsNotNull(customer);
            }
        }
        // тестовий клас для страв
        [TestClass]
        public class FoodItemTests
        {
            // перевірка методів для страв
            [TestMethod]
            public void FoodItem_Creation_ShouldSucceed()
            {
                var item = new FoodItem();
                Assert.IsNotNull(item);
            }
        }
    }
}