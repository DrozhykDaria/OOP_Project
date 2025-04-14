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
        public void GetStatus_ShouldReturnNotStartedInitially()
        {
            var result = _payment.GetStatus();
            Assert.AreEqual("NotStarted", result);
        }

        // перевірки встановлення статусу платежу
        [TestMethod]
        public void SetStatus_ShouldUpdateStatus()
        {
            string newStatus = "Success";
            _payment.SetStatus(newStatus);

            var result = _payment.GetStatus();
            Assert.AreEqual(newStatus, result);
        }

        // перевірки процесу обробки платежу
        [TestMethod]
        public void ProcessPayment_ShouldProcessPaymentSuccessfully()
        {
            decimal amount = 100.50m;
            string paymentMethod = "Credit Card";

            var result = _payment.ProcessPayment(amount, paymentMethod);

            Assert.IsTrue(result);
            Assert.AreEqual("Success", _payment.GetStatus());
        }

        [TestMethod]
        public void IPayment_ProcessPayment_ShouldallProcessPayment()
        {
            IPayment payment = _payment;
            decimal amount = 200.00m;
            string paymentMethod = "PayPal";

            payment.ProcessPayment(amount, paymentMethod);
            Assert.AreEqual("Success", _payment.GetStatus());
        }
    }
}
