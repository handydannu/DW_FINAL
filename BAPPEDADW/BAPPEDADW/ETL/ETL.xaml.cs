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
using Microsoft.SqlServer.Dts.Runtime; 

namespace BAPPEDADW.ETL
{
    /// <summary>
    /// Interaction logic for ETL.xaml
    /// </summary>
    public partial class ETL : UserControl
    {
        
        public ETL()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            eks.Visibility = Visibility.Hidden;
            lblstatus.Text = "EKSTRAK SEDANG DALAM PROSES MOHON TUNGGU SEBENTAR !";

            MessageBoxButton btn = MessageBoxButton.YesNo;
            var result = ModernDialog.ShowMessage("EKSTRAK DATA AKAN MENGHAPUS DATA SEBELUMNYA ! \n LANJUTKAN ?", "INFORMASI", btn);
            if (result.ToString() == "Yes")
            {

                Microsoft.SqlServer.Dts.Runtime.Application myApplication = new Microsoft.SqlServer.Dts.Runtime.Application();

                // Load package from file system (use LoadFromSqlServer for SQL Server based packages)
                Package myPackage = myApplication.LoadPackage(@"D:\github\DW_FINAL\BAPPEDADW\BAPPEDADW\Analisis\Package.dtsx", null);

                // Execute package
                DTSExecResult myResult = myPackage.Execute();

                lblstatus.Text = "HASIL EKSTRAKSI : " + myResult.ToString();

                // Show the execution result
            }


            eks.Visibility = Visibility.Visible;   


        }

       
    }
}
