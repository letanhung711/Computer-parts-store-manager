using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using PhanMem_QuanLyKhoLinhKien.DTO;

namespace PhanMem_QuanLyKhoLinhKien.DAO
{
    class ThuongHieuDAO
    {
        public static DataTable TTThuonghieu()
        {
            string sql = "SELECT * FROM ThuongHieu";
            DataTable dt = new DataTable();
            dt = KNCSDL.DocDuLieu(sql);
            return dt;
        }
        public static DataTable TTNhomLKcuaTH()
        {
            string sql = "SELECT * FROM NhomLK";
            DataTable dt = new DataTable();
            dt = KNCSDL.DocDuLieu(sql);
            return dt;
        }
        public static DataTable TenNhomtheoMaNhom(string mn)
        {
            string sql = "SELECT TenNhomLK from NhomLK where MaNhomLK='" + mn + "'";
            DataTable dt = new DataTable();
            dt = KNCSDL.DocDuLieu(sql);
            return dt;
        }
        public static DataTable TTTH_MaNhomLK(ThuongHieuDTO th)
        {
            string sql = "SELECT MaTH,TenTH,ThuongHieu.MaNhomLK,NgayTao,NgayCapNhat FROM ThuongHieu,NhomLK WHERE ThuongHieu.MaNhomLK=NhomLK.MaNhomLK and ThuongHieu.MaNhomLK='" +th.Manhomlk+ "'";
            DataTable dt = new DataTable();
            dt = KNCSDL.DocDuLieu(sql);
            return dt;
        }
        public static void Them_TH(ThuongHieuDTO th)
        {
            string sql = "INSERT INTO ThuongHieu([MaTH],[TenTH],[MaNhomLK],[NgayTao],[NgayCapNhat])VALUES('" +th.Math+ "','" +th.Tenth+ "','" +th.Manhomlk+ "','" +th.Ngaytao+ "','" +th.Ngaycapnhat+ "')";
            KNCSDL.ThucThiTruyVan(sql);
        }
        public static void Xoa_TH(ThuongHieuDTO th)
        {
            string sql = "DELETE FROM ThuongHieu WHERE MaTH='" +th.Math+ "'";
            KNCSDL.ThucThiTruyVan(sql);
        }
        public static void Capnhat_TH(ThuongHieuDTO th)
        {
            string sql = "UPDATE ThuongHieu SET TenTH='" +th.Tenth+ "',MaNhomLK='" +th.Manhomlk+ "',NgayTao='" +th.Ngaytao+ "',NgayCapNhat='" +th.Ngaycapnhat+ "' WHERE MaTH='" +th.Math+ "'";
            KNCSDL.ThucThiTruyVan(sql);
        }
    }
}
