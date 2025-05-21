using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food_delivery
{
    public class Order
    {
        public string OrderNumber { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public string Status { get; set; } = "New";
        public List<FoodItem> Items { get; set; } = new List<FoodItem>();
        public string Address { get; set; }
        public Order()
        {
            OrderNumber = GenerateOrderNumber();
        }

        public bool PlaceOrder(List<FoodItem> items, string address)
        {
            if (items == null || items.Count == 0 || string.IsNullOrWhiteSpace(address))
                return false;

            Items = new List<FoodItem>(items);
            Address = address;
            Status = "Placed";

            return true;
        }

        public bool CancelOrder(string orderNumber)
        {
            if (orderNumber != OrderNumber)
                return false;

            Status = "Canceled";
            return true;
        }

        public bool UpdateOrderStatus(string orderNumber, string newStatus)
        {
            if (orderNumber != OrderNumber || string.IsNullOrWhiteSpace(newStatus))
                return false;

            Status = newStatus;
            return true;
        }

        private string GenerateOrderNumber()
        {
            return "ORD-" + Guid.NewGuid().ToString().Substring(0, 8).ToUpper();
        }

    }
}