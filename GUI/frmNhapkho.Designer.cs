namespace PhanMem_QuanLyKhoLinhKien.GUI
{
    partial class frmNhapkho
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnv = new System.Windows.Forms.TextBox();
            this.btnlammoi = new System.Windows.Forms.Button();
            this.txtsl = new System.Windows.Forms.TextBox();
            this.dtpNgaynhap = new System.Windows.Forms.DateTimePicker();
            this.txttongtien = new System.Windows.Forms.TextBox();
            this.txtMapnhap = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lvds = new System.Windows.Forms.ListView();
            this.mapnhap = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tongsl = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ngaynhap = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nhanvien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tongtien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btncapnhat = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lvlk = new System.Windows.Forms.ListView();
            this.tenlk = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sl = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(106)))), ((int)(((byte)(191)))));
            this.label1.Location = new System.Drawing.Point(379, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập kho";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtnv);
            this.groupBox1.Controls.Add(this.btnlammoi);
            this.groupBox1.Controls.Add(this.txtsl);
            this.groupBox1.Controls.Add(this.dtpNgaynhap);
            this.groupBox1.Controls.Add(this.txttongtien);
            this.groupBox1.Controls.Add(this.txtMapnhap);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(27, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(593, 164);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phiếu nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(333, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Nhân viên:";
            // 
            // txtnv
            // 
            this.txtnv.Enabled = false;
            this.txtnv.Location = new System.Drawing.Point(404, 26);
            this.txtnv.Name = "txtnv";
            this.txtnv.Size = new System.Drawing.Size(167, 21);
            this.txtnv.TabIndex = 14;
            // 
            // btnlammoi
            // 
            this.btnlammoi.Location = new System.Drawing.Point(497, 119);
            this.btnlammoi.Name = "btnlammoi";
            this.btnlammoi.Size = new System.Drawing.Size(75, 30);
            this.btnlammoi.TabIndex = 3;
            this.btnlammoi.Text = "Làm mới";
            this.btnlammoi.UseVisualStyleBackColor = true;
            this.btnlammoi.Click += new System.EventHandler(this.btnlammoi_Click);
            // 
            // txtsl
            // 
            this.txtsl.Enabled = false;
            this.txtsl.Location = new System.Drawing.Point(121, 67);
            this.txtsl.Name = "txtsl";
            this.txtsl.Size = new System.Drawing.Size(82, 21);
            this.txtsl.TabIndex = 13;
            // 
            // dtpNgaynhap
            // 
            this.dtpNgaynhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaynhap.Location = new System.Drawing.Point(404, 65);
            this.dtpNgaynhap.Name = "dtpNgaynhap";
            this.dtpNgaynhap.Size = new System.Drawing.Size(140, 21);
            this.dtpNgaynhap.TabIndex = 12;
            // 
            // txttongtien
            // 
            this.txttongtien.Location = new System.Drawing.Point(121, 108);
            this.txttongtien.Name = "txttongtien";
            this.txttongtien.Size = new System.Drawing.Size(156, 21);
            this.txttongtien.TabIndex = 10;
            this.txttongtien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttongtien_KeyPress);
            // 
            // txtMapnhap
            // 
            this.txtMapnhap.Enabled = false;
            this.txtMapnhap.Location = new System.Drawing.Point(121, 26);
            this.txtMapnhap.Name = "txtMapnhap";
            this.txtMapnhap.Size = new System.Drawing.Size(156, 21);
            this.txtMapnhap.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(56, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 15);
            this.label7.TabIndex = 5;
            this.label7.Text = "Số lượng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(329, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "Ngày nhập:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Tổng tiền:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã phiếu nhập:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lvds);
            this.groupBox2.Location = new System.Drawing.Point(27, 315);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(833, 282);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách phiếu nhập";
            // 
            // lvds
            // 
            this.lvds.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.mapnhap,
            this.tongsl,
            this.ngaynhap,
            this.nhanvien,
            this.tongtien});
            this.lvds.FullRowSelect = true;
            this.lvds.GridLines = true;
            this.lvds.Location = new System.Drawing.Point(6, 20);
            this.lvds.Name = "lvds";
            this.lvds.Size = new System.Drawing.Size(821, 256);
            this.lvds.TabIndex = 0;
            this.lvds.UseCompatibleStateImageBehavior = false;
            this.lvds.View = System.Windows.Forms.View.Details;
            this.lvds.Click += new System.EventHandler(this.lvds_Click);
            // 
            // mapnhap
            // 
            this.mapnhap.Text = "Mã phiếu nhập";
            this.mapnhap.Width = 134;
            // 
            // tongsl
            // 
            this.tongsl.Text = "Tổng số lượng";
            this.tongsl.Width = 101;
            // 
            // ngaynhap
            // 
            this.ngaynhap.Text = "Ngày nhập";
            this.ngaynhap.Width = 121;
            // 
            // nhanvien
            // 
            this.nhanvien.Text = "Mã nhân viên";
            this.nhanvien.Width = 97;
            // 
            // tongtien
            // 
            this.tongtien.Text = "Tổng tiền";
            this.tongtien.Width = 114;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnPrint);
            this.groupBox3.Controls.Add(this.btncapnhat);
            this.groupBox3.Controls.Add(this.btnxoa);
            this.groupBox3.Controls.Add(this.btnthem);
            this.groupBox3.Location = new System.Drawing.Point(27, 234);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(411, 75);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tác vụ";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(292, 29);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(97, 30);
            this.btnPrint.TabIndex = 3;
            this.btnPrint.Text = "In phiếu nhập";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btncapnhat
            // 
            this.btncapnhat.Location = new System.Drawing.Point(200, 29);
            this.btncapnhat.Name = "btncapnhat";
            this.btncapnhat.Size = new System.Drawing.Size(75, 30);
            this.btncapnhat.TabIndex = 2;
            this.btncapnhat.Text = "Cập nhật";
            this.btncapnhat.UseVisualStyleBackColor = true;
            this.btncapnhat.Click += new System.EventHandler(this.btncapnhat_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(108, 29);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 30);
            this.btnxoa.TabIndex = 1;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(16, 29);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 30);
            this.btnthem.TabIndex = 0;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnSearch);
            this.groupBox4.Controls.Add(this.txtsearch);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Location = new System.Drawing.Point(484, 234);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(376, 75);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tìm kiếm phiếu nhập";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(280, 29);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(80, 30);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(121, 34);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(153, 21);
            this.txtsearch.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "Mã phiếu nhập:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lvlk);
            this.groupBox5.Location = new System.Drawing.Point(626, 57);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(234, 164);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Linh kiện nhập";
            // 
            // lvlk
            // 
            this.lvlk.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.tenlk,
            this.sl});
            this.lvlk.FullRowSelect = true;
            this.lvlk.GridLines = true;
            this.lvlk.Location = new System.Drawing.Point(6, 20);
            this.lvlk.Name = "lvlk";
            this.lvlk.Size = new System.Drawing.Size(222, 138);
            this.lvlk.TabIndex = 0;
            this.lvlk.UseCompatibleStateImageBehavior = false;
            this.lvlk.View = System.Windows.Forms.View.Details;
            // 
            // tenlk
            // 
            this.tenlk.Text = "Tên linh kiện";
            this.tenlk.Width = 144;
            // 
            // sl
            // 
            this.sl.Text = "Số lượng";
            this.sl.Width = 73;
            // 
            // frmNhapkho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 609);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNhapkho";
            this.Text = "frmNhapkho";
            this.Load += new System.EventHandler(this.frmNhapkho_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMapnhap;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txttongtien;
        private System.Windows.Forms.Button btnlammoi;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btncapnhat;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.DateTimePicker dtpNgaynhap;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListView lvds;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnv;
        private System.Windows.Forms.TextBox txtsl;
        private System.Windows.Forms.ColumnHeader mapnhap;
        private System.Windows.Forms.ColumnHeader tongsl;
        private System.Windows.Forms.ColumnHeader ngaynhap;
        private System.Windows.Forms.ColumnHeader nhanvien;
        private System.Windows.Forms.ColumnHeader tongtien;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ListView lvlk;
        private System.Windows.Forms.ColumnHeader tenlk;
        private System.Windows.Forms.ColumnHeader sl;
        private System.Windows.Forms.Button btnPrint;
    }
}