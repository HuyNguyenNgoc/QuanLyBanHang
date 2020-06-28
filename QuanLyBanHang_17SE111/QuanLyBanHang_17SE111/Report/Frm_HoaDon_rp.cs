using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang_17SE111.Report
{
    public partial class Frm_HoaDon_rp : Form
    {
        public Frm_HoaDon_rp()
        {
            InitializeComponent();
        }
        BLL_HoaDon bd;
        DataTable dtReport;
        string err = string.Empty;
        private void Frm_HoaDon_rp_Load(object sender, EventArgs e)
        {
            this.rpVHoaDon.RefreshReport();
            bd = new BLL_HoaDon();
            LayDuLieuChoReport();
            rpVHoaDon.LocalReport.ReportEmbeddedResource = "QuanLyBanHang.Report.HoaDonrp.rdlc";
            rpVHoaDon.LocalReport.DataSources.Clear();
            ReportDataSource newDataSource = new ReportDataSource("hoadon", dtReport);
            rpVHoaDon.LocalReport.DataSources.Add(newDataSource);
            this.rpVHoaDon.RefreshReport();
        }

        private void LayDuLieuChoReport()
        {
            dtReport = new DataTable();
            dtReport = bd.LayDuLieuReport(ref err);
        }

    }
}
