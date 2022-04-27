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
    /// Логика взаимодействия для MyStatisticPage.xaml
    /// </summary>
    public partial class MyStatisticPage : Page
    {
        public MyStatisticPage()
        {
            InitializeComponent();
        }

        private void DatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            MessageBox.Show(ggwp.SelectedDate.ToString(), ggwp.Text);
        }
    }
}
