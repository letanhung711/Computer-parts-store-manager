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
    public partial class frmNhapkho : Form
    {
        public frmNhapkho()
        {
            InitializeComponent();
        }

        public void TT_NK()
        {
            DataTable dt = new DataTable();
            dt = NhapKhoDAO.TTNK();
            int sodong = dt.Rows.Count;
            for (int i = 0; i < sodong; i++)
            {
                lvds.Items.Add(dt.Rows[i]["MaPNhap"].ToString());
                lvds.Items[i].SubItems.Add(dt.Rows[i]["TongSL"].ToString());
                lvds.Items[i].SubItems.Add(dt.Rows[i]["NgayNhap"].ToString());
                lvds.Items[i].SubItems.Add(dt.Rows[i]["MaNV"].ToString());
                lvds.Items[i].SubItems.Add(dt.Rows[i]["TongTien"].ToString());

            }
        }
        private void frmNhapkho_Load(object sender, EventArgs e)
        {
            TT_NK();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            frmNhapLK nhaplk = new frmNhapLK();
            nhaplk.ShowDialog();
        }

        private void lvds_Click(object sender, EventArgs e)
        {
            txtMapnhap.Text = lvds.SelectedItems[0].SubItems[0].Text;
            DataTable dtnv = new DataTable();
            dtnv = NhapKhoDAO.TNVtheoManv(lvds.SelectedItems[0].SubItems[3].Text);
            txtnv.Text= dtnv.Rows[0][0].ToString();
            txtsl.Text= lvds.SelectedItems[0].SubItems[1].Text;
            txttongtien.Text= lvds.SelectedItems[0].SubItems[4].Text;
            dtpNgaynhap.Text= lvds.SelectedItems[0].SubItems[2].Text;

            //San pham nhap
            DataTable dt = new DataTable();
            NhapKhoDTO nk = new NhapKhoDTO();
            nk.Mapnhap = lvds.SelectedItems[0].SubItems[0].Text;
            dt = NhapKhoDAO.TTSPNhap(nk);
            int sosp = dt.Rows.Count;
            for(int i = 0; i < sosp; i++)
            {
                lvlk.Items.Add(dt.Rows[i][0].ToString());
                lvlk.Items[i].SubItems.Add(dt.Rows[i][1].ToString());
            }
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            txtMapnhap.Text = "";
            txtnv.Text = "";
            txtsl.Text = "";
            txttongtien.Text = "";
            dtpNgaynhap.Text = "";
            txtsearch.Text = "";
            lvlk.Items.Clear();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (txtMapnhap.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn phiếu nhập cần xóa!", "Thông báo");
            }
            else
            {
                NhapKhoDTO nk = new NhapKhoDTO();
                nk.Mapnhap = txtMapnhap.Text;
                NhapKhoBUS.XoaPNhap(nk);
                lvds.Items.Clear();
                TT_NK();
            }
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            if (txtMapnhap.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn phiếu nhập cần chỉnh sửa!", "Thông báo");
            }
            else
            {
                NhapKhoDTO nk = new NhapKhoDTO();
                nk.Mapnhap = txtMapnhap.Text;
                nk.Ngaynhap = dtpNgaynhap.Value.ToString("MM/dd/yyyy");
                nk.Tongtien = Int32.Parse(txttongtien.Text);
                NhapKhoBUS.UpdatePNhap(nk);
                lvds.Items.Clear();
                TT_NK();
            } 
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            NhapKhoDTO nk = new NhapKhoDTO();
            nk.Mapnhap = txtsearch.Text;
            lvds.Items.Clear();
            DataTable dt = new DataTable();
            dt = NhapKhoDAO.TimPNhap(nk);
            int sodong = dt.Rows.Count;
            for(int i = 0; i < sodong; i++)
            {
                lvds.Items.Add(dt.Rows[i]["MaPNhap"].ToString());
                lvds.Items[i].SubItems.Add(dt.Rows[i]["TongSL"].ToString());
                lvds.Items[i].SubItems.Add(dt.Rows[i]["NgayNhap"].ToString());
                lvds.Items[i].SubItems.Add(dt.Rows[i]["MaNV"].ToString());
                lvds.Items[i].SubItems.Add(dt.Rows[i]["TongTien"].ToString());
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            frmCrysNK rp = new frmCrysNK();
            rp.mapnhap = txtMapnhap.Text;
            rp.Show();
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
