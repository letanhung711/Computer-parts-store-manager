using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhanMem_QuanLyKhoLinhKien.BUS;
using PhanMem_QuanLyKhoLinhKien.DAO;
using PhanMem_QuanLyKhoLinhKien.DTO;

namespace PhanMem_QuanLyKhoLinhKien
{
    public partial class QLKhachHang : Form
    {
        public QLKhachHang()
        {
            InitializeComponent();
        }
        public void TT_Khachhang()
        {
            DataTable dt = new DataTable();
            dt = KhachHangBUS.TTKhachhang();
            int sokh = dt.Rows.Count;
            for(int i = 0; i < sokh; i++)
            {
                lvdanhsachKH.Items.Add(dt.Rows[i]["MaKH"].ToString());
                lvdanhsachKH.Items[i].SubItems.Add(dt.Rows[i]["TenKH"].ToString());
                lvdanhsachKH.Items[i].SubItems.Add(dt.Rows[i]["SDT"].ToString());
                lvdanhsachKH.Items[i].SubItems.Add(dt.Rows[i]["DiaChi"].ToString());
                lvdanhsachKH.Items[i].SubItems.Add(dt.Rows[i]["NgayTao"].ToString());
                lvdanhsachKH.Items[i].SubItems.Add(dt.Rows[i]["NgayCapNhat"].ToString());
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            KhachHangDTO kh = new KhachHangDTO();
            DataTable dt = new DataTable();
            kh.Tenkh = txtSearchTenKH.Text;
            lvdanhsachKH.Items.Clear();
            dt = KhachHangDAO.Tim_KH(kh);
            int sokh = dt.Rows.Count;
            for (int i = 0; i < sokh; i++)
            {
                lvdanhsachKH.Items.Add(dt.Rows[i]["MaKH"].ToString());
                lvdanhsachKH.Items[i].SubItems.Add(dt.Rows[i]["TenKH"].ToString());
                lvdanhsachKH.Items[i].SubItems.Add(dt.Rows[i]["SDT"].ToString());
                lvdanhsachKH.Items[i].SubItems.Add(dt.Rows[i]["DiaChi"].ToString());
                lvdanhsachKH.Items[i].SubItems.Add(dt.Rows[i]["NgayTao"].ToString());
                lvdanhsachKH.Items[i].SubItems.Add(dt.Rows[i]["NgayCapNhat"].ToString());
            }
        }
        private void QLKhachHang_Load(object sender, EventArgs e)
        {
            TT_Khachhang();
        }

        private void lvdanhsachKH_Click(object sender, EventArgs e)
        {
            txtMaKH.Text = lvdanhsachKH.SelectedItems[0].SubItems[0].Text;
            txtHoTenKH.Text = lvdanhsachKH.SelectedItems[0].SubItems[1].Text;
            txtSdt.Text = lvdanhsachKH.SelectedItems[0].SubItems[2].Text;
            txtDiachi.Text = lvdanhsachKH.SelectedItems[0].SubItems[3].Text;
            dtngaytao.Text = lvdanhsachKH.SelectedItems[0].SubItems[4].Text;
            dtngaycn.Text = lvdanhsachKH.SelectedItems[0].SubItems[5].Text;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtMaKH.Text = "";
            txtHoTenKH.Text = "";
            txtSdt.Text = "";
            txtDiachi.Text = "";
            dtngaytao.Text = "";
            dtngaycn.Text = "";
        }

        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            if (txtMaKH.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần cập nhật!", "Thông báo");
            }
            else
            {
                KhachHangDTO kh = new KhachHangDTO();
                kh.Makh = txtMaKH.Text;
                kh.Tenkh = txtHoTenKH.Text;
                kh.Sdt = txtSdt.Text;
                kh.Diachi = txtDiachi.Text;
                kh.Ngaytao = dtngaytao.Value.ToString("MM/dd/yyyy");
                kh.Ngaycapnhat = dtngaycn.Value.ToString("MM/dd/yyyy");
                KhachHangBUS.Capnhat_KH(kh);
                lvdanhsachKH.Items.Clear();
                TT_Khachhang();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaKH.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần xóa!", "Thông báo");
            }
            else
            {
                KhachHangDTO kh = new KhachHangDTO();
                kh.Makh = txtMaKH.Text;
                KhachHangBUS.Xoa_KH(kh);
                lvdanhsachKH.Items.Clear();
                TT_Khachhang();
            } 
        }

        private void txtSdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
