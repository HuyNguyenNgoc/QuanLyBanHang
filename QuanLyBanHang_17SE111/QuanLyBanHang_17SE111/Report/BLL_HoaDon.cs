using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang_17SE111.Report
{
    public class BLL_HoaDon
    {
        Database data;
        public BLL_HoaDon()
        {
            data = new Database();
        }

        public DataTable LayDuLieuReport(ref  string err)
        {
            return data.GetDataTable(ref err, "HoaDon_Rp", CommandType.StoredProcedure, null);
        }
    }
}
