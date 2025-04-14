namespace Food_delivery
{
    public interface IPayment
    {
        void ProcessPayment(decimal amount, string paymentMethod);
    }
}