using Food_delivery;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject_Food_delivery
{
    namespace Food_delivery.Tests
    {
        [TestClass]
        public class DeliveryTest
        {
            private Delivery _delivery;

            [TestInitialize]
            public void Setup()
            {
                _delivery = new Delivery();
            }
            // перевірка отримання адреси доставки
            [TestMethod]
            public void GetAddress_ShouldFail()
            {
                Assert.Fail("Test not implemented");
            }
            // перевірка встановлення адреси
            [TestMethod]
            public void SetAddress_ShouldFail()
            {
                Assert.Fail("Test not implemented");
            }
            // оновлення адреси
            [TestMethod]
            public void UpdateDeliveryAddress_ShouldFail()
            {
                string newAddress = "123 New Street";
                                
                Assert.Fail("Test not implemented");
            }
        }
    }
}