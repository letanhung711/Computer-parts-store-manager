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
    public partial class frmNhapLK : Form
    {
        public frmNhapLK()
        {
            InitializeComponent();
        }

        public void TTLK_Combobox()
        {
            DataTable dt = new DataTable();
            dt = LinhkienDAO.TTLinhKien();
            cbtenlk.DataSource = dt;
            cbtenlk.ValueMember = "MaLK";
            cbtenlk.DisplayMember = "TenLK";
        }
        public void TTNV_Combobox()
        {
            DataTable dt = new DataTable();
            dt = NhanVienDAO.TTNhanVien();
            cbnv.DataSource = dt;
            cbnv.ValueMember = "MaNV";
            cbnv.DisplayMember = "TenNV";
        }

        private void frmNhapLK_Load(object sender, EventArgs e)
        {
            TTLK_Combobox();
            TTNV_Combobox();
            numsl.Value = 1;
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            try
            {
                txtmalk.Text = lvlist.SelectedItems[0].SubItems[1].Text;
                txtgianhap.Text= lvlist.SelectedItems[0].SubItems[4].Text;
                numsl.Value= Int32.Parse(lvlist.SelectedItems[0].SubItems[3].Text);
                cbtenlk.Text= lvlist.SelectedItems[0].SubItems[2].Text;
            }
            catch
            {
                MessageBox.Show("Vui lòng chọn dòng linh kiện muốn chỉnh sửa!", "Thông báo");
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtgianhap.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!", "Thông báo");
                txtgianhap.Focus();
            }
            else
            {
                int stt = lvlist.Items.Count;
                stt++;
                lvlist.Items.Add(stt.ToString());
                lvlist.Items[stt - 1].SubItems.Add(txtmalk.Text);
                lvlist.Items[stt - 1].SubItems.Add(cbtenlk.Text);
                int sl = Int32.Parse(numsl.Value.ToString());
                lvlist.Items[stt - 1].SubItems.Add(numsl.Value.ToString());
                int dongia = int.Parse(txtgianhap.Text);
                lvlist.Items[stt - 1].SubItems.Add(txtgianhap.Text);
                lvlist.Items[stt - 1].SubItems.Add((dongia * sl).ToString());
            }
        }

        private void btntt_Click(object sender, EventArgs e)
        {
            int stt = lvlist.Items.Count;
            if (stt > 0)
            {
                int tongtien = 0;
                int sl = 0;
                for (int i = 0; i < lvlist.Items.Count; i++)
                {
                    tongtien += int.Parse(lvlist.Items[i].SubItems[5].Text);
                    sl += int.Parse(lvlist.Items[i].SubItems[3].Text);
                }
                lbltongtien.Text = string.Format("{0:#,##0}", tongtien) + " VND";
                lbltsl.Text = sl.ToString();
                btnxacnhan.Visible = true;
            }
            else
            {
                MessageBox.Show("Chưa có thông tin để tính toán!", "Thông Báo");
            }
        }

        private void cbtenlk_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbtenlk.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                DataTable dt = new DataTable();
                LinhkienDTO lk = new LinhkienDTO();
                lk.Malk = cbtenlk.SelectedValue.ToString();
                dt = NhapLKDAO.TenLKtheoMaLK(lk);
                txtmalk.Text = dt.Rows[0]["MaLK"].ToString();
            }
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            lvlist.Items.Clear();
            txtgianhap.Text = "";
            numsl.Value = 1;
            lbltsl.Text = "0";
            lbltongtien.Text = "0 VND";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                lvlist.Items.RemoveAt(lvlist.SelectedIndices[0]);
                for(int i = 0; i < lvlist.Items.Count; i++)
                {
                    if ((lvlist.Items[i].Index + 1) != Convert.ToInt32(lvlist.Items[i].SubItems[0].Text))
                        lvlist.Items[i].SubItems[0].Text = Convert.ToString(++i);
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng chọn dòng linh kiện cần xóa!", "Thông báo");
            }
        }

        private void lvlist_Click(object sender, EventArgs e)
        {
            txtmalk.Text = lvlist.Items[0].SubItems[1].Text;
            cbtenlk.Text= lvlist.Items[0].SubItems[2].Text;
            numsl.Value= int.Parse(lvlist.Items[0].SubItems[3].Text);
            txtgianhap.Text= lvlist.Items[0].SubItems[4].Text;
        }

        private void btnxacnhan_Click(object sender, EventArgs e)
        {
            //Them nhap kho
            DataTable dtnk = new DataTable();
            NhapKhoDTO nk = new NhapKhoDTO();
            dtnk = NhapLKDAO.TTNK();
            int sonk = dtnk.Rows.Count;
            if (sonk == 0)
            {
                nk.Mapnhap = "PN001";
            }
            else
            {
                dtnk = NhapLKDAO.NK_Max();
                string mapnhap = dtnk.Rows[0][0].ToString();
                nk.Mapnhap = (int.Parse(mapnhap.Substring(mapnhap.Length - 3, 3)) + 1).ToString("PN000"); 
            }
            int tongtien = 0;
            for (int i = 0; i < lvlist.Items.Count; i++)
            {
                tongtien += int.Parse(lvlist.Items[i].SubItems[5].Text);

            }
            DateTime dateNow = DateTime.Now;
            nk.Tongsl = int.Parse(lbltsl.Text);
            nk.Tongtien = tongtien;
            nk.Ngaynhap = dateNow.ToString("MM/dd/yyyy");
            nk.Manv = cbnv.SelectedValue.ToString();
            NhapLKDAO.ThemNK(nk);

            //Them lk vao SPNhap
            SPNhapDTO spn = new SPNhapDTO();
            for(int i = 0; i < lvlist.Items.Count; i++)
            {
                spn.Stt = int.Parse(lvlist.Items[0].SubItems[0].Text);
                spn.Malk = lvlist.Items[0].SubItems[1].Text;
                spn.Gianhap = int.Parse(lvlist.Items[0].SubItems[4].Text);
                spn.Slnhap= int.Parse(lvlist.Items[0].SubItems[3].Text);
                spn.Mapnhap = nk.Mapnhap;
                NhapLKDAO.ThemSPNhap(spn);
            }
            MessageBox.Show("Nhập thành công!");
            this.Close();
        }

        private void txtgianhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
