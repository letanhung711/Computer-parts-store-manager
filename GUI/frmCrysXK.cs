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

namespace PhanMem_QuanLyKhoLinhKien.GUI
{
    public partial class frmCrysXK : Form
    {
        public string mapxuat;

        public frmCrysXK()
        {
            InitializeComponent();
        }

        private void frmCrysXK_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = XuatKhoDAO.CrysXK(mapxuat);
            CrysXK cry = new CrysXK();
            cry.SetDataSource(dt);
            crysXK.ReportSource = cry;
        }
    }
}
