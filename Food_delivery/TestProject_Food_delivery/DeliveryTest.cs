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
            public void GetAddress_ShouldReturnCorrectAddress()
            {
                _delivery.SetAddress("Test Street 1");
                var result = _delivery.GetAddress();
                Assert.AreEqual("Test Street 1", result);
            }
            // перевірка встановлення адреси
            [TestMethod]
            public void SetAddress_ShouldSetAddressCorrectly()
            {
                _delivery.SetAddress("Main Street 42");
                Assert.AreEqual("Main Street 42", _delivery.GetAddress());
            }
            // оновлення адреси(коректне)
            [TestMethod]
            public void UpdateDeliveryAddress_ShouldReturnTrue_WhenValidAddress()
            {
                var result = _delivery.UpdateDeliveryAddress("123 New Street");
                Assert.IsTrue(result);
                Assert.AreEqual("123 New Street", _delivery.GetAddress());
            }
            // оновлення адреси(невдале)
            public void UpdateDeliveryAddress_ShouldReturnFalse_WhenAddressIsInvalid()
            {
                var result = _delivery.UpdateDeliveryAddress("  ");
                Assert.IsFalse(result);
            }
        }
    }
}