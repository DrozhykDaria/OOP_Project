using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food_delivery
{
    public class Admin
    {
        public string Role { get; } = "Адміністратор";

        public bool ManageUsers(List<Customer> users)
        {
            throw new NotImplementedException();
        }

        public bool ManageMenu(List<FoodItem> items)
        {
            throw new NotImplementedException();
        }
    }
}
