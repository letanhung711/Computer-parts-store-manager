using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using PhanMem_QuanLyKhoLinhKien.BUS;
using PhanMem_QuanLyKhoLinhKien.DTO;
using PhanMem_QuanLyKhoLinhKien.DAO;

namespace PhanMem_QuanLyKhoLinhKien
{
    public partial class LinhKien : Form
    {
        public LinhKien()
        {
            InitializeComponent();
        }
        public void TT_LinhKien()
        {
            DataTable dt = new DataTable();
            dt = LinhkienBUS.TTLinhKien();
            int solk = dt.Rows.Count;
            for (int i = 0; i < solk; i++)
            {
                lvdsLinhKien.Items.Add(dt.Rows[i]["MaLK"].ToString());
                lvdsLinhKien.Items[i].SubItems.Add(dt.Rows[i]["TenLK"].ToString());
                lvdsLinhKien.Items[i].SubItems.Add(dt.Rows[i]["Gia"].ToString());
                lvdsLinhKien.Items[i].SubItems.Add(dt.Rows[i]["MaTH"].ToString());
                lvdsLinhKien.Items[i].SubItems.Add(dt.Rows[i]["MaLoaiLK"].ToString());
                lvdsLinhKien.Items[i].SubItems.Add(dt.Rows[i]["BaoHanh"].ToString());
                lvdsLinhKien.Items[i].SubItems.Add(dt.Rows[i]["MaNhomLK"].ToString());
                lvdsLinhKien.Items[i].SubItems.Add(dt.Rows[i]["Mota"].ToString());
            }
        }
        public void TTnhomLK_Combobox()
        {
            DataTable dt = new DataTable();
            dt = LinhkienDAO.TTNhomLK_Combobox();
            cbnhomlk.DataSource = dt;
            cbnhomlk.ValueMember = "MaNhomLK";
            cbnhomlk.DisplayMember = "TenNhomLK";
        }

        public void TTLoaiLK_Combobox()
        {
            DataTable dt = new DataTable();
            dt = LinhkienDAO.TTLoaiLK_Combobox();
            cbloailk.DataSource = dt;
            cbloailk.ValueMember = "MaLoaiLK";
            cbloailk.DisplayMember = "TenLoai";
        }
        public void TTTH_Combobox()
        {
            DataTable dt = new DataTable();
            dt = LinhkienDAO.TTTH_Combobox();
            cbthuonghieu.DataSource = dt;
            cbthuonghieu.ValueMember = "MaTH";
            cbthuonghieu.DisplayMember = "TenTH";
        }

        private void LinhKien_Load(object sender, EventArgs e)
        {
            TTnhomLK_Combobox();
            TTLoaiLK_Combobox();
            TTTH_Combobox();
            lvdsLinhKien.Items.Clear();
            TT_LinhKien();
        }

        private void lvdsLinhKien_Click(object sender, EventArgs e)
        {
            txtmalk.Text = lvdsLinhKien.SelectedItems[0].SubItems[0].Text;
            txttenlk.Text = lvdsLinhKien.SelectedItems[0].SubItems[1].Text;
            txtgia.Text = lvdsLinhKien.SelectedItems[0].SubItems[2].Text;
            numbaohanh.Value = Int32.Parse(lvdsLinhKien.SelectedItems[0].SubItems[5].Text);
            txtmota.Text = lvdsLinhKien.SelectedItems[0].SubItems[7].Text;
            //cbnhomlk.Text = lvdsLinhKien.SelectedItems[0].SubItems[6].Text;
            //cbloailk.Text= lvdsLinhKien.SelectedItems[0].SubItems[4].Text;
            //cbthuonghieu.Text= lvdsLinhKien.SelectedItems[0].SubItems[3].Text;
            DataTable dt = new DataTable();
            dt = LinhkienDAO.TenNhomtheoManhom(lvdsLinhKien.SelectedItems[0].SubItems[6].Text);
            cbnhomlk.Text = dt.Rows[0][0].ToString();

            //dt = LinhkienDAO.TenloaitheoMaloai(lvdsLinhKien.SelectedItems[0].SubItems[4].Text);
            //cbloailk.Text = dt.Rows[0][0].ToString();

            //dt = LinhkienDAO.TenTHtheoMaTH(lvdsLinhKien.SelectedItems[0].SubItems[3].Text);
            //cbthuonghieu.Text = dt.Rows[0][0].ToString();

            try
            {
                picLinhKien.Load(path + txtmalk.Text + ".jpg");
            }
            catch
            {
                picLinhKien.Load(Environment.CurrentDirectory + @"\Images\null.jpg");
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtmalk.Text = "";
            txttenlk.Text = "";
            txtgia.Text = "";
            txtmota.Text = "";
            numbaohanh.Value = 0;
            cbnhomlk.Text = "";
            cbloailk.Text = "";
            cbthuonghieu.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = LinhkienDAO.MaLK_LN();
            string mlk = dt.Rows[0][0].ToString();
            txtmalk.Text = (Int32.Parse(mlk.Substring(mlk.Length - 4, 4)) + 1).ToString("SP" + "0000");
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            if (txtmalk.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!", "Thông báo");
                txttenlk.Focus();
            }
            else
            {
                LinhkienDTO lk = new LinhkienDTO();
                lk.Nhomlk = cbnhomlk.SelectedValue.ToString();
                lk.Loailk = cbloailk.SelectedValue.ToString();
                lk.Thuonghieu = cbthuonghieu.SelectedValue.ToString();
                lk.Malk = txtmalk.Text;
                lk.Tenlk = txttenlk.Text;
                lk.Gia = Int32.Parse(txtgia.Text);
                lk.Baohanh = Int32.Parse(numbaohanh.Value.ToString());
                lk.Mota = txtmota.Text;
                LinhkienBUS.Ghi_LinhKien(lk);
                lvdsLinhKien.Items.Clear();
                TT_LinhKien();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtmalk.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn dòng linh kiện cần xóa!", "Thông báo");
            }
            else
            {
                LinhkienDTO lk = new LinhkienDTO();
                lk.Malk = txtmalk.Text;
                LinhkienBUS.Xoa_LinhKien(lk);
                lvdsLinhKien.Items.Clear();
                TT_LinhKien();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtmalk.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn dòng linh kiện cần chỉnh sửa!", "Thông báo");
            }
            else
            {
                LinhkienDTO lk = new LinhkienDTO();
                lk.Nhomlk = cbnhomlk.SelectedValue.ToString();
                lk.Loailk = cbloailk.SelectedValue.ToString();
                lk.Thuonghieu = cbthuonghieu.SelectedValue.ToString();
                lk.Malk = txtmalk.Text;
                lk.Tenlk = txttenlk.Text;
                lk.Gia = Int32.Parse(txtgia.Text);
                lk.Baohanh = Int32.Parse(numbaohanh.Value.ToString());
                lk.Mota = txtmota.Text;
                LinhkienBUS.Sua_Linhkien(lk);
                lvdsLinhKien.Items.Clear();
                TT_LinhKien();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LinhkienDTO lk = new LinhkienDTO();
            DataTable dt = new DataTable();
            lk.Malk = txtSearchLK.Text;
            lvdsLinhKien.Items.Clear();
            dt = LinhkienDAO.Tim_LinhKien(lk);
            int solk = dt.Rows.Count;
            for (int i = 0; i < solk; i++)
            {
                lvdsLinhKien.Items.Add(dt.Rows[i]["MaLK"].ToString());
                lvdsLinhKien.Items[i].SubItems.Add(dt.Rows[i]["TenLK"].ToString());
                lvdsLinhKien.Items[i].SubItems.Add(dt.Rows[i]["Gia"].ToString());
                lvdsLinhKien.Items[i].SubItems.Add(dt.Rows[i]["MaTH"].ToString());
                lvdsLinhKien.Items[i].SubItems.Add(dt.Rows[i]["MaLoaiLK"].ToString());
                lvdsLinhKien.Items[i].SubItems.Add(dt.Rows[i]["BaoHanh"].ToString());
                lvdsLinhKien.Items[i].SubItems.Add(dt.Rows[i]["MaNhomLK"].ToString());
                lvdsLinhKien.Items[i].SubItems.Add(dt.Rows[i]["Mota"].ToString());
            }
        }

        private void cbnhomlk_SelectedIndexChanged(object sender, EventArgs e)
        {
             //Loai linh kiện
             DataTable dtlk = new DataTable();
             dtlk = LinhkienDAO.TTloaiLKcuaLK(cbnhomlk.SelectedValue.ToString());
             cbloailk.DataSource = dtlk;
             cbloailk.ValueMember = "MaLoaiLK";
             cbloailk.DisplayMember = "TenLoai";
             //Thương hiệu
             DataTable dtth = new DataTable();
             dtth = LinhkienDAO.TTTHcuaLK(cbnhomlk.SelectedValue.ToString());
             cbthuonghieu.DataSource = dtth;
             cbthuonghieu.ValueMember = "MaTH";
             cbthuonghieu.DisplayMember = "TenTH";

            if (cbnhomlk.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                DataTable dt = new DataTable();
                LinhkienDTO lk = new LinhkienDTO();
                lk.Nhomlk = cbnhomlk.SelectedValue.ToString();
                dt = LinhkienDAO.TTLK_MaNhomLK(lk);
                lvdsLinhKien.Items.Clear();
                int solk = dt.Rows.Count;
                for (int i = 0; i < solk; i++)
                {
                    lvdsLinhKien.Items.Add(dt.Rows[i]["MaLK"].ToString());
                    lvdsLinhKien.Items[i].SubItems.Add(dt.Rows[i]["TenLK"].ToString());
                    lvdsLinhKien.Items[i].SubItems.Add(dt.Rows[i]["Gia"].ToString());
                    lvdsLinhKien.Items[i].SubItems.Add(dt.Rows[i]["MaTH"].ToString());
                    lvdsLinhKien.Items[i].SubItems.Add(dt.Rows[i]["MaLoaiLK"].ToString());
                    lvdsLinhKien.Items[i].SubItems.Add(dt.Rows[i]["BaoHanh"].ToString());
                    lvdsLinhKien.Items[i].SubItems.Add(dt.Rows[i]["MaNhomLK"].ToString());
                    lvdsLinhKien.Items[i].SubItems.Add(dt.Rows[i]["Mota"].ToString());
                }
            }
        }

        //Cap nhat anh linh kien
        private string fN; //đường dẫn hiện tại của ảnh
        private string path = Environment.CurrentDirectory + @"\Images\"; //bin/debug/......
        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openpic = new OpenFileDialog();
            openpic.Title = "Chọn ảnh";
            openpic.Filter = "Images File(*.jpg) | *.JPG";
            if (openpic.ShowDialog() == DialogResult.OK)
            {
                fN = openpic.FileName;
                using (var bitmap = new Bitmap(fN))
                    picLinhKien.Image = new Bitmap(bitmap);
            }
        }

        private void btncapnhatanh_Click(object sender, EventArgs e)
        {
            try
            {
                string namepic = txtmalk.Text + ".jpg"; //tên ảnh muốn lưu
                File.Copy(fN, Path.Combine(path, namepic), true); //copy ảnh vào bin/debug/...
                picLinhKien.Load(path + txtmalk.Text + ".jpg"); //load ảnh mới lưu
                MessageBox.Show("Cập nhật ảnh thành công!", "Thông báo");
            }
            catch
            {
                picLinhKien.Load(path + txtmalk.Text + ".jpg");
                MessageBox.Show("Chọn ảnh nếu bạn muốn cập nhật!", "Thông báo");
            }
        }

        private void cbloailk_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbloailk.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                DataTable dt = new DataTable();
                LinhkienDTO lk = new LinhkienDTO();
                lk.Loailk = cbloailk.SelectedValue.ToString();
                dt = LinhkienDAO.TTLK_MaLoaiLK(lk);
                lvdsLinhKien.Items.Clear();
                int solk = dt.Rows.Count;
                for (int i = 0; i < solk; i++)
                {
                    lvdsLinhKien.Items.Add(dt.Rows[i]["MaLK"].ToString());
                    lvdsLinhKien.Items[i].SubItems.Add(dt.Rows[i]["TenLK"].ToString());
                    lvdsLinhKien.Items[i].SubItems.Add(dt.Rows[i]["Gia"].ToString());
                    lvdsLinhKien.Items[i].SubItems.Add(dt.Rows[i]["MaTH"].ToString());
                    lvdsLinhKien.Items[i].SubItems.Add(dt.Rows[i]["MaLoaiLK"].ToString());
                    lvdsLinhKien.Items[i].SubItems.Add(dt.Rows[i]["BaoHanh"].ToString());
                    lvdsLinhKien.Items[i].SubItems.Add(dt.Rows[i]["MaNhomLK"].ToString());
                    lvdsLinhKien.Items[i].SubItems.Add(dt.Rows[i]["Mota"].ToString());
                }
            }
        }

        private void cbthuonghieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbthuonghieu.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                DataTable dt = new DataTable();
                LinhkienDTO lk = new LinhkienDTO();
                lk.Thuonghieu = cbthuonghieu.SelectedValue.ToString();
                dt = LinhkienDAO.TTLK_MaTH(lk);
                lvdsLinhKien.Items.Clear();
                int soth = dt.Rows.Count;
                for (int i = 0; i < soth; i++)
                {
                    lvdsLinhKien.Items.Add(dt.Rows[i]["MaLK"].ToString());
                    lvdsLinhKien.Items[i].SubItems.Add(dt.Rows[i]["TenLK"].ToString());
                    lvdsLinhKien.Items[i].SubItems.Add(dt.Rows[i]["Gia"].ToString());
                    lvdsLinhKien.Items[i].SubItems.Add(dt.Rows[i]["MaTH"].ToString());
                    lvdsLinhKien.Items[i].SubItems.Add(dt.Rows[i]["MaLoaiLK"].ToString());
                    lvdsLinhKien.Items[i].SubItems.Add(dt.Rows[i]["BaoHanh"].ToString());
                    lvdsLinhKien.Items[i].SubItems.Add(dt.Rows[i]["MaNhomLK"].ToString());
                    lvdsLinhKien.Items[i].SubItems.Add(dt.Rows[i]["Mota"].ToString());
                }
            }
        }

        private void txtgia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
