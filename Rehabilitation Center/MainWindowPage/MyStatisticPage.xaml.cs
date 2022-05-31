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
            DataContext = user;
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
            TbAgeUser.IsEnabled = true;
            TbRost.IsReadOnly = false;
            TbFio.IsEnabled = true;
            TblLname.IsEnabled = false;
        }

        private void BtnAdddDataPacient_Click(object sender, RoutedEventArgs e)
        {
            user.Health.Height = int.Parse(TbRost.Text);
            user.Health.Weight = int.Parse(TbVes.Text);
            user.Health.Pressure = TbDavleine.Text;
            user.Health.Saturation = TbSaturacia.Text;
            user.Health.BloodType = TbBloodType.Text;
            TbVes.IsReadOnly=true;
            TbRost.IsReadOnly = true;
            TbSaturacia.IsReadOnly = true;
            TbDependece.IsReadOnly = true;
            TbDavleine.IsReadOnly = true;
            TbBloodType.IsReadOnly = true;
        }
    }
}
