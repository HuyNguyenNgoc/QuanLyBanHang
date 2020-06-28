using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang_17SE111.QuanLyBanHang
{
    public class BLL_BanHang
    {
        Database data;
        public BLL_BanHang()
        {
            data = new Database();
        }
        /* public object LayMaxID(ref string err, DateTime ngayNhap)
         {
             return data.MyExecuteScalar(ref err, "PSP_HoaDon_LayMaxID", CommandType.StoredProcedure,
                 new SqlParameter("@NgayNhap", ngayNhap));
         }*/
        public bool XoaHoaDon(ref string err, ref int count, string maHoaDon)
        {
            return data.MyExcuteNonQuery(ref err, ref count, "PSP_HoaDon_XoaHoaDon", CommandType.StoredProcedure,
                new SqlParameter("@MaHoaDon", maHoaDon));
        }
        public bool InsertHoaDon(ref string err, ref int count, string maHoaDon, string maNV, DateTime ngayNhap)
        {
            return data.MyExcuteNonQuery(ref err, ref count, "PSP_HoaDon_Insert", CommandType.StoredProcedure,
                new SqlParameter("@MaHoaDon", maHoaDon),
                 new SqlParameter("@MaNV", maNV),
                  new SqlParameter("@NgayNhap", ngayNhap));
        }
        public DataTable LayDuLieuComboMaKH(ref string err)
        {
            return data.GetDataTable(ref err, "PSH_LayDuLieuCboMaKH", CommandType.StoredProcedure, null);
        }
        public DataTable LayDuLieuComboMaNV(ref string err)
        {
            return data.GetDataTable(ref err, "PSH_LayDuLieuCboMaNV", CommandType.StoredProcedure, null);
        }
        public DataTable LayDuLieuComboMaSP(ref string err)
        {
            return data.GetDataTable(ref err, "PSH_LayDuLieuCboMaSP", CommandType.StoredProcedure, null);
        }
    }
}
