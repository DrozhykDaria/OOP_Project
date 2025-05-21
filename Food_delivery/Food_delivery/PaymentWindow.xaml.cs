using System;
using System.Windows;
using System.Windows.Controls;

namespace Food_delivery
{
    public partial class PaymentWindow : Window
    {
        private readonly decimal totalAmount;
        private readonly Payment payment;

        public bool PaymentSucceeded { get; private set; } = false;

        public PaymentWindow(decimal amount)
        {
            InitializeComponent();
            totalAmount = amount;
            payment = new Payment();

            AmountTextBlock.Text = $"{totalAmount} грн";

            UpdateCardFieldsVisibility();
        }

        private void Pay_Click(object sender, RoutedEventArgs e)
        {
            string paymentMethod = (PaymentMethodComboBox.SelectedItem as ComboBoxItem)?.Content.ToString() ?? "Картка";

            try
            {
                bool success = payment.ProcessPayment(totalAmount, paymentMethod);
                if (success)
                {
                    PaymentSucceeded = true;
                    MessageBox.Show("Оплата успішна!", "Успіх", MessageBoxButton.OK, MessageBoxImage.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при оплаті: {ex.Message}", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void PaymentMethodComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateCardFieldsVisibility();
        }

        private void UpdateCardFieldsVisibility()
        {
            if (PaymentMethodComboBox.SelectedItem is ComboBoxItem selectedItem && selectedItem.Content != null)
            {
                string selected = selectedItem.Content.ToString();

                if (CardDetailsPanel != null)
                {
                    CardDetailsPanel.Visibility = selected == "Картка"
                        ? Visibility.Visible
                        : Visibility.Collapsed;
                }
            }
            else
            {
                if (CardDetailsPanel != null)
                    CardDetailsPanel.Visibility = Visibility.Collapsed;
            }
        }

    }
}