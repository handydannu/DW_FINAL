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
using FirstFloor.ModernUI.Windows.Controls;

namespace BAPPEDADW.ETL
{
    /// <summary>
    /// Interaction logic for ETL.xaml
    /// </summary>
    public partial class ETL : UserControl
    {
        ProsesETL package = new ProsesETL();
        public ETL()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ModernDialog.ShowMessage("EKSTRAK DATA ?", "INFORMASI !", MessageBoxButton.OK);
            package.Ekstrak();           
        }

       
    }
}
