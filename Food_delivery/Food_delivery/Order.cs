using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food_delivery
{
    public class Order
    {
        private string OrderNumber;
        public DateTime CreatedDate { get; } = DateTime.Now;
        private string Status;
        public string GetOrderNumber()
        {
            throw new NotImplementedException();
        }
        public string GetCreatedDate()
        {
            throw new NotImplementedException();
        }
        public string GetStatus()
        {
            throw new NotImplementedException();
        }
        public bool PlaceOrder(List<FoodItem> items, string address)
        {
            throw new NotImplementedException();
        }

        public bool CancelOrder(string orderNumber)
        {
            throw new NotImplementedException();
        }

        public bool UpdateOrderStatus(string orderNumber, string newStatus)
        {
            throw new NotImplementedException();
        }
    }
}
