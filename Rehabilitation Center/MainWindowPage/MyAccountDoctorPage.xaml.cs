using Microsoft.Win32;
using Rehabilitation_Center.Db;
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
    /// Логика взаимодействия для MyAccountPage.xaml
    /// </summary>
    public partial class MyAccountDoctorPage : Page
    {
        public OpenFileDialog fileDialog = new OpenFileDialog();
        public MyAccountDoctorPage()
        {
            InitializeComponent();

            try
            {
                //Проверям ID роли в соответствии с БД. Если id роли у авторизации 2 - то юзер, если наоборот то админ 
                if (MainWindow.AuthUser.IDRols == 2)
                {
                    //Создаем прееменную клиента к кторой потом обращаемся
                    var client = MainWindow.ReabilCenterDB.Client.FirstOrDefault(c => c.IDAuth == MainWindow.AuthUser.IDAuth);

                    //работаем с переменной клиента 
                    FNameAndNameTBDoctor.Text = $"{client.Name} {client.FName} {client.LName}";
                    LastNameTB.Text = $"{client.LName}";
                    TextBlokAge.Text = $"Возраст: {client.Age.ToString()}";
                    TBPasportDoctor.Text = $"{client.Pasport}";
                    TBPolisDoctor.Text = $"{client.Polis}";
                    TBSNILSDoctor.Text = $"{client.SNILS}"; 

                }
                else if (MainWindow.AuthUser.IDRols == 1)
                {
                    //Создаем прееменную доктора к кторой потом обращаемся
                    var doctor = MainWindow.ReabilCenterDB.Doctor.FirstOrDefault(c => c.IDAuth == MainWindow.AuthUser.IDAuth);

                    //работаем с переменной клиента 
                    FNameAndNameTBDoctor.Text = $"{doctor.Name} {doctor.FName}";
                    LastNameTB.Text = $"{doctor.LName}";
                    TextBlokAge.Text = $"Возраст: {doctor.Age.ToString()}";
                    TBPasportDoctor.Text = $"{doctor.Pasport}";
                    TBPolisDoctor.Text = $"{doctor.Polis}";
                    TBSNILSDoctor.Text = $"{doctor.SNILS}";
                    if (doctor.Photo != null )
                    {
                        MemoryStream memoryStream = new MemoryStream(doctor.Photo);
                        BitmapImage bitmapImage = new BitmapImage();
                        bitmapImage.BeginInit();
                        bitmapImage.StreamSource = memoryStream;
                        bitmapImage.EndInit();
                        UserImg.Source = bitmapImage;
                    }
                }
            }
            //если вылезает ошибка в авторизации открываем страницу авторизации
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                new AuthorizationWindow().Show();
            }
        }

        private void UserImg_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files|*.bmp;*.jpg;*.png|All files|*.*";
            openFileDialog.FilterIndex = 1;
            if (openFileDialog.ShowDialog() == true)
            {
                var gg = MainWindow.ReabilCenterDB.Doctor.FirstOrDefault(c => c.IDAuth == MainWindow.authUser.IDAuth);
                MainWindow.ReabilCenterDB.Doctor.Attach(gg);

                BitmapImage image = new BitmapImage();
                image.BeginInit();
                image.UriSource = new Uri(openFileDialog.FileName);

                gg.Photo = File.ReadAllBytes(openFileDialog.FileName);

                image.EndInit();
                fileDialog = openFileDialog;
                UserImg.Source = image;
                MainWindow.ReabilCenterDB.SaveChanges();
            }
        }

    }
}
