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

namespace Rehabilitation_Center.AuthPages
{
    /// <summary>
    /// Логика взаимодействия для AuthONacPage.xaml
    /// </summary>
    public partial class AuthONacPage : Page
    {
        public AuthONacPage()
        {
            InitializeComponent();
        }

        private void BtnGetStarted2_Click(object sender, RoutedEventArgs e)
        {
            AuthorizationWindow authorizationWindow = new AuthorizationWindow();
            authorizationWindow.Show();
        }
    }
}
