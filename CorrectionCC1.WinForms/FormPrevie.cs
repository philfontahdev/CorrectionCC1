using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CorrectionCC1.WinForms
{
    public partial class FormPrevie : Form
    {
        public FormPrevie()
        {
            InitializeComponent();
        }

        private void FormPrevie_Load(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.ReportPath = "RptUser.rdlc";
            List<UserList> users = new List<UserList>
            {
                new UserList("markusjohn@adode.com" ,"markus"),
                new UserList("jamesmarkus@adode.com","James")
            };
            this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1",users));
            this.reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
            this.reportViewer1.ZoomPercent = 100;
            this.reportViewer1.RefreshReport();
        }
    }
}
