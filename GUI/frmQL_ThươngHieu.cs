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
    public partial class QLThuongHieu : Form
    {
        public QLThuongHieu()
        {
            InitializeComponent();
        }

        public void TT_Thuonghieu()
        {
            DataTable dt = new DataTable();
            dt = ThuongHieuBUS.TTThuonghieu();
            int SoTH = dt.Rows.Count;
            for (int i=0; i < SoTH; i++)
            {
                lvThuongHieu.Items.Add(dt.Rows[i]["MaTH"].ToString());
                lvThuongHieu.Items[i].SubItems.Add(dt.Rows[i]["TenTH"].ToString());
                lvThuongHieu.Items[i].SubItems.Add(dt.Rows[i]["MaNhomLK"].ToString());
                lvThuongHieu.Items[i].SubItems.Add(dt.Rows[i]["NgayTao"].ToString());
                lvThuongHieu.Items[i].SubItems.Add(dt.Rows[i]["NgayCapNhat"].ToString());
            }
        }
        public void TTNhomLK_Combobox()
        {
            DataTable dt = new DataTable();
            dt = ThuongHieuDAO.TTNhomLKcuaTH();
            cbNhomLK.DataSource = dt;
            cbNhomLK.ValueMember = "MaNhomLK";
            cbNhomLK.DisplayMember = "TenNhomLK";
        }

        private void QLThuongHieu_Load(object sender, EventArgs e)
        {
            TTNhomLK_Combobox();
            lvThuongHieu.Items.Clear();
            TT_Thuonghieu();
        }

        private void lvThuongHieu_Click(object sender, EventArgs e)
        {
            txtMaTH.Text = lvThuongHieu.SelectedItems[0].SubItems[0].Text;
            txtTenTH.Text = lvThuongHieu.SelectedItems[0].SubItems[1].Text;
            dtNgayTao.Text = lvThuongHieu.SelectedItems[0].SubItems[3].Text;
            dtNgaycn.Text = lvThuongHieu.SelectedItems[0].SubItems[4].Text;
            DataTable dt = new DataTable();
            dt = ThuongHieuDAO.TenNhomtheoMaNhom(lvThuongHieu.SelectedItems[0].SubItems[2].Text);
            cbNhomLK.Text = dt.Rows[0][0].ToString();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtMaTH.Text = "";
            txtTenTH.Text = "";
            cbNhomLK.Text = "";
            dtNgayTao.Text = "";
            dtNgaycn.Text = "";
        }

        private void cbNhomLK_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            ThuongHieuDTO th = new ThuongHieuDTO();
            th.Manhomlk = cbNhomLK.SelectedValue.ToString();
            dt = ThuongHieuDAO.TTTH_MaNhomLK(th);
            lvThuongHieu.Items.Clear();
            int SoTH = dt.Rows.Count;
            for (int i = 0; i < SoTH; i++)
            {
                lvThuongHieu.Items.Add(dt.Rows[i]["MaTH"].ToString());
                lvThuongHieu.Items[i].SubItems.Add(dt.Rows[i]["TenTH"].ToString());
                lvThuongHieu.Items[i].SubItems.Add(dt.Rows[i]["MaNhomLK"].ToString());
                lvThuongHieu.Items[i].SubItems.Add(dt.Rows[i]["NgayTao"].ToString());
                lvThuongHieu.Items[i].SubItems.Add(dt.Rows[i]["NgayCapNhat"].ToString());
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaTH.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!", "Thông báo");
                txtMaTH.Focus();
            }
            else
            {
                ThuongHieuDTO th = new ThuongHieuDTO();
                th.Math = txtMaTH.Text;
                th.Tenth = txtTenTH.Text;
                th.Manhomlk = cbNhomLK.SelectedValue.ToString();
                th.Ngaytao = dtNgayTao.Value.ToString("MM/dd/yyyy");
                th.Ngaycapnhat = dtNgaycn.Value.ToString("MM/dd/yyyy");
                ThuongHieuBUS.Them_TH(th);
                lvThuongHieu.Items.Clear();
                TT_Thuonghieu();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaTH.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn dòng thương hiệu cần xóa!", "Thông báo");
            }
            else
            {
                ThuongHieuDTO th = new ThuongHieuDTO();
                th.Math = txtMaTH.Text;
                ThuongHieuBUS.Xoa_TH(th);
                lvThuongHieu.Items.Clear();
                TT_Thuonghieu();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtMaTH.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn dòng thương hiệu cần cập nhật!", "Thông báo");
            }
            else
            {
                ThuongHieuDTO th = new ThuongHieuDTO();
                th.Math = txtMaTH.Text;
                th.Tenth = txtTenTH.Text;
                th.Manhomlk = cbNhomLK.SelectedValue.ToString();
                th.Ngaytao = dtNgayTao.Value.ToString("MM/dd/yyyy");
                th.Ngaycapnhat = dtNgaycn.Value.ToString("MM/dd/yyyy");
                ThuongHieuBUS.Capnhat_TH(th);
                lvThuongHieu.Items.Clear();
                TT_Thuonghieu();
            }
        }
    }
}
