using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using PhanMem_QuanLyKhoLinhKien.DTO;

namespace PhanMem_QuanLyKhoLinhKien.DAO
{
    class KhachHangDAO
    {
        public static DataTable TTKhachhang()
        {
            string sql = "SELECT * FROM KhachHang";
            DataTable dt = new DataTable();
            dt = KNCSDL.DocDuLieu(sql);
            return dt;
        }
        public static DataTable MaKH_LN()
        {
            string sql = "SELECT TOP 1 MaKH FROM KhachHang order by MaKH desc";
            DataTable dt = new DataTable();
            dt = KNCSDL.DocDuLieu(sql);
            return dt;
        }
        public static void Ghi_KH(KhachHangDTO kh)
        {
            string sql = "INSERT INTO KhachHang([MaKH],[TenKH],[SDT],[DiaChi],[NgayTao],[NgayCapNhat])VALUES('" +kh.Makh+ "',N'" +kh.Tenkh+ "','" +kh.Sdt+ "',N'" +kh.Diachi+ "','" +kh.Ngaytao+ "','" +kh.Ngaycapnhat+ "')";
            KNCSDL.ThucThiTruyVan(sql);
        }
        public static void Capnhat_KH(KhachHangDTO kh)
        {
            string sql = "UPDATE KhachHang SET TenKH=N'" +kh.Tenkh+ "',SDT='" +kh.Sdt+ "',DiaChi=N'" +kh.Diachi+ "',NgayTao='" +kh.Ngaytao+ "',NgayCapNhat='" +kh.Ngaycapnhat+ "' WHERE MaKH='" +kh.Makh+ "'";
            KNCSDL.ThucThiTruyVan(sql);
        }
        public static void Xoa_KH(KhachHangDTO kh)
        {
            string sql = "DELETE FROM KhachHang WHERE MaKH='" +kh.Makh+ "'";
            KNCSDL.ThucThiTruyVan(sql);
        }
        public static DataTable Tim_KH(KhachHangDTO kh)
        {
            string sql = "SELECT * FROM KhachHang WHERE TenKH like N'%" +kh.Tenkh+ "%'";
            DataTable dt = new DataTable();
            dt = KNCSDL.DocDuLieu(sql);
            return dt;
        }
    }
}
