using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food_delivery
{
    public interface IOrderProcessor
    {
        void ProcessOrder(string orderNumber, string status);
    }

    public delegate void OrderPlacedHandler(Order order);

    public class OrderProcessor : IOrderProcessor
    {
        public event OrderPlacedHandler? OrderPlaced;

        public void ProcessOrder(string orderNumber, string status)
        {
            Console.WriteLine($"Order {orderNumber} is now {status}");

            OrderPlaced?.Invoke(new Order
            {
                OrderNumber = orderNumber,
                Status = status,
                CreatedDate = DateTime.Now
            });
        }
    }

}