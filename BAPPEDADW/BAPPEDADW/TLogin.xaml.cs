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
using BAPPEDADW.Class;
using System.Data;

namespace BAPPEDADW
{
    /// <summary>
    /// Interaction logic for ModernWindow1.xaml
    /// </summary>
    public partial class TLogin : ModernWindow
    {
        private Koneksi sql = new Koneksi();
        string com;
        private DataTable log_db = new DataTable();

        public TLogin()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string username = Tbusername.Text;
            string password = Tbpassword.Password;

            if (username == "" || password == "")
            {
                ModernDialog.ShowMessage("USERNAME DAN PASSWORD TIDAK BOLEH KOSONG !", "KESALAHAN !", MessageBoxButton.OK);
            }
            else
            {
                com = "SELECT username FROM logon WHERE username='" + username + "' and password='" + password + "'";
                log_db = sql.tampil_data_dw(com);

                if (log_db.Rows.Count < 1)
                {
                    ModernDialog.ShowMessage("USERNAME ATAU PASSWORD SALAH !", "KESALAHAN !", MessageBoxButton.OK);
                }
                else
                {
                    var login_window = Window.GetWindow(this);
                    sql.init_dw();

                    TDepan a = new TDepan();
                    a.Show();
                    if(login_window !=null)
                    {
                        login_window.Close();
                    }
                }

            }
            
        }

    }
}
