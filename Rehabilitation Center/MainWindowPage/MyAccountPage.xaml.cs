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
            LWHistoryBuy.ItemsSource = BuyTherapia.Take().Result;
            BuyTherapia.OnAdd += Update;
            DataContext = App.users;

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
    }
}
