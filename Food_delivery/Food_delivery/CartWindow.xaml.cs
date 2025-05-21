using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Food_delivery
{
    /// <summary>
    /// Логика взаимодействия для CartWindow.xaml
    /// </summary>
    public partial class CartWindow : Window
    {
        private readonly List<CartItem> items;
        private readonly IOrderProcessor orderProcessor;
        private readonly Customer customer;
        private readonly Menu menu;
        private readonly Cart cart;
        private readonly IPayment paymentProcessor;

        public CartWindow(List<CartItem> items, Customer customer, Menu menu, Cart cart, string paymentType = "Card")
        {
            InitializeComponent();
            this.items = items;
            this.customer = customer;
            this.menu = menu;
            this.cart = cart;
            this.orderProcessor = new OrderProcessor();
            if (this.orderProcessor is OrderProcessor processor)
            {
                processor.OrderPlaced += OnOrderPlaced;
            }

            // демонстрація поліморфізму: вибір реалізації через інтерфейс
            if (paymentType == "Cash")
                this.paymentProcessor = new CashPayment();
            else
                this.paymentProcessor = new CardPayment(); 

            CartItemsList.ItemsSource = items;
        }



        private void ConfirmOrder_Click(object sender, RoutedEventArgs e)
        {
            string address = AddressTextBox.Text;

            if (string.IsNullOrWhiteSpace(address))
            {
                MessageBox.Show("Будь ласка, введіть адресу доставки.", "Помилка", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            decimal totalAmount = items.Sum(i => i.TotalPrice);

            var paymentWindow = new PaymentWindow(totalAmount);
            paymentWindow.Owner = this;
            paymentWindow.ShowDialog();

            if (paymentWindow.PaymentSucceeded)
            {
                //  LINQ-аналітика перед створенням замовлення
                // отримати дорогі страви (понад 100 грн)
                var expensiveItems = items.Where(i => i.TotalPrice > 200).ToList();

                if (expensiveItems.Any())
                {
                    string msg = "Увага! У замовленні є дорогі позиції:\n" +
                                 string.Join("\n", expensiveItems.Select(i => $"- {i.Item.Name}: {i.TotalPrice} грн"));
                    MessageBox.Show(msg, "Попередження", MessageBoxButton.OK, MessageBoxImage.Information);
                }

                // групування за назвою і підрахунок кількості
                var groupedByName = items.GroupBy(i => i.Item.Name)
                                         .Select(g => new { Name = g.Key, Quantity = g.Sum(x => x.Quantity) });

                StringBuilder groupedInfo = new StringBuilder("Підсумок по позиціях:\n");
                foreach (var g in groupedByName)
                {
                    groupedInfo.AppendLine($"{g.Name}: {g.Quantity} шт.");
                }
                MessageBox.Show(groupedInfo.ToString(), "Зведення по замовленню");
                var foodItems = items.Select(i => i.Item).Where(f => f != null).ToList();

                var order = new Order
                {
                    Address = address,
                    Items = foodItems,
                    Status = "Placed",
                    CreatedDate = DateTime.Now
                };

                string path = "orders.json";
                List<Order> orders = new();

                if (File.Exists(path))
                {
                    string existingJson = File.ReadAllText(path);
                    if (!string.IsNullOrWhiteSpace(existingJson))
                    {
                        orders = JsonSerializer.Deserialize<List<Order>>(existingJson) ?? new();
                    }
                }

                orders.Add(order);

                var options = new JsonSerializerOptions
                {
                    WriteIndented = true,
                    Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
                };
                File.WriteAllText(path, JsonSerializer.Serialize(orders, options));

                string textPath = "orders.txt";
                var orderText = new StringBuilder();

                orderText.AppendLine("Нове замовлення:");
                orderText.AppendLine($"Номер замовлення: {order.OrderNumber}");
                orderText.AppendLine($"Дата: {order.CreatedDate}");
                orderText.AppendLine($"Адреса: {order.Address}");
                orderText.AppendLine($"Статус: {order.Status}");
                orderText.AppendLine("Страви:");

                foreach (var item in order.Items)
                {
                    orderText.AppendLine($" - {item.Name} ({item.Price} грн)");
                }

                orderText.AppendLine(new string('-', 40));
                File.AppendAllText(textPath, orderText.ToString());

                MessageBox.Show("Замовлення оформлено та збережено!", "Успіх", MessageBoxButton.OK, MessageBoxImage.Information);

                orderProcessor.ProcessOrder(order.OrderNumber, order.Status);
            }
            else
            {
                MessageBox.Show("Оплата не була завершена. Замовлення не оформлено.", "Інформація", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }


        private void OrderAgain_Click(object sender, RoutedEventArgs e)
        {
            cart.Clear(); 
            var customerWindow = new CustomerWindow(cart, customer, menu);
            customerWindow.Show();
            this.Close();
        }
        private void GoToCart_Click(object sender, RoutedEventArgs e)
        {
            var cartWindow = new CartWindow(cart.Items, customer, menu, cart);
            cartWindow.Show();
            this.Close();
        }

        private void OnOrderPlaced(Order order)
        {
            MessageBox.Show($"Подія: замовлення №{order.OrderNumber} оформлено!", "Подія", MessageBoxButton.OK, MessageBoxImage.Information);
        }

    }
}
