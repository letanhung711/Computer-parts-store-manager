using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using PhanMem_QuanLyKhoLinhKien.DTO;

namespace PhanMem_QuanLyKhoLinhKien.DAO
{
    class XuatKhoDAO
    {
        //in phieu xuat
        public static DataTable CrysXK(string mapxuat)
        {
            string sql = "Select STT,lk.MaLK,TenLK,SLXuat,GiaXuat,xk.NgayXuat,nv.MaNV,TenNV,kh.MaKH,TenKH,kh.DiaChi,kh.SDT,xk.MaPXuat,TongTien,(SLXuat*GiaXuat) as ThanhTien from XuatKho xk,SPXuat spx, QLLK lk,NhanVien nv,KhachHang kh where xk.MaPXuat = spx.MaPXuat and lk.MaLK = spx.MaLK and nv.MaNV = xk.MaNV and xk.MaKH=kh.MaKH and xk.MaPXuat='"+mapxuat+"'";
            DataTable dt = new DataTable();
            dt = KNCSDL.DocDuLieu(sql);
            return dt;
        }

        public static DataTable TTXK()
        {
            string sql = "select * from XuatKho";
            DataTable dt = new DataTable();
            dt = KNCSDL.DocDuLieu(sql);
            return dt;
        }
        public static DataTable TNVtheoManv(string manv)
        {
            string sql = "select TenNV from NhanVien where MaNV='"+manv+"'";
            DataTable dt = new DataTable();
            dt = KNCSDL.DocDuLieu(sql);
            return dt;
        }
        public static DataTable TKHtheoMakh(string makh)
        {
            string sql = "select TenKH from KhachHang where MaKH='" + makh + "'";
            DataTable dt = new DataTable();
            dt = KNCSDL.DocDuLieu(sql);
            return dt;
        }
        public static DataTable TTSPXuat(XuatKhoDTO xk)
        {
            string sql = "select TenLK,SLXuat from QLLK,SPXuat where QLLK.MaLK=SPXuat.MaLK and MaPXuat='"+xk.Mapxuat+"'";
            DataTable dt = new DataTable();
            dt = KNCSDL.DocDuLieu(sql);
            return dt;
        }
        public static DataTable TimPXuat(XuatKhoDTO xk)
        {
            string sql = "select * from XuatKho where MaPXuat like '%"+xk.Mapxuat+"%'";
            DataTable dt = new DataTable();
            dt = KNCSDL.DocDuLieu(sql);
            return dt;
        }
        public static void XoaPXuat(XuatKhoDTO xk)
        {
            string sql = "delete from XuatKho where MaPXuat='"+xk.Mapxuat+"'";
            KNCSDL.ThucThiTruyVan(sql);
        }
        public static void XoaSPXuat(XuatKhoDTO xk)
        {
            string sql = "delete from SPXuat where MaPXuat='"+xk.Mapxuat+"'";
            KNCSDL.ThucThiTruyVan(sql);
        }
        public static void CapNhatPXuat(XuatKhoDTO xk)
        {
            string sql = "update XuatKho set NgayXuat='"+xk.Ngayxuat+"',TongTien='"+xk.Tongtien+"' where MaPXuat='"+xk.Mapxuat+"'";
            KNCSDL.ThucThiTruyVan(sql);
        }
    }
}
