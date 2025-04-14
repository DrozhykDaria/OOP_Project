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
        public void GetEmail_ShouldReturnCorrectEmail()
        {
            var expected = "test@example.com";
            var actual = _customer.GetEmail();
            Assert.AreEqual(expected, actual);
        }
        // перевірка ім'я клієнта
        [TestMethod]
        public void GetFirstName_ShouldReturnCorrectFirstName()
        {
            var expected = "Іван";
            var actual = _customer.GetFirstName();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetLastName_ShouldReturnCorrectLastName()
        {
            var expected = "Іванов";
            var actual = _customer.GetLastName();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetBirthDate_ShouldReturnCorrectBirthDate()
        {
            var expected = "01.01.1990";
            var actual = _customer.GetBirthDate();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetPhone_ShouldReturnCorrectPhone()
        {
            var expected = "+380123456789";
            var actual = _customer.GetPhone();
            Assert.AreEqual(expected, actual);
        }
        //перевірка аутентифікації клієнта
        [TestMethod]
        public void Authenticate_ShouldReturnTrue_WhenCredentialsAreCorrect()
        {
            var result = _customer.Authenticate("test@example.com", "password123");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CheckStatus_ShouldReturnFalse_WhenCredentialsAreWrong()
        {
            var result = _customer.Authenticate("wrong@example.com", "wrongpass");
            Assert.IsFalse(result);
        }
    }
}