using QuanLyBanHang_17SE111.Report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang_17SE111.QuanLyBanHang
{
    public partial class Frm_BanHang : Form
    {
        public Frm_BanHang()
        {
            InitializeComponent();
        }

        BLL_BanHang db;
        string err = string.Empty;
        bool statusInHoaDon = false;
        int count = 0;
        private void btnHuy_Click(object sender, EventArgs e)
        {
            HuyVaTaoMoiHoaDon();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            Frm_HoaDon_rp rp = new Frm_HoaDon_rp();
            rp.ShowDialog();
        }

        private void Frm_BanHang_Load(object sender, EventArgs e)
        {
            db = new BLL_BanHang();
            LayDuLieuVaoCboMaKH();
            LayDuLieuVaoCboMaNV();
            LayDuLieuVaoCboMaSP();
            //TaoMaHoaDon(dtNgayLap.Value);
        }
        /*private void TaoMaHoaDon(DateTime ngayTao)
        {
            string maHoaDon = string.Empty;
            object obj = db.LayMaxID(ref err, ngayTao);
            if (obj != null)
            {
                maHoaDon = string.Format("{0}{1:00}{2:00000000}", ngayTao.Year.ToString().Substring(2, 2), ngayTao.Month, Convert.ToInt32(obj.ToString()) + 1);
            }
            else
            {
                maHoaDon = string.Empty;
            }
            Cls_Main.maHoaDonHienTai = maHoaDon;
            lblMaHoaDonHienTai.Text = string.Format("Mã HD: {0}", Cls_Main.maHoaDonHienTai);
            statusInHoaDon = false;
            InsertMaHoaDon(Cls_Main.maHoaDonHienTai);
        }*/
        private void InsertMaHoaDon(string maHoaDon)
        {
            db.InsertHoaDon(ref err, ref count, maHoaDon, Cls_Main.maNhanVien, dtNgayLap.Value);
        }
        private void Frm_BanHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!statusInHoaDon)
            {
                //xóa
                if (!string.IsNullOrEmpty(Cls_Main.maHoaDonHienTai))
                    db.XoaHoaDon(ref err, ref count, Cls_Main.maHoaDonHienTai);
            }
        }

        private void dtNgayLap_ValueChanged(object sender, EventArgs e)
        {
            //TaoMaHoaDon(dtNgayLap.Value);
        }
        private void HuyVaTaoMoiHoaDon()
        {
            if (!statusInHoaDon)
            {
                if (!string.IsNullOrEmpty(Cls_Main.maHoaDonHienTai))
                    db.XoaHoaDon(ref err, ref count, Cls_Main.maHoaDonHienTai);
            }
            //tao hd moi
            //TaoMaHoaDon(dtNgayLap.Value);
        }
        private void LayDuLieuVaoCboMaKH()
        {
            DataTable dtKhachHang = new DataTable();
            dtKhachHang = db.LayDuLieuComboMaKH(ref err);
            cboMakhach.DataSource = dtKhachHang;
            cboMakhach.ValueMember = "MaKH";
            cboMakhach.DisplayMember = "MaKH";
            cboMakhach.SelectedIndex = -1;
            cboMakhach.Text = "Mã khách hàng";
        }
        private void LayDuLieuVaoCboMaNV()
        {
            DataTable dtKhachHang = new DataTable();
            dtKhachHang = db.LayDuLieuComboMaNV(ref err);
            cboManhanvien.DataSource = dtKhachHang;
            cboManhanvien.ValueMember = "MaNhanVien";
            cboManhanvien.DisplayMember = "MaNhanVien";
            cboManhanvien.SelectedIndex = -1;
            cboManhanvien.Text = "Mã nhân viên";
        }
        private void LayDuLieuVaoCboMaSP()
        {
            DataTable dtKhachHang = new DataTable();
            dtKhachHang = db.LayDuLieuComboMaSP(ref err);
            cboMahang.DataSource = dtKhachHang;
            cboMahang.ValueMember = "MaSanPham";
            cboMahang.DisplayMember = "MaSanPham";
            cboMahang.SelectedIndex = -1;
            cboMahang.Text = "Mã sản phẩm";
        }
    }
}
