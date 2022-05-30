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
using Rehabilitation_Center.MainWindowPage;
using Rehabilitation_Center.Admin.AdminPages;

namespace Rehabilitation_Center.Admin.AdminWindow
{
    /// <summary>
    /// Логика взаимодействия для AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        public bool IsAdmin;
        public AdminWindow(bool isAdmin)
        {
            InitializeComponent();
            IsAdmin = isAdmin;
        }

        private void BtnMyAccountAdmin_Click(object sender, RoutedEventArgs e)
        {
            AdminMainFrame.Navigate(new AdminAccount());
        }

        private void BtnSpesialistAdmin_Click(object sender, RoutedEventArgs e)
        {
            AdminMainFrame.Navigate(new MainWindowPage.SpesialistPage());
        }

        private void BtnPacientAdmin_Click(object sender, RoutedEventArgs e)
        {
            AdminMainFrame.Navigate(new AdmPatientPage());
        }

        private void BtnClosWindowAdmin_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnTerapiaAdmin_Click(object sender, RoutedEventArgs e)
        {
            AdminMainFrame.Navigate(new MainWindowPage.TherapyPage());
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
    }
}
