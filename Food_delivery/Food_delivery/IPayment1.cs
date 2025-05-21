namespace Food_delivery
{
    public interface IPayment
    {
        void ProcessPayment(decimal amount, string paymentMethod);
    }

    // оплата карткою
    public class CardPayment : IPayment
    {
        public void ProcessPayment(decimal amount, string paymentMethod)
        {
            Console.WriteLine($" Оплата карткою: {amount:C}");
        }
    }

    //  оплата готівкою
    public class CashPayment : IPayment
    {
        public void ProcessPayment(decimal amount, string paymentMethod)
        {
            Console.WriteLine($" Оплата готівкою: {amount:C}");
        }
    }
    public class PaymentProcessor : IPayment
    {
        public void ProcessPayment(decimal amount, string paymentMethod)
        {
            Console.WriteLine($"Оплата {amount:C} через {paymentMethod}");
        }
    }
}