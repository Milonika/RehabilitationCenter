using Rehabilitation_Center.Data;
using System;
using System.Collections.Generic;
using System.IO;
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
            if (App.users.IsAdmin == true)
            {
                TbVes.IsReadOnly = false;
                TbRost.IsReadOnly = false;
                TbSaturacia.IsReadOnly = false;
                TbDependece.IsReadOnly = false;
                TbDavleine.IsReadOnly = false;
                TbBloodType.IsReadOnly = false;
            }

            if (App.users.IsAdmin == false)
            {
                TbVes.IsReadOnly = true;
                TbRost.IsReadOnly = true;
                TbSaturacia.IsReadOnly = true;
                TbDependece.IsReadOnly = true;
                TbDavleine.IsReadOnly = true;
                TbBloodType.IsReadOnly = true;

                BtnAdddDataPacient.Visibility = Visibility.Hidden;
                BtnEditDataPacient.Visibility = Visibility.Hidden;
            }

            if (App.users.Photo != null)
            {
                MemoryStream memoryStream = new MemoryStream(App.users.Photo);
                BitmapImage bitmapImage = new BitmapImage();
                bitmapImage.BeginInit();
                bitmapImage.StreamSource = memoryStream;
                bitmapImage.EndInit();
                UserImgStatistic.Source = bitmapImage;
            }
            TbAgeUser.Text = App.users.Age.ToString();
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
            Users.EditHealth(user);
            TbVes.IsReadOnly=true;
            TbRost.IsReadOnly = true;
            TbSaturacia.IsReadOnly = true;
            TbDependece.IsReadOnly = true;
            TbDavleine.IsReadOnly = true;
            TbBloodType.IsReadOnly = true;
        }
    }
}
