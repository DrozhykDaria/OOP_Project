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

        public Payment()
        {
            Status = "NotStarted"; // Початковий статус
        }

        // Метод для отримання статусу платежу
        public string GetStatus()
        {
            return Status;
        }

        // Метод для встановлення статусу платежу
        public void SetStatus(string status)
        {
            if (string.IsNullOrWhiteSpace(status))
            {
                throw new ArgumentException("Status cannot be null or empty.");
            }
            Status = status;
        }

        // Реалізація методу ProcessPayment для обробки платежу
        public bool ProcessPayment(decimal amount, string paymentMethod)
        {
            if (amount <= 0)
            {
                Status = "Failed";
                throw new ArgumentException("Amount must be greater than zero.");
            }

            if (string.IsNullOrWhiteSpace(paymentMethod))
            {
                Status = "Failed";
                throw new ArgumentException("Payment method cannot be null or empty.");
            }

            // Якщо всі перевірки пройшли успішно, платіж оброблено
            Status = "Success";
            return true;
        }

        // Перевизначення методу ProcessPayment згідно з інтерфейсом IPayment
        void IPayment.ProcessPayment(decimal amount, string paymentMethod)
        {
            ProcessPayment(amount, paymentMethod);  // Виклик основного методу
        }
    }
}
