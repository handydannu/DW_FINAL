using FirstFloor.ModernUI.Windows.Controls;
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
using FirstFloor.ModernUI;
using BAPPEDADW.Class;


namespace BAPPEDADW
{
    /// <summary>
    /// Interaction logic for TDepan.xaml
    /// </summary>
    public partial class TDepan : ModernWindow
    {
        public TDepan()
        {
            InitializeComponent();
        }

        private void ETLklik(object sender, RoutedEventArgs e)
        {
            TEtl bs = new TEtl();
            bs.Show();
            this.Close();
        }

        private void FaktaKlik(object sender, RoutedEventArgs e)
        {
            Tfakta bs= new Tfakta();
            bs.Show();
            this.Close();
            
        }

        private void OlapKlik(object sender, RoutedEventArgs e)
        {
            TOlap bb = new TOlap();
            bb.Show();
            this.Close();
        }

        private void DimensiKlik(object sender, RoutedEventArgs e)
        {
            TDimensi bb = new TDimensi();
            bb.Show();
            this.Close();
        }

        private void BKeluar_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxButton btn = MessageBoxButton.YesNo;
            var result = ModernDialog.ShowMessage("KELUAR DARI SISTEM ?", "KELUAR", btn);
            if (result.ToString() == "Yes")
            {
                var logoutWindow = Window.GetWindow(this);
                TLogin mainWindow = new TLogin();
                mainWindow.Show();
                if (logoutWindow != null)
                    logoutWindow.Close();
            }
        }      

    }
}
