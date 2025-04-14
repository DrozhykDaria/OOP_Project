using Food_delivery;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject_Food_delivery
{
    [TestClass]
    public class OrderProcessorTest
    {
        private IOrderProcessor _orderProcessor;

        [TestInitialize]
        public void Setup()
        {
            _orderProcessor = new OrderProcessor();
        }
        // перевірка обробки замовлення
        [TestMethod]
        public void ProcessOrder_ShouldOutputCorrectMessage()
        {
            string orderNumber = "12345";
            string status = "Processing";
            string expected = $"Order {orderNumber} is now {status}";

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);

                _orderProcessor.ProcessOrder(orderNumber, status);

                string actual = sw.ToString().Trim();
                Assert.AreEqual(expected, actual);
            }
        }
    }
}
