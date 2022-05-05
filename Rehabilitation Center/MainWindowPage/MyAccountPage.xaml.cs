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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Rehabilitation_Center.MainWindowPage
{
    /// <summary>
    /// Логика взаимодействия для MyAccountPage.xaml
    /// </summary>
    public partial class MyAccountPage : Page
    {
        public OpenFileDialog fileDialogClient = new OpenFileDialog();
        public MyAccountPage()
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
                    MessageBox.Show($"Добро пожаловать {client.Name}", "Сообщение клиенту");
                    FNameAndNameTB.Text = $"{client.Name} {client.FName} {client.LName}";
                    LastNameTB.Text = $"{client.LName}";
                    TextBlokAge.Text = $"Возраст: {client.Age.ToString()}";
                    TBPasport.Text = $"{client.Pasport}";
                    TBPolis.Text = $"{client.Polis}";
                    TBSNILS.Text = $"{client.SNILS}";

                    HistoryBuyTherapy.ItemsSource = MainWindow.ReabilCenterDB.TherapyHistory.Where(
                                                    c => c.IDClient == MainWindow.ReabilCenterDB.Client.FirstOrDefault(
                                                    d => d.IDAuth == MainWindow.authUser.IDAuth).IDClient).ToList();
                    if (client.Photo != null)
                    {
                        MemoryStream memoryStream = new MemoryStream(client.Photo);
                        BitmapImage bitmapImage = new BitmapImage();
                        bitmapImage.BeginInit();
                        bitmapImage.StreamSource = memoryStream;
                        bitmapImage.EndInit();
                        AddPhotoClient.Source = bitmapImage;
                    }
                }
                else if (MainWindow.AuthUser.IDRols == 1)
                {
                    //Создаем прееменную доктора к кторой потом обращаемся
                    var doctor = MainWindow.ReabilCenterDB.Doctor.FirstOrDefault(c => c.IDAuth == MainWindow.AuthUser.IDAuth);

                    //работаем с переменной клиента 
                    MessageBox.Show($"Добро пожаловать {doctor.Name}", "Сообщение доктору(админ в бд)");
                    FNameAndNameTB.Text = $"{doctor.Name} {doctor.FName}";
                    LastNameTB.Text = $"{doctor.LName}";
                    TextBlokAge.Text = $"Возраст: {doctor.Age.ToString()}";
                }
            }
            //если вылезает ошибка в авторизации открываем страницу авторизации
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                new AuthorizationWindow().Show();
            }

        }

        private void AddPhotoClient_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files|*.bmp;*.jpg;*.png|All files|*.*";
            openFileDialog.FilterIndex = 1;
            if (openFileDialog.ShowDialog() == true)
            {
                var gg = MainWindow.ReabilCenterDB.Client.FirstOrDefault(c => c.IDAuth == MainWindow.authUser.IDAuth);
                MainWindow.ReabilCenterDB.Client.Attach(gg);

                BitmapImage image = new BitmapImage();
                image.BeginInit();
                image.UriSource = new Uri(openFileDialog.FileName);

                gg.Photo = File.ReadAllBytes(openFileDialog.FileName);

                image.EndInit();
                fileDialogClient = openFileDialog;
                AddPhotoClient.Source = image;
                MainWindow.ReabilCenterDB.SaveChanges();
            }
        }    
    }
}
