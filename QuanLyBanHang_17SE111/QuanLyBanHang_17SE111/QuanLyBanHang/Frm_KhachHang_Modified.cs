﻿using System;
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
    public partial class Frm_KhachHang_Modified : Form
    {
        public Frm_KhachHang_Modified()
        {
            InitializeComponent();
        }
        BLL_KhachHang kh;
        public bool Them = false;
        string err = string.Empty;
        public DTO_KhachHang khachHang;
        int count = 0;

        private void Frm_KhachHang_Modified_Load(object sender, EventArgs e)
        {
            kh = new BLL_KhachHang();
            if (Them)
            {
                txtMaKH.Text = "";
                txtTenKH.Focus();
            }
            else //sửa
            {
                //view thông tin cần sửa
                LayDuLieuVaoControl(khachHang);
            }
        }

        private void LayDuLieuVaoControl(DTO_KhachHang khachHang)
        {
            txtMaKH.Text = khachHang.MaKH;
            txtTenKH.Text = khachHang.TenKH;
            txtDiaChi.Text = khachHang.DiaChi;
            txtDienThoai.Text = khachHang.DienThoai;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTenKH.Text))
            {
                LayThongTinKhachHangControl();
                if (kh.CapNhatKhachHang(ref err, ref count, khachHang))
                {
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Chưa thêm thành công");
                }
            }
            else
            {
                MessageBox.Show("Chưa nhập thành công");
                txtTenKH.Focus();
            }
        }

        private void LayThongTinKhachHangControl()
        {
            khachHang = new DTO_KhachHang();
            khachHang.MaKH = txtMaKH.Text;
            khachHang.TenKH = txtTenKH.Text;
            khachHang.DiaChi = txtDiaChi.Text;
            khachHang.DienThoai = txtDienThoai.Text;
            
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
