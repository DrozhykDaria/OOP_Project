using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food_delivery
{
    public class Customer
    {
        private string Email;
        private string FirstName;
        private string LastName;
        private DateTime BirthDate;
        private string Phone;
        private string Password;
        private bool IsAuthenticated;
        public Customer()
        {
            // Демонстраційні значення, можна змінити на вхідні параметри або реальні дані
            Email = "test@example.com";
            FirstName = "Іван";
            LastName = "Іванов";
            BirthDate = new DateTime(1990, 1, 1);
            Phone = "+380123456789";
            Password = "password123";
            IsAuthenticated = false;
        }
        public string GetEmail()
        {
            return Email;
        }
        public string GetFirstName()
        {
            return FirstName;
        }
        public string GetLastName()
        {
            return LastName;
        }
        public string GetBirthDate()
        {
            return BirthDate.ToShortDateString();
        }
        public string GetPhone()
        {
            return Phone;
        }
        public bool Authenticate(string email, string password)
        {
            if (email == Email && password == Password)
            {
                IsAuthenticated = true;
                return true;
            }
            return false;
        }

        public string CheckStatus()
        {
            return IsAuthenticated ? "Користувач автентифікований" : "Користувач неавтентифікований";
        }
    }
}
