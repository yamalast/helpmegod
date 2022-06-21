﻿using FlowersApp.Database;
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
    /// Логика взаимодействия для AuthPage.xaml
    /// </summary>
    public partial class AuthPage : Page
    {
        public AuthPage()
        {
            InitializeComponent();
        }

        private void BtAuthClick(object sender, RoutedEventArgs e)
        {
            User user = EfModel.Init().Users.FirstOrDefault(u => u.UserLogin == TbLogin.Text && u.UserPassword == TbPassword.Text);
            if(user == null)
            {
                MessageBox.Show("Логин или пароль, забыл");
                return;
            }
            if(user.Role.RoleName == "Администраторр")
            {
                NavigationService.Navigate(new AdminPage());
            }
        }

        private void BtGuestClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new GuestPage());
        }
    }
}
