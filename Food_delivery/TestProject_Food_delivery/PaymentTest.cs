using Food_delivery;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject_Food_delivery
{
    [TestClass]
    public class PaymentTest
    {
        private Payment _payment;

        [TestInitialize]
        public void Setup()
        {
            _payment = new Payment();
        }

        // отримання статусу платежу
        [TestMethod]
        public void GetStatus_ShouldFail()
        {
            Assert.Fail("Test not implemented");
        }

        // перевірки встановлення статусу платежу
        [TestMethod]
        public void SetStatus_ShouldFail()
        {
            Assert.Fail("Test not implemented");
        }

        // перевірки процесу обробки платежу
        [TestMethod]
        public void ProcessPayment_ShouldFail()
        {
            decimal amount = 100.50m;
            string paymentMethod = "Credit Card";

            Assert.Fail("Test not implemented");
        }

        [TestMethod]
        public void IPayment_ProcessPayment_ShouldFail()
        {
            IPayment payment = _payment;
            decimal amount = 200.00m;
            string paymentMethod = "PayPal";

            Assert.Fail("Test not implemented");
        }
    }
}
