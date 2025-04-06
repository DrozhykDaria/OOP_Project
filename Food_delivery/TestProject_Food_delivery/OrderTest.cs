using Food_delivery;
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
        public void GetOrderNumber_ShouldFail()
        {
            Assert.Fail("Test not implemented");
        }

        // отримання дати створення замовлення
        [TestMethod]
        public void GetCreatedDate_ShouldFail()
        {
            Assert.Fail("Test not implemented");
        }

        
        [TestMethod]
        public void GetStatus_ShouldFail()
        {
            Assert.Fail("Test not implemented");
        }

        // перевірка оформлення замовлення
        [TestMethod]
        public void PlaceOrder_ShouldFail()
        {
            var items = new List<FoodItem>();
            string address = "123 Main Street";

            Assert.Fail("Test not implemented");
        }

        // скасування замовлення
        [TestMethod]
        public void CancelOrder_ShouldFail()
        {
            string orderNumber = "ORD123";

            Assert.Fail("Test not implemented");
        }

        [TestMethod]
        public void UpdateOrderStatus_ShouldFail()
        {
            string orderNumber = "ORD123";
            string newStatus = "Shipped";

            Assert.Fail("Test not implemented");
        }
    }
}
