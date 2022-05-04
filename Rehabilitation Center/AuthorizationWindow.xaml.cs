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
using Rehabilitation_Center.Db;

namespace Rehabilitation_Center
{
    /// <summary>
    /// Логика взаимодействия для AuthorizationWindow.xaml
    /// </summary>
    public partial class AuthorizationWindow : Window
    {
        public AuthorizationWindow()
        {
            
            InitializeComponent();
        }

        private void TBLogin_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void BtnCloseAuthWindow_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnRegistWindow_Click(object sender, RoutedEventArgs e)
        {
            Window registwindow = new RegistrationWindow();
            registwindow.Show();
            this.Close();
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            //Создаем переменную юзера и выполняем поиск по бд всех юзеров с таким логином и паролем
            Auth logUser = MainWindow.ReabilCenterDB.Auth.FirstOrDefault(c => c.Login == TBLogin.Text.Trim() && c.Password == PBPassword.Password.Trim());
            MainWindow.authUser = logUser;
            if (logUser != null)
            {
                //обращаемся к уже созданной переменной в MainWindow чтобы к ней был доступ везде 
                MainWindow.AuthUser = logUser;

                MessageBox.Show($"Добро пожаловать {logUser.Login}", "Вы зашли под админом");

                new MainWindow().Show();
                this.Close();
            }
            else
                MessageBox.Show("Неправильный пароль или логин");
        }
    }
}
