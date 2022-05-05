using Rehabilitation_Center.Db;
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
            List<Therapy> wq = new List<Therapy>() { new Therapy() { Name = "mfkelmr" }, new Therapy() { Name = "kfoe" } };
            listviewUsers.ItemsSource = MainWindow.ReabilCenterDB.Therapy.ToList();
            //foreach(var i in MainWindow.ReabilCenterDB.Therapy)
            //{
            //    listviewUsers.Items.Add(i);
            //}
        }


        private void BtnLoad_Click(object sender, RoutedEventArgs e)
        {

        }

        private void buyBtn_Click(object sender, RoutedEventArgs e)
        {
            //Therapy therapy = MainWindow.ReabilCenterDB.Therapy.Where(c => c.IDTherapy == int.Parse((sender as Button).CommandParameter.ToString())).FirstOrDefault();
            var gg = sender as Button;
            var ff = int.Parse(gg.CommandParameter.ToString());
            //Поиск
            var bb = MainWindow.ReabilCenterDB.Client.Where(c => c.IDAuth == MainWindow.authUser.IDAuth).FirstOrDefault();
            TherapyHistory therapyHistory = new TherapyHistory()
            {
                IDClient = MainWindow.ReabilCenterDB.Client.Where(c => c.IDAuth == MainWindow.authUser.IDAuth).FirstOrDefault().IDClient,
                IDTherapy = ff,
            };
            MainWindow.ReabilCenterDB.TherapyHistory.Add(therapyHistory);
            MainWindow.ReabilCenterDB.SaveChanges();
            
        }

        private void listviewUsers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
