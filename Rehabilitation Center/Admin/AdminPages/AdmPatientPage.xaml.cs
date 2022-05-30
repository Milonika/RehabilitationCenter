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
using Rehabilitation_Center.Data;

namespace Rehabilitation_Center.Admin.AdminPages
{
    /// <summary>
    /// Логика взаимодействия для AdmPatientPage.xaml
    /// </summary>
    public partial class AdmPatientPage : Page
    {
        public AdmPatientPage()
        {
            InitializeComponent();
            nanana();
        }

        private void PatientList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var listPatient = PatientList.SelectedItem as Users;
            this.NavigationService.Navigate(new MainWindowPage.MyStatisticPage(listPatient));
        }


        public async Task nanana()
        {
            PatientList.ItemsSource = await Users.GetUsersTask();
        }
    }
}
