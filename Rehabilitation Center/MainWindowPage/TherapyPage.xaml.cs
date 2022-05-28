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
using Rehabilitation_Center.Admin.AdminWindow;
using Rehabilitation_Center.Data;

namespace Rehabilitation_Center.MainWindowPage
{
    /// <summary>
    /// Логика взаимодействия для TherapyPage.xaml
    /// </summary>
    public partial class TherapyPage : Page
    {
        public TherapyPage()
        {
            InitializeComponent();
            if (App.users.IsAdmin == false)
                BtnAddtherapy.Visibility = Visibility.Hidden;

            GetInfoTherapyAsync();
        }

        private void LWTherapy_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void buyTherapyBtn_Click(object sender, RoutedEventArgs e)
        {

        }
        public async Task GetInfoTherapyAsync()
        {
            LWTherapy.ItemsSource = await Therapy.GetTherapy();
        }

    private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnAddtherapy_Click(object sender, RoutedEventArgs e)
        {
            AddTherapy addTherapy = new AddTherapy();
            addTherapy.Show();
        }

        private void BtnEditTherapy_Copy_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnDeleteTherapy_Copy_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
