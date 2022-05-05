﻿using System;
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
    /// Логика взаимодействия для PacientDoctorPage.xaml
    /// </summary>
    public partial class PacientDoctorPage : Page
    {
        public PacientDoctorPage()
        {
            InitializeComponent();
            PacientList.ItemsSource = MainWindow.ReabilCenterDB.Client.ToList();
        }
    }
}
