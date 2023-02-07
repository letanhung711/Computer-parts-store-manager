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
    class NhanVienBUS
    {
        public static DataTable TTNhanVien()
        {
            DataTable dt = new DataTable();
            dt = NhanVienDAO.TTNhanVien();
            return dt;
        }
        public static void Ghi_NhanVien(NhanVienDTO nv)
        {
            try
            {
                NhanVienDAO.Ghi_NhanVien(nv);
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm nhân viên không thành công!");
            }
        }
        public static void Xoa_NhanVien(NhanVienDTO nv)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa nhân viên này?","Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    NhanVienDAO.Xoa_NhanVien(nv);
                }
                catch (Exception)
                {
                    MessageBox.Show("Xóa nhân viên không thành công!");
                }
            }
        }
        public static void Sua_NhanVien(NhanVienDTO nv)
        {
            if (MessageBox.Show("Bạn có chắc muốn cập nhật thông tin nhân viên này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    NhanVienDAO.Sua_NhanVien(nv);
                }
                catch (Exception)
                {
                    MessageBox.Show("Sửa thông tin nhân viên không thành công!");
                }
            }
        }
    }
}
