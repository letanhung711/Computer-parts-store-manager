using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using PhanMem_QuanLyKhoLinhKien.DTO;

namespace PhanMem_QuanLyKhoLinhKien.DAO
{
    class NhapLKDAO
    {
        public static DataTable NK_Max()
        {
            string sql = "select top 1 MaPNhap from NhapKho order by MaPNhap desc";
            DataTable dt = new DataTable();
            dt = KNCSDL.DocDuLieu(sql);
            return dt;
        }
        public static DataTable TTNK()
        {
            string sql = "SELECT * FROM NhapKho";
            DataTable dt = new DataTable();
            dt = KNCSDL.DocDuLieu(sql);
            return dt;
        }
        public static DataTable TenLKtheoMaLK(LinhkienDTO lk)
        {
            string sql = "select * from QLLK where MaLK='"+lk.Malk+"'";
            DataTable dt = new DataTable();
            dt = KNCSDL.DocDuLieu(sql);
            return dt;
        }
        public static void ThemNK(NhapKhoDTO nk)
        {
            string sql = "INSERT INTO NhapKho([MaPNhap],[MaNV],[NgayNhap],[TongSL],[TongTien]) VALUES ('"+nk.Mapnhap+"','"+nk.Manv+"','"+nk.Ngaynhap+"',"+nk.Tongsl+","+nk.Tongtien+")";
            KNCSDL.ThucThiTruyVan(sql);
        }
        public static void ThemSPNhap(SPNhapDTO spn)
        {
            string sql = "INSERT INTO SPNhap([STT],[MaLK],[MaPNhap],[GiaNhap],[SLNhap]) VALUES ("+spn.Stt+",'"+spn.Malk+"','"+spn.Mapnhap+"',"+spn.Gianhap+","+spn.Slnhap+")";
            KNCSDL.ThucThiTruyVan(sql);
        }
    }
}
