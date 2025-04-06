
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
        private Mock<IPayment> _mockPayment;

        [TestInitialize]
        public void Setup()
        {
            _mockPayment = new Mock<IPayment>();
        }

        // перевірка процесу оплати
        [TestMethod]
        public void ProcessPayment_ShouldFail()
        {
            decimal amount = 100.50m;
            string paymentMethod = "Credit Card";

            Assert.Fail("Test not implemented");
        }
    }
}
