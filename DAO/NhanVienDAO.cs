using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using PhanMem_QuanLyKhoLinhKien.DTO;

namespace PhanMem_QuanLyKhoLinhKien.DAO
{
    class NhanVienDAO
    {
        public static DataTable TK_MK(NhanVienDTO nv)
        {
            string sql = "SELECT * FROM NhanVien WHERE MaNV='" +nv.Manv+ "' and MatKhau='" +nv.Matkhau+ "'";
            DataTable dt = new DataTable();
            dt = KNCSDL.DocDuLieu(sql);
            return dt;
        }
        public static DataTable TTNhanVien()
        {
            string sql = "SELECT MaNV,MatKhau,TenNV,SDT,GioiTinh,DiaChi,ChucVu.TenCV FROM NhanVien,ChucVu WHERE NhanVien.MaCV=ChucVu.MaCV";
            DataTable dt = new DataTable();
            dt = KNCSDL.DocDuLieu(sql);
            return dt;
        }
        public static DataTable TTCVcuaNV()
        {
            string sql = "SELECT * FROM ChucVu";
            DataTable dt = new DataTable();
            dt = KNCSDL.DocDuLieu(sql);
            return dt;
        }
        public static DataTable MaNV_LN()
        {
            string sql = "SELECT TOP 1 MaNV FROM NhanVien order by MaNV desc";
            DataTable dt = new DataTable();
            dt = KNCSDL.DocDuLieu(sql);
            return dt;
        }
        public static DataTable Tim_NhanVien(NhanVienDTO nv)
        {
            string sql = "SELECT * FROM NhanVien WHERE TenNV LIKE N'%" +nv.Tennv+ "%'";
            DataTable dt = new DataTable();
            dt = KNCSDL.DocDuLieu(sql);
            return dt;
        }
        public static void Ghi_NhanVien(NhanVienDTO nv)
        {
            string sql = "INSERT INTO NhanVien([MaNV],[TenNV],[GioiTinh],[DiaChi],[SDT],[MatKhau],[MaCV])VALUES('" +nv.Manv+ "',N'" +nv.Tennv+ "'," +nv.Gioitinh+ ",N'" +nv.Diachi+ "','" +nv.Sdt+ "','" +nv.Matkhau+ "','" +nv.Chucvu+ "')";
            KNCSDL.ThucThiTruyVan(sql);
        }
        public static void Xoa_NhanVien(NhanVienDTO nv)
        {
            string sql = "DELETE FROM NhanVien WHERE MaNV='" +nv.Manv+ "'";
            KNCSDL.ThucThiTruyVan(sql);
        }
        public static void Sua_NhanVien(NhanVienDTO nv)
        {
            string sql = "UPDATE NhanVien SET TenNV=N'" +nv.Tennv+ "',SDT='" +nv.Sdt+ "',GioiTinh=" +nv.Gioitinh+ ",MatKhau='" +nv.Matkhau+ "',DiaChi=N'" +nv.Diachi+ "',MaCV='" +nv.Chucvu+ "' WHERE MaNV='" +nv.Manv+ "'";
            KNCSDL.ThucThiTruyVan(sql);
        }
    }
}
