using FlowersApp.Database;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FlowersApp.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddProductPage.xaml
    /// </summary>
    public partial class AddProductPage : Page
    {
        Product product;
        public AddProductPage(Product product)
        {
            InitializeComponent();
            this.product = product;
            DataContext = product;
        }

        private void BtAddClick(object sender, RoutedEventArgs e)
        {
            EfModel.Init().Products.Add(product);
            EfModel.Init().SaveChanges();
            MessageBox.Show("Добавление прошло успешно");
           
        }
    }
}
