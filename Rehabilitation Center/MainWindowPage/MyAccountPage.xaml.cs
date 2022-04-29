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
        public MyAccountPage()
        {
            InitializeComponent();

            var client = MainWindow.ReabilCenterDB.Client.FirstOrDefault(x => x.IDClient == MainWindow.Client.IDClient);
            if (client != null)
            {
                FNameAndNameTB.Text = $"{client.Name} {client.FName} {client.LName}";
                LastNameTB.Text = $"{client.LName}";
                TextBlokAge.Text = $"Возраст: {client.Age.ToString()}";
            }
            else
            {
                var clients = MainWindow.ReabilCenterDB.Doctor.FirstOrDefault(x => x.IDDoctor == MainWindow.Client.IDDoctor);
                FNameAndNameTB.Text = $"{clients.Name} {clients.FName}";
                LastNameTB.Text = $"{client.LName}";
                TextBlokAge.Text = $"Возраст: {client.Age.ToString()}";
            }
            // 
        }
    }
}
