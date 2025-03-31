using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food_delivery
{
    public class Payment : IPayment
    {
        public string Status { get; set; }

        public bool ProcessPayment(decimal amount, string paymentMethod)
        {
            throw new NotImplementedException();
        }

        void IPayment.ProcessPayment(decimal amount, string paymentMethod)
        {
            throw new NotImplementedException();
        }
    }
}
