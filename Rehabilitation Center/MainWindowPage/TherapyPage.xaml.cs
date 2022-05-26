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
    /// Логика взаимодействия для TherapyPage.xaml
    /// </summary>
    public partial class TherapyPage : Page
    {
        public TherapyPage()
        {
            InitializeComponent();
        }

        private void LWTherapy_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void buyTherapyBtn_Click(object sender, RoutedEventArgs e)
        {
            //var gg = sender as Button;
            //var ff = int.Parse(gg.CommandParameter.ToString());
            ////Поиск
            //var bb = MainWindow.ReabilCenterDB.Client.Where(c => c.IDAuth == MainWindow.authUser.IDAuth).FirstOrDefault();
            //TherapyHistory therapyHistory = new TherapyHistory()
            //{
            //    IDClient = MainWindow.ReabilCenterDB.Client.Where(c => c.IDAuth == MainWindow.authUser.IDAuth).FirstOrDefault().IDClient,
            //    IDTherapy = ff,
            //};
            //MainWindow.ReabilCenterDB.TherapyHistory.Add(therapyHistory);
            //MainWindow.ReabilCenterDB.SaveChanges();
        }
    }
}
