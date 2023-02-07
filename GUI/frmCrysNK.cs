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
    public partial class frmCrysNK : Form
    {
        public string mapnhap;

        public frmCrysNK()
        {
            InitializeComponent();
        }

        private void frmCrysNK_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = NhapKhoDAO.CrysNK(mapnhap);
            CrysNK cry = new CrysNK();
            cry.SetDataSource(dt);
            cryNK.ReportSource = cry;
            
        }
    }
}
