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
            { 
                BtnAddtherapy.Visibility = Visibility.Hidden;
                BtnEditTherapy.Visibility = Visibility.Hidden;
            }


            GetInfoTherapyAsync();
        }
         
        private void LWTherapy_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DeleteTherapy deleteTherapy = new DeleteTherapy();
            if (deleteTherapy.ShowDialog() == true)
            { 
                var item = LWTherapy.SelectedItem as Therapy;
                Therapy.DeleteTherapy(item);
                //GetInfoTherapyAsync();
            }

        }

        private async void buyTherapyBtn_Click(object sender, RoutedEventArgs e)
        {
            string a = ((Button)sender).CommandParameter.ToString();
            BuyTherapia buyTherapia = new BuyTherapia();
            var b = await Therapy.GetTherapy();
            buyTherapia.Therapy = b.Where(x => x.Id.ToString() == a).FirstOrDefault();
            buyTherapia.User = App.users;
            buyTherapia.Add();
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

        private void BtnDeleteTherapy_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnEditTherapy_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
