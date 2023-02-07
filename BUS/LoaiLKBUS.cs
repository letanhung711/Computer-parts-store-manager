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
    class LoaiLKBUS
    {
        public static DataTable TTLoaiLK()
        {
            DataTable dt = new DataTable();
            dt = LoaiLKDAO.TTLoaiLK();
            return dt;
        }
        public static void Them_LoaiLK(LoaiLKDTO lk)
        {
            try
            {
                LoaiLKDAO.Them_LoaiLK(lk);
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm loại linh kiện không thành công!");
            }
        }
        public static void Xoa_LoaiLK(LoaiLKDTO lk)
        {
            if(MessageBox.Show("Bạn có chắc muốn xóa loại linh kiện này?","Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    LoaiLKDAO.Xoa_LoaiLK(lk);
                }
                catch (Exception)
                {
                    MessageBox.Show("Xóa loại linh kiện không thành công!");
                }
            }
        }
        public static void Sua_LoaiLK(LoaiLKDTO lk)
        {
            if (MessageBox.Show("Bạn có chắc muốn sửa thông tin loại linh kiện này?","Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    LoaiLKDAO.Sua_LoaiLK(lk);
                }
                catch (Exception)
                {
                    MessageBox.Show("Sửa thông tin loại linh kiện không thành công!");
                }
            }
        }
    }
}
