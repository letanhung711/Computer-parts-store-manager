using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace PhanMem_QuanLyKhoLinhKien.DAO
{
    class KNCSDL
    {
        private static SqlConnection cnn = new SqlConnection();
        public static void MoKetNoi()
        {
            try
            {
                string sqlcon = @"Data Source=.\SQLEXPRESS;Initial Catalog=csdl_QLCHLK;Integrated Security=True";
                cnn.ConnectionString = sqlcon;
                if (cnn.State == ConnectionState.Closed)
                    cnn.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Ket noi khong thanh cong!!");
            }
        }
        public static void DongKetNoi()
        {
            if (cnn.State == ConnectionState.Open)
                cnn.Close();
        }
        public static DataTable DocDuLieu(string sql) //Dung trong cau truy van select
        {
            MoKetNoi();
            SqlCommand cd = new SqlCommand(sql,cnn);
            SqlDataReader dr = cd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            DongKetNoi();
            return dt;
        }
        public static void ThucThiTruyVan(string sql)
        {
            //Dung trong cau truy van insert,update,deletes
            MoKetNoi();
            SqlCommand cmd = new SqlCommand(sql,cnn);
            cmd.ExecuteNonQuery();
            DongKetNoi();
        }
    }
}
