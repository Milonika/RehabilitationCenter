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
using Rehabilitation_Center.AuthPages;

namespace Rehabilitation_Center.AuthPages
{
    /// <summary>
    /// Логика взаимодействия для AuthMainPage.xaml
    /// </summary>
    public partial class AuthMainPage : Window
    {
        public AuthMainPage()
        {
            InitializeComponent();
        }

        private void BtnGetStarted_Click(object sender, RoutedEventArgs e)
        {
            //////////////
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void BtnCloseAuthWindow_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnONas_Click(object sender, RoutedEventArgs e)
        {
            MainFrameAuth.Navigate(new AuthONacPage());
        }

        private void BtnServis_Click(object sender, RoutedEventArgs e)
        {
            MainFrameAuth.Navigate(new ServisPage());
        }

        private void BtnSpesialists_Click(object sender, RoutedEventArgs e)
        {
            MainFrameAuth.Navigate(new ProfessionalsPage());
        }

        private void BtnContact_Click(object sender, RoutedEventArgs e)
        {
            MainFrameAuth.Navigate(new ContactPage());          
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            Window window = new AuthorizationWindow();
            window.Show();
            this.Close();
        }
    }
}
