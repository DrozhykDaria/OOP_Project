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

        // Метод для керування користувачами
        public bool ManageUsers(List<Customer> users)
        {
            if (users == null) return false;

            // Наприклад, перевіримо, чи в списку є хоча б один користувач
            return users.Count > 0;
        }

        // Метод для керування меню
        public bool ManageMenu(List<FoodItem> items)
        {
            if (items == null) return false;

            // Аналогічно, перевіримо наявність хоча б однієї страви
            return items.Count > 0;
        }
    }
}
