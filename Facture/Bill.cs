
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facture
{
    public partial class Bill : Form
    {
        List<Product> _list;
        //string _total, _cash, _change, _date;

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        public Bill(List<Product> datasource)
        {
           // List<Product> datasource, string total, string cash, string change, string date
            InitializeComponent();
            _list = datasource;
           // _cash = cash;
            //_change = change;
            //_total = total;
            //_date = date;
        }

        private void Bill_Load(object sender, EventArgs e)
        {
            
            Random Run = new Random();
            this.reportViewer2.RefreshReport();
            this.reportViewer2.LocalReport.ReportPath = "RepProduct.rdlc";
            /*List<Product> produits = new List<Product>
            {
                new Product(Run.Next(),"Chocolate",1500,23),
                new Product(Run.Next(),"Spagehti",1000,8),
                new Product(Run.Next(),"Biscuit",2000,7),
                new Product(Run.Next(),"Detergent",500,29),
                new Product(Run.Next(),"Cereals",5000,2)
            };*/
            bindingSource1.DataSource = _list;
            this.reportViewer2.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", _list));
            this.reportViewer2.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            this.reportViewer2.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
            this.reportViewer2.ZoomPercent = 100;

            
            /*
            bindingSource1.DataSource = _list;
            this.reportViewer2.LocalReport.ReportPath = "RepStock.rdlc";
            this.reportViewer2.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DS", _list));
            Microsoft.Reporting.WinForms.ReportParameter[] para = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("pTotal",_total),
                new Microsoft.Reporting.WinForms.ReportParameter("pCash",_cash),
                new Microsoft.Reporting.WinForms.ReportParameter("pChange",_change),
                new Microsoft.Reporting.WinForms.ReportParameter("pDate",_date)
            };
            this.reportViewer2.LocalReport.SetParameters(para);
            this.reportViewer2.RefreshReport();*/

        }

        private void reportViewer2_Load(object sender, EventArgs e)
        {
            bindingSource1.DataSource = _list;
            this.reportViewer2.LocalReport.ReportPath = "RepProduct.rdlc";
            this.reportViewer2.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", _list));
            /*Microsoft.Reporting.WinForms.ReportParameter[] para = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("pTotal",_total),
                new Microsoft.Reporting.WinForms.ReportParameter("pCash",_cash),
                new Microsoft.Reporting.WinForms.ReportParameter("pChange",_change),
                new Microsoft.Reporting.WinForms.ReportParameter("pDate",_date)
            };*/
            //this.reportViewer2.LocalReport.SetParameters(para);
            this.reportViewer2.RefreshReport(); 
        }
    }
}
