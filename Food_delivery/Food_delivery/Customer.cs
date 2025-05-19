using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food_delivery
{
    public class Customer : User
    {
        public bool IsAuthenticated { get; private set; } = false;

        public override bool Authenticate(string email, string password)
        {
            if (email == Email && password == Password)
            {
                IsAuthenticated = true;
                return true;
            }
            return false;
        }
        public Customer()
        {
            Email = "drozhyk@gmail.com";
            FirstName = "Дар'я";
            LastName = "Дрожик";
            BirthDate = new DateTime(1990, 1, 1);
            Phone = "+380123456789";
            Password = "1234";
            IsAuthenticated = false;
        }

        public string CheckStatus()
        {
            return IsAuthenticated ? "Користувач автентифікований" : "Користувач неавтентифікований";
        }
    }
}