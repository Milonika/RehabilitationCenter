﻿using Rehabilitation_Center.Data;
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
    /// Логика взаимодействия для DeleteTherapy.xaml
    /// </summary>
    public partial class DeleteTherapy : Window
    {
        public Therapy terapia;
        public DeleteTherapy(Therapy therapy)
        {
            InitializeComponent();
            terapia = therapy;
        }

        private void Button_Click(object sender, RoutedEventArgs e) // удалить
        {
            this.DialogResult = true;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            EditTherapy editTherapy = new EditTherapy(terapia);
            editTherapy.Show();
            this.Close();
        }
    }
}
