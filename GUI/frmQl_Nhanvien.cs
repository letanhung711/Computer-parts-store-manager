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
using PhanMem_QuanLyKhoLinhKien.GUI;
using PhanMem_QuanLyKhoLinhKien.DTO;
using PhanMem_QuanLyKhoLinhKien.BUS;

namespace PhanMem_QuanLyKhoLinhKien.GUI
{
    public partial class frmQl_Nhanvien : Form
    {
        public frmQl_Nhanvien()
        {
            InitializeComponent();
        }
        public void TT_NhanVien()
        {
            DataTable dt = new DataTable();
            dt = NhanVienBUS.TTNhanVien();
            int sonv = dt.Rows.Count;
            for(int i = 0; i < sonv; i++)
            {
                lvdanhsachnv.Items.Add(dt.Rows[i]["MaNV"].ToString());
                lvdanhsachnv.Items[i].SubItems.Add(dt.Rows[i]["TenNV"].ToString());
                string gioitinh= dt.Rows[i]["GioiTinh"].ToString();
                if (gioitinh == "True")
                    lvdanhsachnv.Items[i].SubItems.Add("Nam");
                else
                    lvdanhsachnv.Items[i].SubItems.Add("Nữ");
                lvdanhsachnv.Items[i].SubItems.Add(dt.Rows[i]["SDT"].ToString());
                lvdanhsachnv.Items[i].SubItems.Add(dt.Rows[i]["DiaChi"].ToString());
                lvdanhsachnv.Items[i].SubItems.Add(dt.Rows[i]["MatKhau"].ToString());
                lvdanhsachnv.Items[i].SubItems.Add(dt.Rows[i]["TenCV"].ToString());
            }
        }
        public void TTChucvu_Combobox()
        {
            DataTable dt = new DataTable();
            dt = NhanVienDAO.TTCVcuaNV();
            cbChucvu.DataSource = dt;
            cbChucvu.ValueMember = "MaCV";
            cbChucvu.DisplayMember = "TenCV";
        }

        private void frmQl_Nhanvien_Load(object sender, EventArgs e)
        {
            TT_NhanVien();
            TTChucvu_Combobox();
        }

        private void lvdanhsachnv_Click(object sender, EventArgs e)
        {
            txtMaNV.Text = lvdanhsachnv.SelectedItems[0].SubItems[0].Text;
            txtTenNV.Text = lvdanhsachnv.SelectedItems[0].SubItems[1].Text;
            txtSDT.Text = lvdanhsachnv.SelectedItems[0].SubItems[3].Text;
            txtMK.Text = lvdanhsachnv.SelectedItems[0].SubItems[5].Text;
            txtDiachi.Text = lvdanhsachnv.SelectedItems[0].SubItems[4].Text;
            int vt = lvdanhsachnv.SelectedIndices[0];
            if (lvdanhsachnv.Items[vt].SubItems[2].Text == "Nam")
            {
                rbNam.Checked = true;
            }
            else
            {
                rbNu.Checked = true;
            }
            cbChucvu.Text = lvdanhsachnv.SelectedItems[0].SubItems[6].Text;
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            txtMaNV.Text = "";
            txtTenNV.Text = "";
            txtSDT.Text = "";
            txtDiachi.Text = "";
            cbChucvu.Text = "";
            txtMK.Text = "";
            if (rbNam.Checked == true || rbNu.Checked == true)
            {
                rbNam.Checked = false;
                rbNu.Checked = false;
            }
                
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = NhanVienDAO.MaNV_LN();
            string mnv = dt.Rows[0][0].ToString();
            txtMaNV.Text = (Int32.Parse(mnv.Substring(mnv.Length - 4, 4)) + 1).ToString("NV" + "0000");
            txtTenNV.Text = "";
            txtSDT.Text = "";
            txtDiachi.Text = "";
            txtMK.Text = "";
        }

        private void btnghi_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!!!","Thông báo");
                txtTenNV.Focus();
            }
            else
            {
                NhanVienDTO nv = new NhanVienDTO();
                nv.Manv = txtMaNV.Text;
                nv.Tennv = txtTenNV.Text;
                nv.Sdt = txtSDT.Text;
                if (rbNam.Checked == true)
                {
                    nv.Gioitinh = "1";
                }
                else
                {
                    nv.Gioitinh = "0";
                }
                nv.Matkhau = txtMK.Text;
                nv.Chucvu = cbChucvu.SelectedValue.ToString();
                nv.Diachi = txtDiachi.Text;
                NhanVienBUS.Ghi_NhanVien(nv);
                lvdanhsachnv.Items.Clear();
                TT_NhanVien();
            }
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa!", "Thông báo");
            }
            else
            {
                NhanVienDTO nv = new NhanVienDTO();
                nv.Manv = txtMaNV.Text;
                NhanVienBUS.Xoa_NhanVien(nv);
                lvdanhsachnv.Items.Clear();
                TT_NhanVien();
            } 
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần cập nhật!","Thông báo");
            }
            else
            {
                NhanVienDTO nv = new NhanVienDTO();
                nv.Manv = txtMaNV.Text;
                nv.Tennv = txtTenNV.Text;
                nv.Sdt = txtSDT.Text;
                if (rbNam.Checked == true)
                {
                    nv.Gioitinh = "1";
                }
                else
                {
                    nv.Gioitinh = "0";
                }
                nv.Matkhau = txtMK.Text;
                nv.Chucvu = cbChucvu.SelectedValue.ToString();
                nv.Diachi = txtDiachi.Text;
                NhanVienBUS.Sua_NhanVien(nv);
                lvdanhsachnv.Items.Clear();
                TT_NhanVien();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            NhanVienDTO nv = new NhanVienDTO();
            DataTable dt = new DataTable();
            nv.Tennv = txtSearchTenNV.Text;
            lvdanhsachnv.Items.Clear();
            dt = NhanVienDAO.Tim_NhanVien(nv);
            int sonv = dt.Rows.Count;
            for (int i = 0; i < sonv; i++)
            {
                lvdanhsachnv.Items.Add(dt.Rows[i]["MaNV"].ToString());
                lvdanhsachnv.Items[i].SubItems.Add(dt.Rows[i]["TenNV"].ToString());
                string gioitinh = dt.Rows[i]["GioiTinh"].ToString();
                if (gioitinh == "True")
                    lvdanhsachnv.Items[i].SubItems.Add("Nam");
                else
                    lvdanhsachnv.Items[i].SubItems.Add("Nữ");
                lvdanhsachnv.Items[i].SubItems.Add(dt.Rows[i]["SDT"].ToString());
                lvdanhsachnv.Items[i].SubItems.Add(dt.Rows[i]["DiaChi"].ToString());
                lvdanhsachnv.Items[i].SubItems.Add(dt.Rows[i]["MatKhau"].ToString());
                lvdanhsachnv.Items[i].SubItems.Add(dt.Rows[i]["MaCV"].ToString());
            }
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
