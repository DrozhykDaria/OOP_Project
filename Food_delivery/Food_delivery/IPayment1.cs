namespace Food_delivery
{
    public interface IPayment
    {
        void ProcessPayment(decimal amount, string paymentMethod);
    }

    // Реалізація оплати карткою
    public class CardPayment : IPayment
    {
        public void ProcessPayment(decimal amount, string paymentMethod)
        {
            Console.WriteLine($"💳 Оплата карткою: {amount:C}");
        }
    }

    // Реалізація оплати готівкою
    public class CashPayment : IPayment
    {
        public void ProcessPayment(decimal amount, string paymentMethod)
        {
            Console.WriteLine($"💵 Оплата готівкою: {amount:C}");
        }
    }

    // Реалізація оплати через сервіс (універсальний варіант)
    public class PaymentProcessor : IPayment
    {
        public void ProcessPayment(decimal amount, string paymentMethod)
        {
            Console.WriteLine($"Оплата {amount:C} через {paymentMethod}");
        }
    }
}