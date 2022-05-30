using Microsoft.Win32;
using Rehabilitation_Center.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Drawing;
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
    /// Логика взаимодействия для MyAccountPage.xaml
    /// </summary>
    public partial class MyAccountPage : Page
    {
        public MyAccountPage()
        {
            InitializeComponent();

            TbFio.Text = App.users.FirstName + " " + App.users.Name;
            TblLname.Text = App.users.LastName;
            TbPasport.Text = App.users.Pasport;
            TbPolis.Text = App.users.Polis;
            TbSnils.Text = App.users.Snils;
            TbPhone.Text = App.users.Phone;
            TBWorkPin.Text = App.users.Work;
            TBAddresHome.Text = App.users.Addres;
            LWHistoryBuy.ItemsSource = BuyTherapia.Take().Result;
            BuyTherapia.OnAdd += Update;
            DataContext = App.users;
            TbAgeUser.Text = App.users.Age.ToString();
            BtnSaveData.Visibility = Visibility.Hidden;
            

        }
        private void Update()
        {
            LWHistoryBuy.ItemsSource = BuyTherapia.Take().Result;
        }

        private void UserImg_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files|*.bmp;*.jpg;*.png|All files|*.*";
            openFileDialog.FilterIndex = 1;
            if (openFileDialog.ShowDialog() == true)
            {
                App.users.Photo = File.ReadAllBytes(openFileDialog.FileName); 
                BitmapImage image = new BitmapImage();
                image.BeginInit();
                image.UriSource = new Uri(openFileDialog.FileName);
                image.EndInit();
                UserImg.Source = image;
                App.users.Update();
            }
        }

        private void BtnSetting_Click(object sender, RoutedEventArgs e)
        {
            TBWorkPin.IsEnabled = true;
            TbAgeUser.IsEnabled = true;
            TbFio.IsEnabled = true;
            TblLname.IsEnabled = true;
            TbPhone.IsEnabled = true;
            TbPolis.IsEnabled = true;
            TbPasport.IsEnabled = true;
            TbSnils.IsEnabled = true;
            TBAddresHome.IsEnabled = true;
            BtnSaveData.Visibility = Visibility.Visible;
        }

        private void BtnSaveData_Click(object sender, RoutedEventArgs e)
        {
            string[] fio = TbFio.Text.Split(' ');
            App.users.FirstName = fio[0];
            App.users.Name = fio[1];
            App.users.LastName = TblLname.Text;
            App.users.Phone = TbPhone.Text;
            App.users.Pasport = TbPasport.Text;
            App.users.Polis = TbPolis.Text;
            App.users.Snils = TbSnils.Text;
            App.users.Addres = TBAddresHome.Text;
            App.users.Work = TBWorkPin.Text;
            Users.EditProfile();

            TBWorkPin.IsEnabled = false;
            TbAgeUser.IsEnabled = false;
            TbFio.IsEnabled = false;
            TblLname.IsEnabled = false;
            TbPhone.IsEnabled = false;
            TbPolis.IsEnabled = false;
            TbPasport.IsEnabled = false;
            TbSnils.IsEnabled = false;
            TBAddresHome.IsEnabled = false;
            BtnSaveData.Visibility = Visibility.Hidden;
        }
    }
}
