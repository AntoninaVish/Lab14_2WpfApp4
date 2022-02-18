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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab14_2WpfApp4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Product> products;
        public MainWindow()
        {
            InitializeComponent();
            products = new ObservableCollection<Product>();// список задается в конструкторе
            
            products.Add(new Product() // это не список-лист а коллекция с поддержкой уведомления
            {
                ProductName = "Клубника",
                ProductPrice = 400,
                ProductImage = "Data14/клубника.jpg",
                ProductCategory = ProductCategorys.Food
            });

            products.Add(new Product()
            {
                ProductName = "Малина",
                ProductPrice = 450,
                ProductImage = "Data14/малина.png",
                ProductCategory = ProductCategorys.Food
            });

            products.Add(new Product()
            {
                ProductName = "Ежевика",
                ProductPrice = 500,
                ProductImage = "Data14/ежевика.jpg",
                ProductCategory = ProductCategorys.Food
            });

            products.Add(new Product()
            {
                ProductName = "Фен",
                ProductPrice = 2500,
                ProductImage = "Data14/фен.png",
                ProductCategory = ProductCategorys.Applicances

            });

            products.Add(new Product()
            {
                ProductName = "Телевизор",
                ProductPrice = 45000,
                ProductImage = "Data14/телевизор.jpg",
                ProductCategory = ProductCategorys.Applicances
            });

            products.Add(new Product()
            {
                ProductName = "Холодильник",
                ProductPrice = 50000,
                ProductImage = "Data14/холодильник.jpg",
                ProductCategory = ProductCategorys.Applicances

            });

            listBox.ItemsSource = products;// сюда присваиваем значение этого списка

        }
    }
}
