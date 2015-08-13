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
using FirstFloor.ModernUI.Windows.Controls;

namespace BAPPEDADW.Fakta
{
    /// <summary>
    /// Interaction logic for FBelanja.xaml
    /// </summary>
    public partial class FBelanja : UserControl
    {
        private Koneksi sql = new Koneksi();
        private DataTable data_dimensi = new DataTable(); 
        public FBelanja()
        {
            InitializeComponent();
        }

        DataTable dt_TempData = new DataTable();

        private int paging_PageIndex = 1;
        private int paging_NoOfRecPerPage = 15;
        private enum PagingMode { First = 1, Next = 2, Previous = 3, Last = 4 };


        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            ListData();
        }

        private void bAwal_Click(object sender, RoutedEventArgs e)
        {
            CustomPaging((int)PagingMode.First);
        }

        private void bNext_Click(object sender, RoutedEventArgs e)
        {
            CustomPaging((int)PagingMode.Next);
        }

        private void bPrev_Click(object sender, RoutedEventArgs e)
        {
            CustomPaging((int)PagingMode.Previous);
        }

        private void bAkhir_Click(object sender, RoutedEventArgs e)
        {
            CustomPaging((int)PagingMode.Last);
        }

        private void ListData()
        {
            DataTable dt = new DataTable();


            Koneksi koneksi = new Koneksi();
            dt = koneksi.tampil_data_dw("SELECT fbel_tahun as 'TAHUN',fbel_id as 'BELANJA ID',fbel_kd_keg as 'KODE KEGIATAN',fbel_satuan as 'BANYAK SATUAN',fbel_nilai as 'NILAI',fbel_total as 'TOTAL BELANJA' FROM fakta_belanja");
            try
            {
                paging_PageIndex = 1;

                if (dt.Rows.Count > 0)
                {
                    DataTable tmpTable = new DataTable();

                    tmpTable = dt.Clone();

                    if (dt.Rows.Count >= paging_NoOfRecPerPage)
                    {
                        for (int i = 0; i < paging_NoOfRecPerPage; i++)
                        {
                            tmpTable.ImportRow(dt.Rows[i]);
                        }
                    }
                    else
                    {
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            tmpTable.ImportRow(dt.Rows[i]);
                        }
                    }

                    listDatafakta.DataContext = tmpTable.DefaultView;
                    tmpTable.Dispose();
                    dt_TempData = dt;
                }
                else
                {
                    // MessageBox.Show("Message");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Message" + ex);
            }
        } //void closing

        private void CustomPaging(int mode)
        {
            int totalRecords = dt_TempData.Rows.Count;
            int pageSize = paging_NoOfRecPerPage;

            if (totalRecords <= pageSize)
            {
                return;
            }

            switch (mode)
            {
                case (int)PagingMode.Next:
                    if (totalRecords > (paging_PageIndex * pageSize))
                    {
                        DataTable tmpTable = new DataTable();
                        tmpTable = dt_TempData.Clone();

                        if (totalRecords >= ((paging_PageIndex * pageSize) + pageSize))
                        {
                            for (int i = paging_PageIndex * pageSize; i < ((paging_PageIndex * pageSize) + pageSize); i++)
                            {
                                tmpTable.ImportRow(dt_TempData.Rows[i]);
                            }
                        }
                        else
                        {
                            for (int i = paging_PageIndex * pageSize; i < totalRecords; i++)
                            {
                                tmpTable.ImportRow(dt_TempData.Rows[i]);
                            }
                        }

                        paging_PageIndex += 1;

                        listDatafakta.DataContext = tmpTable.DefaultView;
                        tmpTable.Dispose();
                    }
                    break;
                case (int)PagingMode.Previous:
                    if (paging_PageIndex > 1)
                    {
                        DataTable tmpTable = new DataTable();
                        tmpTable = dt_TempData.Clone();

                        paging_PageIndex -= 1;

                        for (int i = ((paging_PageIndex * pageSize) - pageSize); i < (paging_PageIndex * pageSize); i++)
                        {
                            tmpTable.ImportRow(dt_TempData.Rows[i]);
                        }

                        listDatafakta.DataContext = tmpTable.DefaultView;
                        tmpTable.Dispose();
                    }
                    break;
                case (int)PagingMode.First:
                    paging_PageIndex = 2;
                    CustomPaging((int)PagingMode.Previous);
                    break;
                case (int)PagingMode.Last:
                    paging_PageIndex = (totalRecords / pageSize);
                    CustomPaging((int)PagingMode.Next);
                    break;
            }
            DisplayPagingInfo();
        }

        private void DisplayPagingInfo()
        {
            // There is no need for these variables but i created them just for readability
            int totalRecords = dt_TempData.Rows.Count;
            int pageSize = paging_NoOfRecPerPage;

            string pagingInfo = "Displaying " + (((paging_PageIndex - 1) * pageSize) + 1) + " to " + paging_PageIndex * pageSize;

            if (dt_TempData.Rows.Count < (paging_PageIndex * pageSize))
            {
                pagingInfo = "Displaying " + (((paging_PageIndex - 1) * pageSize) + 1) + " to " + totalRecords;
            }
            // lblPagingInfo.Content = pagingInfo;
            PageNum.Content = paging_PageIndex;
        }
    }
}
