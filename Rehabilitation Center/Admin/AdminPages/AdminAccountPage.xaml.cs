using Microsoft.Win32;
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
            TbAdminAge.Text = App.users.ToString();
           
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
    }
}
