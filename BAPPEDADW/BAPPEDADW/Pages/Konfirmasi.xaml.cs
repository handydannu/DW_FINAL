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
using FirstFloor.ModernUI;
using FirstFloor.ModernUI.Windows.Controls;

namespace BAPPEDADW.Pages
{
    /// <summary>
    /// Interaction logic for Konfirmasi.xaml
    /// </summary>
    public partial class Konfirmasi : UserControl
    {
        public Konfirmasi()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TDepan x = new TDepan();
            Window y = Window.GetWindow(this);

            x.Show();
            y.Close();
        }

       
    }
}
