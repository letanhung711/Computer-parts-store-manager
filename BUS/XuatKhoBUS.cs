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
    class XuatKhoBUS
    {
        public static void XoaPXuat(XuatKhoDTO xk)
        {
            if(MessageBox.Show("Bạn có muốn xóa phiếu xuất này!","Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    XuatKhoDAO.XoaSPXuat(xk);
                    XuatKhoDAO.XoaPXuat(xk);
                }
                catch
                {
                    MessageBox.Show("Xóa phiếu xuất không thành công!");
                }
            }
        }
        public static void CapNhatPXuat(XuatKhoDTO xk)
        {
            if (MessageBox.Show("Bạn có muốn cập nhật phiếu xuất này!", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    XuatKhoDAO.CapNhatPXuat(xk);
                }
                catch
                {
                    MessageBox.Show("Cập nhật phiếu xuất không thành công!");
                }
            }
        }
    }
}
