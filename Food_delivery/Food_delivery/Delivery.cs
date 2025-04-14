using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food_delivery
{
    public class Delivery
    {
        public string Address { get; set; }
        public string GetAddress()
        {
            return Address;
        }

        public void SetAddress(string address)
        {
            if (!string.IsNullOrWhiteSpace(address))
            {
                Address = address;
            }
        }

        public bool UpdateDeliveryAddress(string newAddress)
        {
            if (string.IsNullOrWhiteSpace(newAddress))
            {
                return false; // не приймаємо порожні чи некор. адреси
            }

            Address = newAddress;
            return true;
        }
    }
}
