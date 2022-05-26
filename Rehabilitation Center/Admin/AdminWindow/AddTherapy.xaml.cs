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

namespace Rehabilitation_Center.Admin.AdminWindow
{
    /// <summary>
    /// Логика взаимодействия для AddTherapy.xaml
    /// </summary>
    public partial class AddTherapy : Window
    {
        public AddTherapy()
        {
            InitializeComponent();
        }

        private void BtnAddNewTherapy_Click(object sender, RoutedEventArgs e)
        {
            Therapy addtherapy = new Therapy(AddNameTherapy.Text, AddPriceTherapy.Text);
            Therapy.AddTherapy(addtherapy);
            MessageBox.Show("Вы добавили новую терапию");
        }
    }
}
