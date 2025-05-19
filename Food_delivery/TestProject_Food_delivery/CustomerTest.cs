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
        private Customer _customer = null!;

        [TestInitialize]
        public void Setup()
        {
            _customer = new Customer
            {
                Email = "test@example.com",
                Password = "password123",
                FirstName = "Іван",
                LastName = "Іванов",
                BirthDate = new DateTime(1990, 1, 1),
                Phone = "+380123456789"
            };
        }
        // перевірка емейлу
        [TestMethod]
        public void GetEmail_ShouldReturnCorrectEmail()
        {
            var expected = "test@example.com";
            var actual = _customer.Email;
            Assert.AreEqual(expected, actual);
        }
        // перевірка ім'я клієнта
        [TestMethod]
        public void GetFirstName_ShouldReturnCorrectFirstName()
        {
            var expected = "Іван";
            var actual = _customer.FirstName;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetLastName_ShouldReturnCorrectLastName()
        {
            var expected = "Іванов";
            var actual = _customer.LastName;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetBirthDate_ShouldReturnCorrectBirthDate()
        {
            var expected = "01.01.1990";
            var actual = _customer.BirthDate.ToString("dd.MM.yyyy");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetPhone_ShouldReturnCorrectPhone()
        {
            var expected = "+380123456789";
            var actual = _customer.Phone;
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