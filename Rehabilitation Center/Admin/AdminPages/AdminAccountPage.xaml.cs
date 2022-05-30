using Microsoft.Win32;
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

namespace Rehabilitation_Center.Admin.AdminPages
{
    /// <summary>
    /// Логика взаимодействия для AdminAccount.xaml
    /// </summary>
    public partial class AdminAccount : Page
    {
        public AdminAccount()
        {
            InitializeComponent();

            TbAdmFio.Text = App.users.FirstName + " " + App.users.Name;
            TbAdmLname.Text = App.users.LastName;
            TbAdmPasport.Text = App.users.Pasport;
            TbAdmPolis.Text = App.users.Polis;
            TbAdmSnils.Text = App.users.Snils;
            TbAdmPhone.Text = App.users.Phone;
            TbAdmJobPin.Text = App.users.Work;
            TbAdmHome.Text = App.users.Addres;
            TblAdminAge.Text = App.users.Age.ToString();
            BtnSaveDataAdmin.Visibility = Visibility.Hidden;
        }


        private void AdmimImg_PreviewMouseDown(object sender, MouseButtonEventArgs e)
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
                AdmimImg.Source = image;
                App.users.Update();
            }
        }

        private void BtnSaveDataAdmin_Click(object sender, RoutedEventArgs e)
        {
            string[] fio = TbAdmFio.Text.Split(' ');
            App.users.FirstName = fio[0];
            App.users.Name = fio[1];
            App.users.LastName = TbAdmLname.Text;
            App.users.Phone = TbAdmPhone.Text;
            App.users.Pasport = TbAdmPasport.Text;
            App.users.Polis = TbAdmPolis.Text;
            App.users.Snils = TbAdmSnils.Text;
            App.users.Addres = TbAdmHome.Text;
            App.users.Work = TbAdmJobPin.Text;
            Users.EditProfile();

            TbAdmJobPin.IsEnabled = false;
            TbAdmFio.IsEnabled = false;
            TbAdmLname.IsEnabled = false;
            TbAdmPhone.IsEnabled = false;
            TbAdmPolis.IsEnabled = false;
            TbAdmPasport.IsEnabled = false;
            TbAdmSnils.IsEnabled = false;
            TbAdmHome.IsEnabled = false;
            BtnSaveDataAdmin.Visibility = Visibility.Hidden;
        }

        private void BtnSettingAdmin_Click(object sender, RoutedEventArgs e)
        {
            TbAdmJobPin.IsEnabled = true;
            TbAdmFio.IsEnabled = true;
            TbAdmLname.IsEnabled = true;
            TbAdmPhone.IsEnabled = true;
            TbAdmPolis.IsEnabled = true;
            TbAdmPasport.IsEnabled = true;
            TbAdmSnils.IsEnabled = true;
            TbAdmHome.IsEnabled = true;
            BtnSaveDataAdmin.Visibility = Visibility.Visible;
        }
    }
}
