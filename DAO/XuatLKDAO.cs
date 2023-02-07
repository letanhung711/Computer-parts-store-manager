using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using PhanMem_QuanLyKhoLinhKien.DTO;

namespace PhanMem_QuanLyKhoLinhKien.DAO
{
    class XuatLKDAO
    {
        public static DataTable XK_MAX()
        {
            string sql = "select top 1 MaPXuat from XuatKho order by MaPXuat desc";
            DataTable dt = new DataTable();
            dt = KNCSDL.DocDuLieu(sql);
            return dt;
        }
        public static void ThemXK(XuatKhoDTO xk)
        {
            string sql = "INSERT INTO XuatKho([MaPXuat],[MaNV],[MaKH],[NgayXuat],[TongSl],[TongTien]) VALUES ('"+xk.Mapxuat+"','"+xk.Manv+"','"+xk.Makh+"','"+xk.Ngayxuat+"',"+xk.Tongsl+","+xk.Tongtien+")";
            KNCSDL.ThucThiTruyVan(sql);
        }
        public static void ThemSPXuat(SPXuatDTO spx)
        {
            string sql = "INSERT INTO SPXuat([STT],[MaLK],[MaPXuat],[GiaXuat],[SLXuat]) VALUES ("+spx.Stt+",'"+spx.Malk+"','"+spx.Mapxuat+"',"+spx.Giaxuat+","+spx.Slxuat+")";
            KNCSDL.ThucThiTruyVan(sql);
        }
    }
}
