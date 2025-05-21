using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Food_delivery
{
    public partial class MainWindow : Window
    {
        private List<Customer> customers = new List<Customer>();
        private Menu menu = new Menu();
        private Menu sharedMenu = new Menu(); // якщо потрібно для інших вікон
        private Admin admin;

        public MainWindow()
        {
            InitializeComponent();

            var testCustomer = new Customer()
            {
                Email = "drozhyk@gmail.com",
                Password = "12345",
                FirstName = "Дар'я",
                LastName = "Дрожик"
            };

            admin = new Admin()
            {
                Email = "drozhykdaria@gmail.com",
                Password = "12345",
                FirstName = "Дар'я",
                LastName = "Дрожик"
            };

            customers.Add(testCustomer);

            // Наповнення меню
            menu.AddFoodItem(new FoodItem("Піца Маргарита", "Класична піца з томатами та моцарелою", 210));
            menu.AddFoodItem(new FoodItem("Піца Пепероні", "Піца з пепероні та сиром", 225));
            menu.AddFoodItem(new FoodItem("Піца Чотири сири", "Моцарела, горгонзола, пармезан, емменталь", 240));
            menu.AddFoodItem(new FoodItem("Лазанья Болоньєзе", "Лазанья з м'ясним соусом", 260));
            menu.AddFoodItem(new FoodItem("Равіолі зі шпинатом", "Фаршировані паста з соусом", 225));
            menu.AddFoodItem(new FoodItem("Паста Карбонара", "Паста з беконом, яйцем і сиром", 230));
            menu.AddFoodItem(new FoodItem("Паста Болоньєзе", "З соусом з м'ясного фаршу", 240));
            menu.AddFoodItem(new FoodItem("Паста з морепродуктами", "Спагеті з мідіями, креветками", 255));
            menu.AddFoodItem(new FoodItem("Gnocchi", "Італійські картопляні галушки з соусом", 210));
            menu.AddFoodItem(new FoodItem("Різотто з грибами", "Рис з білими грибами та пармезаном", 245));
            menu.AddFoodItem(new FoodItem("Різотто з морепродуктами", "Італійський рис із дарами моря", 260));
            menu.AddFoodItem(new FoodItem("Тірамісу", "Класичний десерт з маскарпоне", 195));
            menu.AddFoodItem(new FoodItem("Пана-кота", "Вершковий десерт з ягодами", 185));
            menu.AddFoodItem(new FoodItem("Капрезе", "Салат з моцарелою, томатами та базиліком", 200));
            menu.AddFoodItem(new FoodItem("Брускети", "Підсмажений хліб з томатами", 110));
            menu.AddFoodItem(new FoodItem("Мінестроне", "Італійський овочевий суп", 140));
            menu.AddFoodItem(new FoodItem("Фокачча", "Італійський хліб з розмарином", 130));
            menu.AddFoodItem(new FoodItem("Кальцоне", "Закрита піца з шинкою і сиром", 190));
            menu.AddFoodItem(new FoodItem("Оссобуко", "Тушкована теляча гомілка з овочами", 280));
            menu.AddFoodItem(new FoodItem("Піцца з прошуто", "З прошуто, руколою і пармезаном", 265));
        }

        private void CustomerLogin_Click(object sender, RoutedEventArgs e)
        {
            string email = EmailBox.Text.Trim();
            string password = PasswordBox.Password.Trim();

            var customer = customers.FirstOrDefault(c => c.Authenticate(email, password));
            if (customer != null)
            {
                var customerWin = new CustomerWindow(new Cart(), customer, menu);
                customerWin.Show();
                MessageBox.Show("Реєстрація виконана успішно!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Невірний email або пароль!");
            }
        }

        private void AdminLogin_Click(object sender, RoutedEventArgs e)
        {
            string email = AdminEmailBox.Text.Trim();
            string password = AdminPasswordBox.Password.Trim();

            if (admin != null && admin.Authenticate(email, password))
            {
                var adminWin = new AdminWindow(customers, menu);
                adminWin.Show();
                MessageBox.Show("Вхід як адміністратор виконано успішно!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Невірний email або пароль адміністратора!");
            }
        }

        private void GuestLogin_Click(object sender, RoutedEventArgs e)
        {
            var guestWin = new GuestWindow(menu);
            guestWin.Show();
            this.Close();
        }

        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            var tb = sender as TextBox;
            if (tb != null && tb.Text == "Email")
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
                tb.Text = "Email";
                tb.Foreground = Brushes.Gray;
            }
        }

        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            PasswordPlaceholder.Visibility = string.IsNullOrEmpty(PasswordBox.Password)
                ? Visibility.Visible
                : Visibility.Collapsed;
        }

        private void AdminPasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            AdminPasswordPlaceholder.Visibility = string.IsNullOrEmpty(AdminPasswordBox.Password)
                ? Visibility.Visible
                : Visibility.Collapsed;
        }
    }
}
