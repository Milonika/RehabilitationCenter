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
using System.Windows.Shapes;

namespace Rehabilitation_Center
{
    /// <summary>
    /// Логика взаимодействия для RegistrationWindow.xaml
    /// </summary>
    public partial class RegistrationWindow : Window
    {
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
            if (TBNameRegis.Text == "" || TBFNameRegis.Text == "" || TBLNameRegis.Text == "" || TBPasportRegis.Text == "" || TBSNILSRegis.Text == "" || TBPolisRegis.Text == "" || TBAgeRegis.Text == "" || TBLoginRegis.Text == "" || TBPasswordRegis.Text == "")
            {
                MessageBox.Show("Введите все данные");
            }
            else
            {
                Users us = new Users(TBFNameRegis.Text, TBNameRegis.Text, TBLNameRegis.Text, TBPasportRegis.Text, TBPolisRegis.Text, TBSNILSRegis.Text, TBPhoneRegis.Text, Convert.ToInt32(TBAgeRegis.Text), TBLoginRegis.Text, TBPasswordRegis.Text, null);
                Users.AddUser(us);
                MessageBox.Show("Вы зарегистрировались!");
                MainWindow mw = new MainWindow(us.IsAdmin);
                mw.Show();
                this.Close();
                App.users = us;
            }
        }
    }
}
