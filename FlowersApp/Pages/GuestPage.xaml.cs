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
    /// Логика взаимодействия для GuestPage.xaml
    /// </summary>
    public partial class GuestPage : Page
    {
        public GuestPage()
        {
            InitializeComponent();
            LVProduct.ItemsSource = EfModel.Init().Products.ToList();
            CbSort.Items.Add("По возрастанию");
            CbSort.Items.Add("По убыванию");
            CbSort.SelectedIndex = 0;
            UpdateData();
        }

        private void UpdateData()
        {
            IEnumerable<Product> products = EfModel.Init().Products.Where(p => p.ProductArticul.Contains(TbSearch.Text) || p.ProductCategory.Contains(TbSearch.Text));
            switch (CbSort.SelectedIndex)
            {
                case 0:
                    products = products.OrderBy(p => p.ProductCost);
                    break;
                case 1:
                    products = products.OrderByDescending(p => p.ProductCost);
                    break;
            }
            LVProduct.ItemsSource = products.ToList();
        }

        private void TbSearchChanged(object sender, TextChangedEventArgs e)
        {
            UpdateData();
        }

        private void CbSortChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateData();
        }
    }
}
