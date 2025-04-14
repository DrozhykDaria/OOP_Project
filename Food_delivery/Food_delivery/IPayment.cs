using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food_delivery
{
    public class PaymentProcessor : IPayment
    {
        public void ProcessPayment(decimal amount, string paymentMethod)
        {
            Console.WriteLine($"Payment of {amount:C} made using {paymentMethod}");
        }
    }

}