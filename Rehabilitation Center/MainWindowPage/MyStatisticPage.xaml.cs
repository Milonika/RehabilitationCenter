using Rehabilitation_Center.Data;
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

namespace Rehabilitation_Center.MainWindowPage
{
    /// <summary>
    /// Логика взаимодействия для MyStatisticPage.xaml
    /// </summary>
    public partial class MyStatisticPage : Page
    {
        Users user;
        public MyStatisticPage(Users miniuser)
        {
            InitializeComponent();
            user = miniuser;
            //TbRost.Text=miniuser
            if (App.users.IsAdmin == false)
            {
                BtnAdddDataPacient.Visibility = Visibility.Hidden;
                BtnEditDataPacient.Visibility = Visibility.Hidden;
            }
        }

        private void UserImgStatistic_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void BtnEditDataPacient_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnAdddDataPacient_Click(object sender, RoutedEventArgs e)
        {
            TbRost.Text = App.health.Height.ToString();
            TbVes.Text = App.health.Weight.ToString();
            TbSaturacia.Text = App.health.Saturation;
            TbDavleine.Text = App.health.Davleine;
            TbBloodType.Text = App.health.BloodType;



            //TBWorkPin.IsEnabled = false;
            //TbAgeUser.IsEnabled = false;
            //TbFio.IsEnabled = false;
            //TblLname.IsEnabled = false;
            //TbPhone.IsEnabled = false;
            //TbPolis.IsEnabled = false;
            //TbPasport.IsEnabled = false;
            //TbSnils.IsEnabled = false;
            //TBAddresHome.IsEnabled = false;
            //BtnSaveData.Visibility = Visibility.Hidden;
        }
    }
}
