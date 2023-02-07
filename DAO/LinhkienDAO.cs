using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using PhanMem_QuanLyKhoLinhKien.DTO;

namespace PhanMem_QuanLyKhoLinhKien.DAO
{
    class LinhkienDAO
    {
        public static DataTable TTLinhKien()
        {
            string sql = "SELECT * FROM QLLK";
            DataTable dt = new DataTable();
            dt = KNCSDL.DocDuLieu(sql);
            return dt;
        }
        public static DataTable TenNhomtheoManhom(string tn)
        {
            string sql = "select TenNhomLK from NhomLK,LoaiLK,ThuongHieu where NhomLK.MaNhomLK=LoaiLK.MaNhomLK and NhomLK.MaNhomLK=ThuongHieu.MaNhomLK and NhomLK.MaNhomLK='"+tn+"'";
            DataTable dt = new DataTable();
            dt = KNCSDL.DocDuLieu(sql);
            return dt;
        }
        public static DataTable TenloaitheoMaloai(string tl)
        {
            string sql = "select TenLoai from NhomLK,LoaiLK where NhomLK.MaNhomLK=LoaiLK.MaNhomLK and LoaiLK.MaLoaiLK='"+tl+"'";
            DataTable dt = new DataTable();
            dt = KNCSDL.DocDuLieu(sql);
            return dt;
        }
        public static DataTable TenTHtheoMaTH(string th)
        {
            string sql = "SELECT TenTH FROM ThuongHieu WHERE MaTH='" +th+ "'";
            DataTable dt = new DataTable();
            dt = KNCSDL.DocDuLieu(sql);
            return dt;
        }
        //Load combobox
        public static DataTable TTNhomLK_Combobox()
        {
            string sql = "SELECT * FROM NhomLK";
            DataTable dt = new DataTable();
            dt = KNCSDL.DocDuLieu(sql);
            return dt;
        }
        public static DataTable TTLoaiLK_Combobox()
        {
            string sql = "SELECT * FROM LoaiLK";
            DataTable dt = new DataTable();
            dt = KNCSDL.DocDuLieu(sql);
            return dt;
        }
        public static DataTable TTTH_Combobox()
        {
            string sql = "SELECT * FROM ThuongHieu";
            DataTable dt = new DataTable();
            dt = KNCSDL.DocDuLieu(sql);
            return dt;
        }

        public static DataTable TTloaiLKcuaLK(string lk)
        {
            string sql = "SELECT * FROM LoaiLK WHERE MaNhomLK='"+lk+"'";
            DataTable dt = new DataTable();
            dt = KNCSDL.DocDuLieu(sql);
            return dt;
        }
        public static DataTable TTTHcuaLK(string lk)
        {
            string sql = "SELECT * FROM ThuongHieu WHERE MaNhomLK='" +lk+ "'";
            DataTable dt = new DataTable();
            dt = KNCSDL.DocDuLieu(sql);
            return dt;
        }

        public static DataTable MaLK_LN()
        {
            string sql = "SELECT TOP 1 MaLK FROM QLLK order by MaLK desc";
            DataTable dt = new DataTable();
            dt = KNCSDL.DocDuLieu(sql);
            return dt;
        }

        public static DataTable Tim_LinhKien(LinhkienDTO lk)
        {
            string sql = "SELECT * FROM QLLK WHERE MaLK LIKE '%" +lk.Malk+ "%'";
            DataTable dt = new DataTable();
            dt = KNCSDL.DocDuLieu(sql);
            return dt;
        }

        public static DataTable TTLK_MaNhomLK(LinhkienDTO lk)
        {
            string sql = "SELECT MaLK,TenLK,Gia,MaTH,MaLoaiLK,BaoHanh,QLLK.MaNhomLK,Mota FROM QLLK,NhomLK WHERE QLLK.MaNhomLK=NhomLK.MaNhomLK and QLLK.MaNhomLK='" +lk.Nhomlk+ "'";
            DataTable dt = new DataTable();
            dt = KNCSDL.DocDuLieu(sql);
            return dt;
        }
        public static DataTable TTLK_MaLoaiLK(LinhkienDTO lk)
        {
            string sql = "SELECT MaLK,TenLK,Gia,MaTH,QLLK.MaLoaiLK,BaoHanh,QLLK.MaNhomLK,Mota FROM QLLK,LoaiLK WHERE QLLK.MaLoaiLK=LoaiLK.MaLoaiLK and QLLK.MaLoaiLK='"+ lk.Loailk +"'";
            DataTable dt = new DataTable();
            dt = KNCSDL.DocDuLieu(sql);
            return dt;
        }
        public static DataTable TTLK_MaTH(LinhkienDTO lk)
        {
            string sql = "SELECT MaLK,TenLK,Gia,QLLK.MaTH,QLLK.MaLoaiLK,BaoHanh,QLLK.MaNhomLK,Mota FROM QLLK,ThuongHieu WHERE QLLK.MaTH=ThuongHieu.MaTH and QLLK.MaTH='"+ lk.Thuonghieu +"'";
            DataTable dt = new DataTable();
            dt = KNCSDL.DocDuLieu(sql);
            return dt;
        }

        public static void Ghi_LinhKien(LinhkienDTO lk)
        {
            string sql = "INSERT INTO QLLK([MaLK],[TenLK],[Gia],[MaTH],[MaLoaiLK],[BaoHanh],[MaNhomLK],[Mota])VALUES('" +lk.Malk+ "',N'" +lk.Tenlk+ "','" +lk.Gia+ "','" +lk.Thuonghieu+ "','" +lk.Loailk+ "','" +lk.Baohanh+ "','" +lk.Nhomlk+ "','" +lk.Mota+ "')";
            KNCSDL.ThucThiTruyVan(sql);
        }
        public static void Xoa_LinhKien(LinhkienDTO lk)
        {
            string sql = "DELETE FROM QLLK WHERE MaLK='" +lk.Malk+ "'";
            KNCSDL.ThucThiTruyVan(sql);
        }
        public static void Sua_LinhKien(LinhkienDTO lk)
        {
            string sql = "UPDATE QLLK SET TenLK=N'" + lk.Tenlk + "',Gia='" + lk.Gia + "',MaTH='" + lk.Thuonghieu + "',MaLoaiLK='" + lk.Loailk + "',BaoHanh='" + lk.Baohanh + "',MaNhomLK='" +lk.Nhomlk + "',Mota=N'" +lk.Mota+ "' WHERE MaLK='" +lk.Malk+ "'";
            KNCSDL.ThucThiTruyVan(sql);
        }
    }
}
