using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace TH_report
{
    public partial class frmReportHoaDon: Form
    {
        public frmReportHoaDon()
        {
            InitializeComponent();
        }


        public void showReport(string reportFilePath, string reportTitle, string recordFilter)
        {
            ReportDocument rpt = new ReportDocument();
            rpt.Load(reportFilePath);

            TableLogOnInfo tableLogonInfo = new TableLogOnInfo();
            tableLogonInfo.ConnectionInfo.ServerName = "KHANG\\SQLEXPRESS02";
            tableLogonInfo.ConnectionInfo.DatabaseName = "db_Shop4Training";
            tableLogonInfo.ConnectionInfo.UserID = "khangbtl";
            tableLogonInfo.ConnectionInfo.Password = "123";

            foreach (Table t in rpt.Database.Tables)
            {
                t.ApplyLogOnInfo(tableLogonInfo);
            }

            rpt.RecordSelectionFormula = recordFilter;
            rpt.SummaryInfo.ReportTitle = reportTitle;
            crystalReportViewer1.ReportSource = rpt;
        }

        private void frmReportHoaDon_Load(object sender, EventArgs e)
        {

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void frmReportHoaDon_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (crystalReportViewer1.ReportSource is ReportDocument rpt)
            {
                rpt.Close();
                rpt.Dispose();
            }
        }
    }
}
