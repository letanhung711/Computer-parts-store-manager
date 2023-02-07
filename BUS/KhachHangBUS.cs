using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using PhanMem_QuanLyKhoLinhKien.DAO;
using PhanMem_QuanLyKhoLinhKien.DTO;

namespace PhanMem_QuanLyKhoLinhKien.BUS
{
    class KhachHangBUS
    {
        public static DataTable TTKhachhang()
        {
            DataTable dt = new DataTable();
            dt = KhachHangDAO.TTKhachhang();
            return dt;
        }
        public static void Ghi_KH(KhachHangDTO kh)
        {
            try
            {
                KhachHangDAO.Ghi_KH(kh);
            }
            catch
            {
                MessageBox.Show("Thêm khách hàng không thành công!");
            }
        }
        public static void Capnhat_KH(KhachHangDTO kh)
        {
            if(MessageBox.Show("Bạn có chắc muốn cập nhật khách hàng này?","Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    KhachHangDAO.Capnhat_KH(kh);
                }
                catch
                {
                    MessageBox.Show("Cập nhật khách hàng không thành công!");
                }
            }
        }
        public static void Xoa_KH(KhachHangDTO kh)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa khách hàng này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    KhachHangDAO.Xoa_KH(kh);
                }
                catch
                {
                    MessageBox.Show("Xóa khách hàng không thành công!");
                }
            }
        }
    }
}
