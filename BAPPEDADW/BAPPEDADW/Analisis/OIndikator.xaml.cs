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
using DevExpress.Xpf.Printing;

namespace BAPPEDADW.Analisis
{
    /// <summary>
    /// Interaction logic for OIndikator.xaml
    /// </summary>
    public partial class OIndikator : UserControl
    {
        public OIndikator()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PrintableControlLink cetak = new PrintableControlLink(PivotOIndikator);
            cetak.PaperKind = System.Drawing.Printing.PaperKind.A4;
            cetak.Landscape = true;
            var win = Window.GetWindow(this);
            cetak.ShowPrintPreviewDialog(win, "LAPORAN");
        }
    }
}
