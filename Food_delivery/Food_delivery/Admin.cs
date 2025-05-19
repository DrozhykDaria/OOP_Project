using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food_delivery
{
    public class Admin : User
    {
        public string Role { get; } = "Адміністратор";

        public override bool Authenticate(string email, string password)
        {
            return email == Email && password == Password;
        }

        public bool ManageUsers(List<Customer> users)
        {
            return users != null && users.Count > 0;
        }

        public bool ManageMenu(List<FoodItem> items)
        {
            return items != null && items.Count > 0;
        }
    }
}
