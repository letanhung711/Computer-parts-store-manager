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
    public partial class frmQl_Loailinhkien : Form
    {
        public frmQl_Loailinhkien()
        {
            InitializeComponent();
        }
        public void TT_LoaiLK()
        {
            DataTable dt = new DataTable();
            dt = LoaiLKBUS.TTLoaiLK();
            int SoLoai = dt.Rows.Count;
            int i;
            for (i = 0; i < SoLoai; i++)
            {
                lvdanhsachloaiLK.Items.Add(dt.Rows[i]["MaLoaiLK"].ToString());
                lvdanhsachloaiLK.Items[i].SubItems.Add(dt.Rows[i]["TenLoai"].ToString());
                lvdanhsachloaiLK.Items[i].SubItems.Add(dt.Rows[i]["NgayTao"].ToString());
                lvdanhsachloaiLK.Items[i].SubItems.Add(dt.Rows[i]["NgayCapNhat"].ToString());
                lvdanhsachloaiLK.Items[i].SubItems.Add(dt.Rows[i]["MaNhomLK"].ToString());
            }
        }
        public void TTNhomLK_Combobox()
        {
            DataTable dt = new DataTable();
            dt = LoaiLKDAO.TTNhomLKcuaLoaiLK();
            cbNhomLK.DataSource = dt;
            cbNhomLK.ValueMember = "MaNhomLK";
            cbNhomLK.DisplayMember = "TenNhomLK";
        }

        private void frmQl_Loailinhkien_Load(object sender, EventArgs e)
        {
            TTNhomLK_Combobox();
            lvdanhsachloaiLK.Items.Clear();
            TT_LoaiLK();
        }

        private void lvdanhsachloaiLK_Click(object sender, EventArgs e)
        {
            txtMaloai.Text = lvdanhsachloaiLK.SelectedItems[0].SubItems[0].Text;
            txtTenloai.Text = lvdanhsachloaiLK.SelectedItems[0].SubItems[1].Text;
            dtngaytao.Text = lvdanhsachloaiLK.SelectedItems[0].SubItems[2].Text;
            dtngaycn.Text = lvdanhsachloaiLK.SelectedItems[0].SubItems[3].Text;
            DataTable dt = new DataTable();
            dt = LoaiLKDAO.TenNhomtheoMaNhom(lvdanhsachloaiLK.SelectedItems[0].SubItems[4].Text);
            cbNhomLK.Text = dt.Rows[0][0].ToString();
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            txtMaloai.Text = "";
            txtTenloai.Text = "";
            dtngaytao.Text = "";
            dtngaycn.Text = "";
            cbNhomLK.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaloai.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!", "Thông báo");
                txtMaloai.Focus();
            }
            else
            {
                LoaiLKDTO lk = new LoaiLKDTO();
                lk.Maloai = txtMaloai.Text.ToUpper();
                lk.Tenloai = txtTenloai.Text;
                lk.Ngaytao = dtngaytao.Value.ToString("MM/dd/yyyy");
                lk.Ngaycapnhat = dtngaycn.Value.ToString("MM/dd/yyyy");
                lk.Manhomlk = cbNhomLK.SelectedValue.ToString();
                LoaiLKBUS.Them_LoaiLK(lk);
                lvdanhsachloaiLK.Items.Clear();
                TT_LoaiLK();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaloai.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn loại linh kiện cần xóa!", "Thông báo");
            }
            else
            {
                LoaiLKDTO lk = new LoaiLKDTO();
                lk.Maloai = txtMaloai.Text;
                LoaiLKBUS.Xoa_LoaiLK(lk);
                txtMaloai.Text = "";
                txtTenloai.Text = "";
                dtngaytao.Text = "";
                dtngaycn.Text = "";
                lvdanhsachloaiLK.Items.Clear();
                TT_LoaiLK();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaloai.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn loại linh kiện cần cập nhật!", "Thông báo");
            }
            else
            {
                LoaiLKDTO lk = new LoaiLKDTO();
                lk.Maloai = txtMaloai.Text.ToUpper();
                lk.Tenloai = txtTenloai.Text;
                lk.Ngaytao = dtngaytao.Value.ToString("MM/dd/yyyy");
                lk.Ngaycapnhat = dtngaycn.Value.ToString("MM/dd/yyyy");
                lk.Manhomlk = cbNhomLK.SelectedValue.ToString();
                LoaiLKBUS.Sua_LoaiLK(lk);
                lvdanhsachloaiLK.Items.Clear();
                TT_LoaiLK();
            }
        }

        private void cbNhomLK_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            LoaiLKDTO lk = new LoaiLKDTO();
            lk.Manhomlk = cbNhomLK.SelectedValue.ToString();
            dt = LoaiLKDAO.TTLoaiLK_MaNhomLK(lk);
            lvdanhsachloaiLK.Items.Clear();
            int soloai = dt.Rows.Count;
            for(int i = 0; i < soloai; i++)
            {
                lvdanhsachloaiLK.Items.Add(dt.Rows[i]["MaLoaiLK"].ToString());
                lvdanhsachloaiLK.Items[i].SubItems.Add(dt.Rows[i]["TenLoai"].ToString());
                lvdanhsachloaiLK.Items[i].SubItems.Add(dt.Rows[i]["NgayTao"].ToString());
                lvdanhsachloaiLK.Items[i].SubItems.Add(dt.Rows[i]["NgayCapNhat"].ToString());
                lvdanhsachloaiLK.Items[i].SubItems.Add(dt.Rows[i]["MaNhomLK"].ToString());
            }
        }
    }
}
