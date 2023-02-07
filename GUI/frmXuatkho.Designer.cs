namespace PhanMem_QuanLyKhoLinhKien.GUI
{
    partial class frmXuatkho
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
            this.txttongsl = new System.Windows.Forms.TextBox();
            this.txttongtien = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtKH = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpNgayxuat = new System.Windows.Forms.DateTimePicker();
            this.txtNV = new System.Windows.Forms.TextBox();
            this.txtMapxuat = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lvds = new System.Windows.Forms.ListView();
            this.mapxuat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tongsl = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ngayxuat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.manv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.makh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tongtien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btncapnhat = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnlammoi = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.txtSearchpxuat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lvlk = new System.Windows.Forms.ListView();
            this.tenlk = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.slxuat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(106)))), ((int)(((byte)(191)))));
            this.label1.Location = new System.Drawing.Point(381, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Xuất kho";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txttongsl);
            this.groupBox1.Controls.Add(this.txttongtien);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtKH);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.dtpNgayxuat);
            this.groupBox1.Controls.Add(this.txtNV);
            this.groupBox1.Controls.Add(this.txtMapxuat);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(25, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(604, 148);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phiếu xuất";
            // 
            // txttongsl
            // 
            this.txttongsl.Enabled = false;
            this.txttongsl.Location = new System.Drawing.Point(116, 70);
            this.txttongsl.Name = "txttongsl";
            this.txttongsl.Size = new System.Drawing.Size(88, 21);
            this.txttongsl.TabIndex = 19;
            // 
            // txttongtien
            // 
            this.txttongtien.Location = new System.Drawing.Point(116, 112);
            this.txttongtien.Name = "txttongtien";
            this.txttongtien.Size = new System.Drawing.Size(170, 21);
            this.txttongtien.TabIndex = 16;
            this.txttongtien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttongtien_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(49, 115);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 15);
            this.label10.TabIndex = 15;
            this.label10.Text = "Tổng tiền:";
            // 
            // txtKH
            // 
            this.txtKH.Enabled = false;
            this.txtKH.Location = new System.Drawing.Point(404, 28);
            this.txtKH.Name = "txtKH";
            this.txtKH.Size = new System.Drawing.Size(170, 21);
            this.txtKH.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(300, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 15);
            this.label9.TabIndex = 13;
            this.label9.Text = "Tên khách hàng:";
            // 
            // dtpNgayxuat
            // 
            this.dtpNgayxuat.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayxuat.Location = new System.Drawing.Point(404, 110);
            this.dtpNgayxuat.Name = "dtpNgayxuat";
            this.dtpNgayxuat.Size = new System.Drawing.Size(170, 21);
            this.dtpNgayxuat.TabIndex = 11;
            // 
            // txtNV
            // 
            this.txtNV.Enabled = false;
            this.txtNV.Location = new System.Drawing.Point(404, 70);
            this.txtNV.Name = "txtNV";
            this.txtNV.Size = new System.Drawing.Size(170, 21);
            this.txtNV.TabIndex = 10;
            // 
            // txtMapxuat
            // 
            this.txtMapxuat.Enabled = false;
            this.txtMapxuat.Location = new System.Drawing.Point(116, 28);
            this.txtMapxuat.Name = "txtMapxuat";
            this.txtMapxuat.Size = new System.Drawing.Size(170, 21);
            this.txtMapxuat.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(333, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 15);
            this.label8.TabIndex = 5;
            this.label8.Text = "Nhân viên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(334, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ngày xuất:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Số lượng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã phiếu xuất:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lvds);
            this.groupBox2.Location = new System.Drawing.Point(25, 298);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(834, 287);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách phiếu xuất";
            // 
            // lvds
            // 
            this.lvds.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.mapxuat,
            this.tongsl,
            this.ngayxuat,
            this.manv,
            this.makh,
            this.tongtien});
            this.lvds.FullRowSelect = true;
            this.lvds.GridLines = true;
            this.lvds.Location = new System.Drawing.Point(6, 20);
            this.lvds.Name = "lvds";
            this.lvds.Size = new System.Drawing.Size(810, 261);
            this.lvds.TabIndex = 0;
            this.lvds.UseCompatibleStateImageBehavior = false;
            this.lvds.View = System.Windows.Forms.View.Details;
            this.lvds.Click += new System.EventHandler(this.lvds_Click);
            // 
            // mapxuat
            // 
            this.mapxuat.Text = "Mã phiếu xuất";
            this.mapxuat.Width = 98;
            // 
            // tongsl
            // 
            this.tongsl.Text = "Tổng số lượng";
            this.tongsl.Width = 93;
            // 
            // ngayxuat
            // 
            this.ngayxuat.Text = "Ngày xuất";
            this.ngayxuat.Width = 101;
            // 
            // manv
            // 
            this.manv.Text = "Mã nhân viên";
            this.manv.Width = 99;
            // 
            // makh
            // 
            this.makh.Text = "Mã khách hàng";
            this.makh.Width = 112;
            // 
            // tongtien
            // 
            this.tongtien.Text = "Tổng tiền";
            this.tongtien.Width = 103;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnPrint);
            this.groupBox3.Controls.Add(this.btncapnhat);
            this.groupBox3.Controls.Add(this.btnxoa);
            this.groupBox3.Controls.Add(this.btnThem);
            this.groupBox3.Location = new System.Drawing.Point(25, 216);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(443, 76);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tác vụ";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(331, 29);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(89, 30);
            this.btnPrint.TabIndex = 3;
            this.btnPrint.Text = "In phiếu xuất";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btncapnhat
            // 
            this.btncapnhat.Location = new System.Drawing.Point(231, 29);
            this.btncapnhat.Name = "btncapnhat";
            this.btncapnhat.Size = new System.Drawing.Size(75, 30);
            this.btncapnhat.TabIndex = 2;
            this.btncapnhat.Text = "Cập nhật";
            this.btncapnhat.UseVisualStyleBackColor = true;
            this.btncapnhat.Click += new System.EventHandler(this.btncapnhat_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(131, 29);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 30);
            this.btnxoa.TabIndex = 1;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(31, 29);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 30);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnlammoi
            // 
            this.btnlammoi.Location = new System.Drawing.Point(541, 197);
            this.btnlammoi.Name = "btnlammoi";
            this.btnlammoi.Size = new System.Drawing.Size(75, 30);
            this.btnlammoi.TabIndex = 5;
            this.btnlammoi.Text = "Làm mới";
            this.btnlammoi.UseVisualStyleBackColor = true;
            this.btnlammoi.Click += new System.EventHandler(this.btnlammoi_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnsearch);
            this.groupBox5.Controls.Add(this.txtSearchpxuat);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Location = new System.Drawing.Point(495, 233);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(364, 59);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Tìm kiếm phiếu xuất";
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(273, 21);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(75, 30);
            this.btnsearch.TabIndex = 2;
            this.btnsearch.Text = "Tìm kiếm";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // txtSearchpxuat
            // 
            this.txtSearchpxuat.Location = new System.Drawing.Point(110, 26);
            this.txtSearchpxuat.Name = "txtSearchpxuat";
            this.txtSearchpxuat.Size = new System.Drawing.Size(157, 21);
            this.txtSearchpxuat.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã phiếu xuất";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lvlk);
            this.groupBox4.Location = new System.Drawing.Point(653, 43);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(206, 167);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Linh kiện xuất";
            // 
            // lvlk
            // 
            this.lvlk.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.tenlk,
            this.slxuat});
            this.lvlk.FullRowSelect = true;
            this.lvlk.GridLines = true;
            this.lvlk.Location = new System.Drawing.Point(6, 20);
            this.lvlk.Name = "lvlk";
            this.lvlk.Size = new System.Drawing.Size(194, 141);
            this.lvlk.TabIndex = 0;
            this.lvlk.UseCompatibleStateImageBehavior = false;
            this.lvlk.View = System.Windows.Forms.View.Details;
            // 
            // tenlk
            // 
            this.tenlk.Text = "Tên linh kiện";
            this.tenlk.Width = 129;
            // 
            // slxuat
            // 
            this.slxuat.Text = "Số lượng";
            // 
            // frmXuatkho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 609);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.btnlammoi);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmXuatkho";
            this.Text = "frmXuatkho";
            this.Load += new System.EventHandler(this.frmXuatkho_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btncapnhat;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnlammoi;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.TextBox txtSearchpxuat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNV;
        private System.Windows.Forms.TextBox txtMapxuat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpNgayxuat;
        private System.Windows.Forms.TextBox txttongtien;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtKH;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txttongsl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView lvds;
        private System.Windows.Forms.ColumnHeader mapxuat;
        private System.Windows.Forms.ColumnHeader tongsl;
        private System.Windows.Forms.ColumnHeader ngayxuat;
        private System.Windows.Forms.ColumnHeader manv;
        private System.Windows.Forms.ColumnHeader makh;
        private System.Windows.Forms.ColumnHeader tongtien;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListView lvlk;
        private System.Windows.Forms.ColumnHeader tenlk;
        private System.Windows.Forms.ColumnHeader slxuat;
    }
}