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
using Rehabilitation_Center.MainWindowPage;
using Rehabilitation_Center.Db; 

namespace Rehabilitation_Center
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public static ReabilCenterEntities ReabilCenterDB = new ReabilCenterEntities();

        //Создаем статичную переменную чтобы к ней обращаться ото всюду
        public static Auth AuthUser = new Auth();
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnCloseMainWindow_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void MyMainWindow_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove(); 
        }

        private void BtnMyAccount_Click(object sender, RoutedEventArgs e)
        {
            MainFrameInMainWindow.Navigate(new MyAccountPage());
        }

        private void BtnMyStatistic_Click(object sender, RoutedEventArgs e)
        {
            MainFrameInMainWindow.Navigate(new MyStatisticPage());
        }

        private void BtnTerapia_Click(object sender, RoutedEventArgs e)
        {
            MainFrameInMainWindow.Navigate(new MainWindowPage.TherapyPage());
        }

        private void BtnSpesialist_Click(object sender, RoutedEventArgs e)
        {
            MainFrameInMainWindow.Navigate(new MainWindowPage.SpesialistPage());
        }

        private void BtnPacient_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
