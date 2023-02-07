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
    public partial class frmXuatLK : Form
    {
        public frmXuatLK()
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

        private void frmXuatLK_Load(object sender, EventArgs e)
        {
            TTLK_Combobox();
            TTNV_Combobox();
            numsl.Value = 1;
        }

        private void cbtenlk_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbtenlk.SelectedValue.ToString()!= "System.Data.DataRowView")
            {
                DataTable dt = new DataTable();
                LinhkienDTO lk = new LinhkienDTO();
                lk.Malk = cbtenlk.SelectedValue.ToString();
                dt = NhapLKDAO.TenLKtheoMaLK(lk);
                txtmalk.Text = dt.Rows[0]["MaLK"].ToString();
            }
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            try
            {
                txtmalk.Text = lvds.SelectedItems[0].SubItems[1].Text;
                cbtenlk.Text = lvds.SelectedItems[0].SubItems[2].Text;
                numsl.Value = Int32.Parse(lvds.SelectedItems[0].SubItems[3].Text);
                txtgiaxuat.Text = lvds.SelectedItems[0].SubItems[4].Text;
            }
            catch
            {
                MessageBox.Show("Vui lòng chọn dòng linh kiện muốn chỉnh sửa!", "Thông báo");
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (txtgiaxuat.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!", "Thông báo");
                txtgiaxuat.Focus();
            }
            else
            {
                int stt = lvds.Items.Count;
                stt++;
                lvds.Items.Add(stt.ToString());
                lvds.Items[stt - 1].SubItems.Add(txtmalk.Text);
                lvds.Items[stt - 1].SubItems.Add(cbtenlk.Text);
                int sl = Int32.Parse(numsl.Value.ToString());
                lvds.Items[stt - 1].SubItems.Add(numsl.Value.ToString());
                int dongia = int.Parse(txtgiaxuat.Text);
                lvds.Items[stt - 1].SubItems.Add(txtgiaxuat.Text);
                lvds.Items[stt - 1].SubItems.Add((dongia * sl).ToString());
            }
        }

        private void btntongtien_Click(object sender, EventArgs e)
        {
            int stt = lvds.Items.Count;
            if (stt > 0)
            {
                int tongtien = 0;
                int sl = 0;
                for (int i = 0; i < lvds.Items.Count; i++)
                {
                    tongtien += int.Parse(lvds.Items[i].SubItems[5].Text);
                    sl += int.Parse(lvds.Items[i].SubItems[3].Text);
                }
                lbltongtien.Text = string.Format("{0:#,##0}", tongtien) + " VND";
                lbltongsl.Text = sl.ToString();
                lvds.Text = sl.ToString();
                btnxacnhan.Visible = true;
            }
            else
            {
                MessageBox.Show("Chưa có thông tin để tính toán!", "Thông Báo");
            }
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            txtgiaxuat.Text = "";
            numsl.Value = 1;
            lvds.Items.Clear();
            lbltongsl.Text= "0";
            lbltongtien.Text = "0 VND";
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                lvds.Items.RemoveAt(lvds.SelectedIndices[0]);
                for (int i = 0; i < lvds.Items.Count; i++)
                {
                    if ((lvds.Items[i].Index + 1) != Convert.ToInt32(lvds.Items[i].SubItems[0].Text))
                        lvds.Items[i].SubItems[0].Text = Convert.ToString(++i);
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng chọn dòng linh kiện cần xóa!", "Thông báo");
            }
        }

        private void lvds_Click(object sender, EventArgs e)
        {
            txtmalk.Text = lvds.Items[0].SubItems[1].Text;
            cbtenlk.Text = lvds.Items[0].SubItems[2].Text;
            numsl.Value = int.Parse(lvds.Items[0].SubItems[3].Text);
            txtgiaxuat.Text = lvds.Items[0].SubItems[4].Text;
        }

        private void btnxacnhan_Click(object sender, EventArgs e)
        {
            //Them khach hang
            DataTable dtkh = new DataTable();
            KhachHangDTO kh = new KhachHangDTO();
            dtkh = KhachHangDAO.TTKhachhang();
            int sokh = dtkh.Rows.Count;
            if (sokh == 0)
            {
                kh.Makh = "KH0001";
            }
            else
            {
                dtkh = KhachHangDAO.MaKH_LN();
                string makh = dtkh.Rows[0][0].ToString();
                kh.Makh = (Int32.Parse(makh.Substring(makh.Length - 4, 4)) + 1).ToString("KH" + "0000");
            }
            kh.Tenkh = txttenkh.Text;
            kh.Sdt = txtsdt.Text;
            kh.Diachi = txtdiachi.Text;
            DateTime dateNowKH = DateTime.Now;
            kh.Ngaytao = dateNowKH.ToString("MM/dd/yyyy");
            kh.Ngaycapnhat = dateNowKH.ToString("MM/dd/yyyy");
            KhachHangDAO.Ghi_KH(kh);

            //Them xuat kho
            DataTable dtxk = new DataTable();
            XuatKhoDTO xk = new XuatKhoDTO();
            dtxk = XuatKhoDAO.TTXK();
            int soxk = dtxk.Rows.Count;
            if (soxk == 0)
            {
                xk.Mapxuat = "PX001";
            }
            else
            {
                dtxk = XuatLKDAO.XK_MAX();
                string mapxuat = dtxk.Rows[0][0].ToString();
                xk.Mapxuat = (int.Parse(mapxuat.Substring(mapxuat.Length - 3, 3)) + 1).ToString("PX000");
            }
            int tongtien = 0;
            for (int i = 0; i < lvds.Items.Count; i++)
            {
                tongtien += int.Parse(lvds.Items[i].SubItems[5].Text);

            }
            DateTime dateNow = DateTime.Now;
            xk.Tongsl = int.Parse(lbltongsl.Text);
            xk.Tongtien = tongtien;
            xk.Ngayxuat = dateNow.ToString("MM/dd/yyyy");
            xk.Manv = cbnv.SelectedValue.ToString();
            xk.Makh = kh.Makh;
            XuatLKDAO.ThemXK(xk);
            //Them lk vao SPXuat
            SPXuatDTO spx = new SPXuatDTO();
            for (int i = 0; i < lvds.Items.Count; i++)
            {
                spx.Stt = int.Parse(lvds.Items[0].SubItems[0].Text);
                spx.Malk = lvds.Items[0].SubItems[1].Text;
                spx.Giaxuat = int.Parse(lvds.Items[0].SubItems[4].Text);
                spx.Slxuat = int.Parse(lvds.Items[0].SubItems[3].Text);
                spx.Mapxuat = xk.Mapxuat;
                XuatLKDAO.ThemSPXuat(spx);
            }
            MessageBox.Show("Xuất thành công!");
            this.Close();
        }

        private void txtsdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtgiaxuat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
