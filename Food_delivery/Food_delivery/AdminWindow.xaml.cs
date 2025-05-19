using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        private Menu menu;

        public AdminWindow(List<Customer> customers, Menu menu)
        {
            InitializeComponent();
            this.menu = menu;
            AdminMenuListBox.ItemsSource = menu.Items;
        }

        private void AddDish_Click(object sender, RoutedEventArgs e)
        {
            string name = DishNameTextBox.Text;
            string priceText = DishPriceTextBox.Text;

            if (string.IsNullOrWhiteSpace(name) || name == "Назва страви")
            {
                MessageBox.Show("Введіть назву страви.");
                return;
            }

            if (!decimal.TryParse(priceText, out decimal price))
            {
                MessageBox.Show("Ціна має бути числом.");
                return;
            }

            var newItem = new FoodItem(name, "Опис за замовчуванням", price);
            menu.AddFoodItem(newItem);

            // Очищення
            DishNameTextBox.Text = "Назва страви";
            DishPriceTextBox.Text = "Ціна";
            DishNameTextBox.Foreground = Brushes.Gray;
            DishPriceTextBox.Foreground = Brushes.Gray;
        }


        private void RemoveDish_Click(object sender, RoutedEventArgs e)
        {
            if (AdminMenuListBox.SelectedItem is FoodItem selectedItem)
            {
                menu.RemoveFoodItem(selectedItem);
            }
            else
            {
                MessageBox.Show("Оберіть страву для видалення.");
            }
        }
        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            var tb = sender as TextBox;
            if (tb != null && (tb.Text == "Назва страви" || tb.Text == "Ціна"))
            {
                tb.Text = "";
                tb.Foreground = Brushes.Black;
            }
        }

        private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            var tb = sender as TextBox;
            if (tb != null && string.IsNullOrWhiteSpace(tb.Text))
            {
                if (tb == DishNameTextBox)
                    tb.Text = "Назва страви";
                else if (tb == DishPriceTextBox)
                    tb.Text = "Ціна";

                tb.Foreground = Brushes.Gray;
            }
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            var main = new MainWindow();
            main.Show();
            this.Close();
        }
    }
}
