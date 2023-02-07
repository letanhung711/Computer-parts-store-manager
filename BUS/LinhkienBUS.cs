using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using PhanMem_QuanLyKhoLinhKien.DAO;
using PhanMem_QuanLyKhoLinhKien.DTO;

namespace PhanMem_QuanLyKhoLinhKien.BUS
{
    class LinhkienBUS
    {
        public static DataTable TTLinhKien()
        {
            DataTable dt = new DataTable();
            dt = LinhkienDAO.TTLinhKien();
            return dt;
        }
        public static void Ghi_LinhKien(LinhkienDTO lk)
        {
            try
            {
                LinhkienDAO.Ghi_LinhKien(lk);
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm linh kiện không thành công!");
            }
        }
        public static void Xoa_LinhKien(LinhkienDTO lk)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa linh kiện này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    LinhkienDAO.Xoa_LinhKien(lk);
                }
                catch (Exception)
                {
                    MessageBox.Show("Xóa linh kiện không thành công!");
                }
            }
        }
        public static void Sua_Linhkien(LinhkienDTO lk)
        {
            if (MessageBox.Show("Bạn có chắc muốn cập nhật thông tin linh kiện này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    LinhkienDAO.Sua_LinhKien(lk);
                }
                catch (Exception)
                {
                    MessageBox.Show("Sửa thông tin linh kiện không thành công!");
                }
            }
        }
    }
}
