using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Dts.Runtime;
using FirstFloor.ModernUI.Windows.Controls;

namespace BAPPEDADW.ETL
{
    class ProsesETL
    {
        public void Ekstrak()
        {
            string pkgLocation;
            Package pkg;
            Application app;
            DTSExecResult pkgResults;

            pkgLocation = @"D:\github\DW_BAP_DANNU\BAPPEDADW\BAPPEDADW\ETL\Package.dtsx";
            app = new Application();
            pkg = app.LoadPackage(pkgLocation, null);
            pkgResults = pkg.Execute();
           
        }
    }
}
