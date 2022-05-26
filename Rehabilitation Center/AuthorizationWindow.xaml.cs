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
using Rehabilitation_Center.Admin.AdminWindow;
using Rehabilitation_Center.Data;

namespace Rehabilitation_Center
{
    /// <summary>
    /// Логика взаимодействия для AuthorizationWindow.xaml
    /// </summary>
    public partial class AuthorizationWindow : Window
    {
        public AuthorizationWindow()
        {
            InitializeComponent();
        }

        private void TBLogin_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void BtnCloseAuthWindow_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnRegistWindow_Click(object sender, RoutedEventArgs e)
        {
            Window registwindow = new RegistrationWindow();
            registwindow.Show();
            this.Close();
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            if (TBLogin.Text == "" || PBPassword.Password == "")
            {
                MessageBox.Show("Введите все данные");
            }
            else
            {
                Users us = new Users(TBLogin.Text, PBPassword.Password);
                Users.LogInUser(us);
                if (App.users.IsAdmin == true)
                {
                    MessageBox.Show("Приветсвуем, Администратор");
                    AdminWindow adminWindow = new AdminWindow(us.IsAdmin);
                    adminWindow.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Успешный вход");
                    MainWindow mw = new MainWindow(us.IsAdmin);
                    mw.Show();
                    this.Close();
                }
            }
            //Window mainwindow = new MainWindow();
            //mainwindow.Show();
            //this.Close();
        }
    }
}
