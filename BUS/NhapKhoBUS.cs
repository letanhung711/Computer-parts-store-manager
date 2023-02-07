using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhanMem_QuanLyKhoLinhKien.DAO;
using PhanMem_QuanLyKhoLinhKien.DTO;
using System.Windows.Forms;

namespace PhanMem_QuanLyKhoLinhKien.BUS
{
    class NhapKhoBUS
    {
        public static void XoaPNhap(NhapKhoDTO nk)
        {
            if(MessageBox.Show("Bạn có chắc muốn xóa phiếu này!","Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    NhapKhoDAO.XoaSPNhap(nk);
                    NhapKhoDAO.XoaPNhap(nk);
                }
                catch
                {
                    MessageBox.Show("Xóa phiếu không thành công!");
                }
            }
        }
        public static void UpdatePNhap(NhapKhoDTO nk)
        {
            if (MessageBox.Show("Bạn có chắc muốn cập nhật phiếu này!", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    NhapKhoDAO.UpdatePNhap(nk);
                }
                catch
                {
                    MessageBox.Show("Cập nhật phiếu không thành công!");
                }
            }
        }
    }
}
