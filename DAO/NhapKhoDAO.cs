using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using PhanMem_QuanLyKhoLinhKien.DTO;

namespace PhanMem_QuanLyKhoLinhKien.DAO
{
    class NhapKhoDAO
    {
        //in phieu nhap
        public static DataTable CrysNK(string mapnhap)
        {
            string sql = "Select STT,lk.MaLK,TenLK,spn.GiaNhap,spn.SLNhap,nk.NgayNhap,nv.MaNV,TenNV,nk.MaPNhap,TongTien,(SLNhap*GiaNhap) as ThanhTien from NhapKho nk,SPNhap spn, QLLK lk,NhanVien nv where nk.MaPNhap = spn.MaPNhap and lk.MaLK = spn.MaLK and nv.MaNV = nk.MaNV and nk.MaPNhap='"+mapnhap+"'";
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
        public static DataTable TNVtheoManv(string manv)
        {
            string sql = "select TenNV from NhanVien where MaNV='" + manv + "'";
            DataTable dt = new DataTable();
            dt = KNCSDL.DocDuLieu(sql);
            return dt;
        }
        public static DataTable TTSPNhap(NhapKhoDTO nk)
        {
            string sql = "select TenLK,SLNhap from QLLK,SPNhap where QLLK.MaLK=SPNhap.MaLK and MaPNhap='"+nk.Mapnhap+"'";
            DataTable dt = new DataTable();
            dt = KNCSDL.DocDuLieu(sql);
            return dt;
        }
        public static DataTable TimPNhap(NhapKhoDTO nk)
        {
            string sql = "select * from NhapKho where MaPNhap like '%"+nk.Mapnhap+"%'";
            DataTable dt = new DataTable();
            dt = KNCSDL.DocDuLieu(sql);
            return dt;
        }
        public static void XoaPNhap(NhapKhoDTO nk)
        {
            string sql = "delete from NhapKho where MaPNhap='"+nk.Mapnhap+"'";
            KNCSDL.ThucThiTruyVan(sql);
        }
        public static void XoaSPNhap(NhapKhoDTO nk)
        {
            string sql = "delete from SPNhap where MaPNhap='"+nk.Mapnhap+"'";
            KNCSDL.ThucThiTruyVan(sql);
        }
        public static void UpdatePNhap(NhapKhoDTO nk)
        {
            string sql = "update NhapKho set NgayNhap='"+nk.Ngaynhap+"',TongTien='"+nk.Tongtien+"' where MaPNhap='"+nk.Mapnhap+"'";
            KNCSDL.ThucThiTruyVan(sql);
        }
    }
}
