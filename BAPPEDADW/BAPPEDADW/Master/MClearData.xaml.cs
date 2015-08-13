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

namespace BAPPEDADW.Master
{
    /// <summary>
    /// Interaction logic for MClearData.xaml
    /// </summary>
    public partial class MClearData : UserControl
    {
        public MClearData()
        {
            InitializeComponent();
        }

        private void bBersihkan_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxButton btn = MessageBoxButton.YesNo;
            var result = ModernDialog.ShowMessage("ANDA AKAN MENGOSONGKAN SELURUH DATA ?\nSELURUH DATA AKAN DIHAPUS PERMANEN.\nLANJUTKAN ?", "INFORMASI !", btn);
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
