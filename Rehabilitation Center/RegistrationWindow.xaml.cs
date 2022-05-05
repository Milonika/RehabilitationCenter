using Rehabilitation_Center.Db;
using Microsoft.Win32;
using System.IO;
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
using System.Windows.Shapes;

namespace Rehabilitation_Center
{
    /// <summary>
    /// Логика взаимодействия для RegistrationWindow.xaml
    /// </summary>
    public partial class RegistrationWindow : Window
    {
        OpenFileDialog openFileDialogRegist = new OpenFileDialog();
        MemoryStream image2;
        public RegistrationWindow()
        {
            InitializeComponent();
        }

        private void BtnCloseRegistWindow_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void RegistratonWindow_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void BtnZaregistr_Click(object sender, RoutedEventArgs e)
        {
            if (TBNameRegis.Text == "" || TBFNameRegis.Text == "" || TBPasportRegis.Text == ""  || TBSNILSRegis.Text == "" || TBPolisRegis.Text == "" || TBAgeRegis.Text == ""  || TBLoginRegis.Text == "" || TBPasswordRegis.Text == "") 
            {
                MessageBox.Show("Введите все данные");
            }
            else
            {
                Auth aut = new Auth()
                {
                    Login = TBLoginRegis.Text,
                    Password = TBPasswordRegis.Text,
                    IDRols = 2,
                };
                Client us = new Client()
                {
                    LName = TBLNameRegis.Text,
                    Name = TBNameRegis.Text,
                    FName = TBNameRegis.Text,
                    Pasport = TBPasportRegis.Text,
                    SNILS = TBSNILSRegis.Text,
                    Polis = TBPolisRegis.Text,
                    Phone = TBPhoneRegis.Text,
                    Photo = getJPGFromImageControl(AddPhotoRegis.Source as BitmapImage),
                   Age = Convert.ToInt32(TBAgeRegis.Text),
                   IDAuth = aut.IDAuth
                };

                MainWindow.ReabilCenterDB.Auth.Add(aut);
                MainWindow.ReabilCenterDB.Client.Add(us);
                MainWindow.ReabilCenterDB.SaveChanges();
                MessageBox.Show("Вы Зарегестрированы");
            }

            // hide main form
            this.Hide();

            // show other form
            AuthorizationWindow authWin = new AuthorizationWindow();
            authWin.ShowDialog();

            // close application
            this.Close();

        }

        private void AddPhotoRegis_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files|*.bmp;*.jpg;*.png|All files|*.*";
            openFileDialog.FilterIndex = 1;
            if (openFileDialog.ShowDialog() == true)
            {

                BitmapImage image = new BitmapImage();
                image.BeginInit();
                image.UriSource = new Uri(openFileDialog.FileName);
                image.EndInit();
                openFileDialogRegist = openFileDialog;
                AddPhotoRegis.Source = image;
                MainWindow.ReabilCenterDB.SaveChanges();
            }
        }
        public byte[] getJPGFromImageControl(BitmapImage imageC)
        {
            MemoryStream memStream = new MemoryStream();
            JpegBitmapEncoder encoder = new JpegBitmapEncoder();
            encoder.Frames.Add(BitmapFrame.Create(imageC));
            encoder.Save(memStream);
            return memStream.ToArray();
        }
    }
}
