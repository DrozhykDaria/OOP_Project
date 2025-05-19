using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
    /// Логика взаимодействия для CustomerWindow.xaml
    /// </summary>
    public partial class CustomerWindow : Window
    {
        private readonly Customer customer;
        private readonly Menu menu;
        private readonly Cart cart;

        public CustomerWindow(Cart cart, Customer customer, Menu menu)
        {
            InitializeComponent();
            this.cart = cart;
            this.customer = customer ?? throw new ArgumentNullException();
            this.menu = menu;

            FoodList.ItemsSource = menu.Items;
            this.cart.ItemAdded += (s, newItem) =>
                MessageBox.Show($"Додано до кошика: {newItem.Item.Name} (x{newItem.Quantity})", "Кошик", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void AddToCart_Click(object sender, RoutedEventArgs e)
        {
            if (FoodList.SelectedItem is not FoodItem selectedItem)
            {
                MessageBox.Show("Оберіть страву");
                return;
            }
            if (!int.TryParse(QuantityBox.Text, out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Некоректна кількість");
                return;
            }
            cart.AddItem(selectedItem, quantity);
        }

        private void GoToCart_Click(object sender, RoutedEventArgs e)
        {
            new CartWindow(cart.Items, customer, menu, cart).Show();
            Close();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            new MainWindow().Show();
            Close();
        }
    }
}