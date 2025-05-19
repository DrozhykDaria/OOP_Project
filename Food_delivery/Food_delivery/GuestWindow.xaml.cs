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
    /// Логика взаимодействия для GuestWindow.xaml
    /// </summary>
    public partial class GuestWindow : Window
    {
        private Menu menu;

        public GuestWindow(Menu menu)
        {
            InitializeComponent();
            this.menu = menu;

            // Очистити список перед додаванням
            MenuList.Items.Clear();

            foreach (var item in menu.Items)
            {
                MenuList.Items.Add(item);
            }
        }

        // Обробка кліку по страві
        private void MenuList_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            MessageBox.Show("Щоб замовити страву, потрібно зареєструватися або увійти!", "Доступ обмежено", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        // Повернення до головного вікна
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            var mainWin = new MainWindow();
            mainWin.Show();
            this.Close();
        }
    }
}
