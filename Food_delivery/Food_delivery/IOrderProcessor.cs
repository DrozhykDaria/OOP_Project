using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food_delivery
{
    public class OrderProcessor : IOrderProcessor
    {
        public void ProcessOrder(string orderNumber, string status)
        {
            Console.WriteLine($"Order {orderNumber} is now {status}");
            // Тут можна додати логіку оновлення бази даних, надсилання повідомлень тощо
        }
    }
}
