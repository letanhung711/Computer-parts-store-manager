using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using PhanMem_QuanLyKhoLinhKien.DTO;

namespace PhanMem_QuanLyKhoLinhKien.DAO
{
    class LoaiLKDAO
    {
        public static DataTable TTLoaiLK()
        {
            string sql = "SELECT * FROM LoaiLK";
            DataTable dt = new DataTable();
            dt = KNCSDL.DocDuLieu(sql);
            return dt;
        }
        public static DataTable TTNhomLKcuaLoaiLK()
        {
            string sql = "SELECT * FROM NhomLK";
            DataTable dt = new DataTable();
            dt = KNCSDL.DocDuLieu(sql);
            return dt;
        }
        public static DataTable TenNhomtheoMaNhom(string mn)
        {
            string sql = "SELECT TenNhomLK from NhomLK where MaNhomLK='" +mn+ "'";
            DataTable dt = new DataTable();
            dt = KNCSDL.DocDuLieu(sql);
            return dt;
        }
        public static void Them_LoaiLK(LoaiLKDTO lk)
        {
            string sql = "INSERT INTO LoaiLK([MaLoaiLK],[TenLoai],[MaNhomLK],[NgayTao],[NgayCapNhat])VALUES('" +lk.Maloai+ "',N'" +lk.Tenloai+ "','" +lk.Manhomlk+ "','" +lk.Ngaytao+ "','" +lk.Ngaycapnhat+ "')";
            KNCSDL.ThucThiTruyVan(sql);
        }
        public static void Xoa_LoaiLK(LoaiLKDTO lk)
        {
            string sql = "DELETE FROM LoaiLK WHERE MaLoaiLK='" +lk.Maloai+ "'";
            KNCSDL.ThucThiTruyVan(sql);
        }
        public static void Sua_LoaiLK(LoaiLKDTO lk)
        {
            string sql = "UPDATE LoaiLK SET TenLoai=N'" +lk.Tenloai+ "',NgayTao='" +lk.Ngaytao+ "',NgayCapNhat='" +lk.Ngaycapnhat+ "',MaNhomLK='" +lk.Manhomlk+ "' WHERE MaLoaiLK='" +lk.Maloai+ "'";
            KNCSDL.ThucThiTruyVan(sql);
        }
        public static DataTable TTLoaiLK_MaNhomLK(LoaiLKDTO lk)
        {
            string sql = "SELECT MaLoaiLK,TenLoai,NgayTao,NgayCapNhat,LoaiLK.MaNhomLK FROM LoaiLK,NhomLK WHERE LoaiLK.MaNhomLK=NhomLK.MaNhomLK and LoaiLK.MaNhomLK='" +lk.Manhomlk+ "'";
            DataTable dt = new DataTable();
            dt = KNCSDL.DocDuLieu(sql);
            return dt;
        }
    }
}
