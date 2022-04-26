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

namespace Rehabilitation_Center
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
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

        }

        private void BtnMyStatistic_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnTerapia_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnSpesialist_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
