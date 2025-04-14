namespace Food_delivery
{
    public interface IOrderProcessor
    {
        void ProcessOrder(string orderNumber, string status);
    }
}