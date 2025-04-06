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
        private Mock<IOrderProcessor> _mockOrderProcessor;

        [TestInitialize]
        public void Setup()
        {
            _mockOrderProcessor = new Mock<IOrderProcessor>();
        }
        // перевірка обробки замовлення
        [TestMethod]
        public void ProcessOrder_ShouldFail()
        {
            string orderNumber = "12345";
            string status = "Processing";

            Assert.Fail("Test not implemented");
        }
    }

    internal class Mock<T>
    {
    }
}
