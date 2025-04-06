using Food_delivery;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject_Food_delivery
{
        [TestClass]
        public class CustomerTest
        {
            private Customer _customer;

            [TestInitialize]
            public void Setup()
            {
                _customer = new Customer();
            }
        // перевірка емейлу
            [TestMethod]
            public void GetEmail_ShouldFail()
            {
                Assert.Fail("Test not implemented");
            }
        // перевірка ім'я клієнта
            [TestMethod]
            public void GetFirstName_ShouldFail()
            {
                Assert.Fail("Test not implemented");
            }

            [TestMethod]
            public void GetLastName_ShouldFail()
            {
                Assert.Fail("Test not implemented");
            }

            [TestMethod]
            public void GetBirthDate_ShouldFail()
            {
                Assert.Fail("Test not implemented");
            }

            [TestMethod]
            public void GetPhone_ShouldFail()
            {
                Assert.Fail("Test not implemented");
            }
        //перевірка аутентифікації клієнта
        [TestMethod]
            public void Authenticate_ShouldFail()
            {
                // Arrange
                string email = "test@example.com";
                string password = "password123";

                // Act & Assert
                Assert.Fail("Test not implemented");
            }

            [TestMethod]
            public void CheckStatus_ShouldFail()
            {
                Assert.Fail("Test not implemented");
            }
        }
}