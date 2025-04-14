using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food_delivery
{
    public class Order
    {
        private string _orderNumber;
        public DateTime CreatedDate { get; } = DateTime.Now;
        private string _status;
        private List<FoodItem> _items;
        private string _address;
        public Order()
        {
            _orderNumber = GenerateOrderNumber();
            _status = "New";
            _items = new List<FoodItem>();
        }
        public string GetOrderNumber()
        {
            return _orderNumber;
        }
        public string GetCreatedDate()
        {
            return CreatedDate.ToString("yyyy-MM-dd HH:mm:ss");
        }
        public string GetStatus()
        {
            return _status;
        }
        public bool PlaceOrder(List<FoodItem> items, string address)
        {
            if (items == null || items.Count == 0 || string.IsNullOrWhiteSpace(address))
                return false;

            _items = new List<FoodItem>(items);
            _address = address;
            _status = "Placed";

            return true;
        }

        public bool CancelOrder(string orderNumber)
        {
            if (orderNumber != _orderNumber)
                return false;

            _status = "Canceled";
            return true;
        }

        public bool UpdateOrderStatus(string orderNumber, string newStatus)
        {
            if (orderNumber != _orderNumber || string.IsNullOrWhiteSpace(newStatus))
                return false;

            _status = newStatus;
            return true;
        }
        private string GenerateOrderNumber()
        {
            return "ORD" + new Random().Next(1000, 9999);
        }
    }
}
