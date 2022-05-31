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
    /// Логика взаимодействия для EditTherapy.xaml
    /// </summary>
    public partial class EditTherapy : Window
    {
        public EditTherapy(Therapy ter)
        {
            InitializeComponent();
            App.therapy = ter;
            EditNameTherapy.Text = ter.Name;
            EditPriceTherapy.Text = ter.Price;
        }

        private void BtnEditNewTherapy_Click(object sender, RoutedEventArgs e)
        {
            App.therapy.Name = EditNameTherapy.Text;
            App.therapy.Price = EditPriceTherapy.Text;
            Therapy.EditProd();
            MessageBox.Show("Терапия отредактирована");
            this.Close();
        }
    }
}
