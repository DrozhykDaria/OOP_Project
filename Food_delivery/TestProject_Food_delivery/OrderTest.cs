﻿using Food_delivery;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject_Food_delivery
{
    [TestClass]
    public class OrderTest
    {
        private Order _order;

        [TestInitialize]
        public void Setup()
        {
            _order = new Order();
        }

        // отримання номера замовлення
        [TestMethod]
        public void GetOrderNumber_ShouldReturnOrderNumber()
        {
            var result = _order.GetOrderNumber();
            Assert.IsTrue(result.StartsWith("ORD"));
            Assert.AreEqual(7, result.Length); 
        }

        // отримання дати створення замовлення
        [TestMethod]
        public void GetCreatedDate_ShouldReturnCreatedDate()
        {
            var result = _order.GetCreatedDate();
            DateTime createdDate = DateTime.Parse(result);
            Assert.IsTrue(createdDate <= DateTime.Now);
        }


        [TestMethod]
        public void GetStatus_ShouldReturnInitialStatus()
        {
            var result = _order.GetStatus();
            Assert.AreEqual("New", result);
        }

        // перевірка оформлення замовлення
        [TestMethod]
        public void PlaceOrder_ShouldPlaceOrderSuccessfully()
        {
            var items = new List<FoodItem>
            {
                new FoodItem("Pizza", "Delicious pizza", 10.99m),
                new FoodItem("Burger", "Tasty beef burger", 5.99m)
            };
            string address = "123 Main Street";
            var result = _order.PlaceOrder(items, address);

            Assert.IsTrue(result);
            Assert.AreEqual("Placed", _order.GetStatus());
        }

        // скасування замовлення
        [TestMethod]
        public void CancelOrder_ShouldFailIfItemsOrAddressInvalid()
        {
            var result = _order.PlaceOrder(null, "123 Main Street");
            Assert.IsFalse(result);

            result = _order.PlaceOrder(new List<FoodItem>(), "123 Main Street");
            Assert.IsFalse(result);
            result = _order.PlaceOrder(new List<FoodItem> { new FoodItem("Pizza", "Delicious pizza", 10.99m) }, ""); // Порожня адреса
            Assert.IsFalse(result);
        }
        // скасування замовлення
        [TestMethod]
        public void UpdateOrderStatus_ShouldCancelOrderSuccessfully()
        {
            string orderNumber = _order.GetOrderNumber();
            var result = _order.CancelOrder(orderNumber);
            Assert.IsTrue(result);
            Assert.AreEqual("Canceled", _order.GetStatus());
        }
    }
}
