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

namespace GUI
{
    public partial class report: Form
    {
        public report()
        {
            InitializeComponent();
        }

        public void showReport()
        {
            ReportDocument rpt = new ReportDocument();
            rpt.Load("D:\\C#\\BaiTap\\TestReport\\GUI\\CrystalReport1.rpt");

            TableLogOnInfo tableLogonInfo = new TableLogOnInfo();
            tableLogonInfo.ConnectionInfo.ServerName = "KHANG\\SQLEXPRESS02";
            tableLogonInfo.ConnectionInfo.DatabaseName = "QuanLyThuPhiNuocSach";
            tableLogonInfo.ConnectionInfo.UserID = "khang";
            tableLogonInfo.ConnectionInfo.Password = "123";

            foreach (Table t in rpt.Database.Tables)
            {
                t.ApplyLogOnInfo(tableLogonInfo);
            }

            crystalReportViewer1.ReportSource = rpt;
        }
    }
}
