using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food_delivery
{
    public abstract class User : IAuthenticable
    {
        public static int Counter = 0;
        public int Id { get; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Phone { get; set; }

        public User()
        {
            Id = ++Counter;
        }
        public abstract bool Authenticate(string email, string password);
    }
}