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
    /// Логика взаимодействия для SpesialistPage.xaml
    /// </summary>
    public partial class SpesialistPage : Page
    {
        public SpesialistPage()
        {
            InitializeComponent();
            DoctorList.ItemsSource = MainWindow.ReabilCenterDB.Doctor.ToList();
            DoctorCategoryCB.ItemsSource = MainWindow.ReabilCenterDB.DoctorCategory.ToList();
        }

        private void DoctorList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void DoctorCategoryCB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedCategoryCb = DoctorCategoryCB.SelectedItem as DoctorCategory;
            DoctorList.ItemsSource = MainWindow.ReabilCenterDB.Doctor.Where(c => c.IDDoctorCategory == selectedCategoryCb.IDDoctorCategory).ToList();
        }
    }
}
