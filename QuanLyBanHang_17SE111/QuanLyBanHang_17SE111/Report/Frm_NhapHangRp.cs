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
    public partial class Frm_NhapHangRp : Form
    {
        public Frm_NhapHangRp()
        {
            InitializeComponent();
        }
        BLL_HoaDon bd;
        DataTable dtReport;
        string err = string.Empty;
        private void Frm_NhapHangRp_Load(object sender, EventArgs e)
        {
            this.rpVNhapHang.RefreshReport();
            bd = new BLL_HoaDon();
            LayDuLieuChoReport();
            rpVNhapHang.LocalReport.ReportEmbeddedResource = "QuanLyBanHang.Report.NhapHangrp.rdlc";
            rpVNhapHang.LocalReport.DataSources.Clear();
            ReportDataSource newDataSource = new ReportDataSource("nhaphang", dtReport);
            rpVNhapHang.LocalReport.DataSources.Add(newDataSource);
            this.rpVNhapHang.RefreshReport();
        }

        private void LayDuLieuChoReport()
        {
            dtReport = new DataTable();
            dtReport = bd.LayDuLieuReportNhaphang(ref err);
        }
    }
}
