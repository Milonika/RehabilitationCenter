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
            
        }

        private void oNas_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void ServisLabel_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }

        private void SpesialistLabel_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }

        private void ContactLabel_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
