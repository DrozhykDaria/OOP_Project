
using Food_delivery;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject_Food_delivery
{
    [TestClass]
    public class IPaymentTest
    {
        private IPayment _payment;

        [TestInitialize]
        public void Setup()
        {
            _payment = new PaymentProcessor();
        }

        // перевірка процесу оплати
        [TestMethod]
        public void ProcessPayment_ShouldCallMethodOnce()
        {
            decimal amount = 100.50m;
            string method = "Credit Card";
            string expectedMessage = $"Payment of {amount:C} made using {method}";

            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                _payment.ProcessPayment(amount, method);

                string actual = sw.ToString().Trim();
                Assert.AreEqual(expectedMessage, actual);
            }
        }
    }
}
