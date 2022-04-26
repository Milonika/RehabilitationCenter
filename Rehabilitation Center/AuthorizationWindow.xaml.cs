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
            Window mainwindow = new MainWindow();
            mainwindow.Show();
            this.Close();
        }
    }
}
