using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhanMem_QuanLyKhoLinhKien.DAO;
using PhanMem_QuanLyKhoLinhKien.DTO;
using PhanMem_QuanLyKhoLinhKien.BUS;

namespace PhanMem_QuanLyKhoLinhKien.GUI
{
    public partial class frmXuatkho : Form
    {
        public frmXuatkho()
        {
            InitializeComponent();
        }

        public void TT_XK()
        {
            DataTable dt = new DataTable();
            dt = XuatKhoDAO.TTXK();
            int sodong = dt.Rows.Count;
            for(int i = 0; i < sodong; i++)
            {
                lvds.Items.Add(dt.Rows[i]["MaPXuat"].ToString());
                lvds.Items[i].SubItems.Add(dt.Rows[i]["TongSl"].ToString());
                lvds.Items[i].SubItems.Add(dt.Rows[i]["NgayXuat"].ToString());
                lvds.Items[i].SubItems.Add(dt.Rows[i]["MaNV"].ToString());
                lvds.Items[i].SubItems.Add(dt.Rows[i]["MaKH"].ToString());
                lvds.Items[i].SubItems.Add(dt.Rows[i]["TongTien"].ToString());
            }
        }

        private void frmXuatkho_Load(object sender, EventArgs e)
        {
            TT_XK();
        }

        private void lvds_Click(object sender, EventArgs e)
        {
            txtMapxuat.Text = lvds.SelectedItems[0].SubItems[0].Text;
            txttongsl.Text= lvds.SelectedItems[0].SubItems[1].Text;
            dtpNgayxuat.Text= lvds.SelectedItems[0].SubItems[2].Text;
            DataTable dttt = new DataTable();
            dttt = XuatKhoDAO.TNVtheoManv(lvds.SelectedItems[0].SubItems[3].Text);
            txtNV.Text = dttt.Rows[0][0].ToString();
            dttt = XuatKhoDAO.TKHtheoMakh(lvds.SelectedItems[0].SubItems[4].Text);
            txtKH.Text= dttt.Rows[0][0].ToString();
            txttongtien.Text= lvds.SelectedItems[0].SubItems[5].Text;

            //San pham xuat
            DataTable dt = new DataTable();
            XuatKhoDTO xk = new XuatKhoDTO();
            xk.Mapxuat = lvds.SelectedItems[0].SubItems[0].Text;
            dt = XuatKhoDAO.TTSPXuat(xk);
            int sodong = dt.Rows.Count;
            for(int i = 0; i < sodong; i++)
            {
                lvlk.Items.Add(dt.Rows[i]["TenLK"].ToString());
                lvlk.Items[i].SubItems.Add(dt.Rows[i]["SLXuat"].ToString());
            }
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            txtMapxuat.Text = "";
            txtKH.Text = "";
            txtNV.Text = "";
            txttongsl.Text = "";
            txttongtien.Text = "";
            dtpNgayxuat.Text = "";
            txtSearchpxuat.Text = "";
            lvlk.Items.Clear();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (txtMapxuat.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn phiếu xuất cần xóa!", "Thông báo");
            }
            else
            {
                XuatKhoDTO xk = new XuatKhoDTO();
                xk.Mapxuat = txtMapxuat.Text;
                XuatKhoBUS.XoaPXuat(xk);
                lvds.Items.Clear();
                TT_XK();
            } 
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            if (txtMapxuat.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn phiếu xuất cần chỉnh sửa!", "Thông báo");
            }
            else
            {
                XuatKhoDTO xk = new XuatKhoDTO();
                xk.Mapxuat = txtMapxuat.Text;
                xk.Ngayxuat = dtpNgayxuat.Value.ToString("MM/dd/yyyy");
                xk.Tongtien = int.Parse(txttongtien.Text);
                XuatKhoBUS.CapNhatPXuat(xk);
                lvds.Items.Clear();
                TT_XK();
            }
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            XuatKhoDTO xk = new XuatKhoDTO();
            xk.Mapxuat = txtSearchpxuat.Text;
            lvds.Items.Clear();
            DataTable dt = new DataTable();
            dt = XuatKhoDAO.TimPXuat(xk);
            int sodong = dt.Rows.Count;
            for (int i = 0; i < sodong; i++)
            {
                lvds.Items.Add(dt.Rows[i]["MaPXuat"].ToString());
                lvds.Items[i].SubItems.Add(dt.Rows[i]["TongSl"].ToString());
                lvds.Items[i].SubItems.Add(dt.Rows[i]["NgayXuat"].ToString());
                lvds.Items[i].SubItems.Add(dt.Rows[i]["MaNV"].ToString());
                lvds.Items[i].SubItems.Add(dt.Rows[i]["MaKH"].ToString());
                lvds.Items[i].SubItems.Add(dt.Rows[i]["TongTien"].ToString());
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmXuatLK xuatlk = new frmXuatLK();
            xuatlk.ShowDialog();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            frmCrysXK fr = new frmCrysXK();
            fr.mapxuat = txtMapxuat.Text;
            fr.Show();
        }

        private void txttongtien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
