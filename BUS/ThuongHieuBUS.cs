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
    class ThuongHieuBUS
    {
        public static DataTable TTThuonghieu()
        {
            DataTable dt = new DataTable();
            dt = ThuongHieuDAO.TTThuonghieu();
            return dt;
        }
        public static void Them_TH(ThuongHieuDTO th)
        {
            try
            {
                ThuongHieuDAO.Them_TH(th);
            }
            catch
            {
                MessageBox.Show("Thêm thương hiệu không thành công!");
            }
        }
        public static void Xoa_TH(ThuongHieuDTO th)
        {
            if(MessageBox.Show("Bạn có chắc muốn xóa thương hiệu này?","Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    ThuongHieuDAO.Xoa_TH(th);
                }
                catch
                {
                    MessageBox.Show("Xóa thương hiệu không thành công!");
                }
            }
        }
        public static void Capnhat_TH(ThuongHieuDTO th)
        {
            if (MessageBox.Show("Bạn có chắc muốn cập nhật thương hiệu này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    ThuongHieuDAO.Capnhat_TH(th);
                }
                catch
                {
                    MessageBox.Show("Cập nhật thương hiệu không thành công!");
                }
            }
        }
    }
}
