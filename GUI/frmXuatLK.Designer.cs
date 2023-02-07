namespace PhanMem_QuanLyKhoLinhKien.GUI
{
    partial class frmXuatLK
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbnv = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.txttenkh = new System.Windows.Forms.TextBox();
            this.txtgiaxuat = new System.Windows.Forms.TextBox();
            this.numsl = new System.Windows.Forms.NumericUpDown();
            this.cbtenlk = new System.Windows.Forms.ComboBox();
            this.txtmalk = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btntongtien = new System.Windows.Forms.Button();
            this.btncapnhat = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.lvds = new System.Windows.Forms.ListView();
            this.stt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.malk = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tenlk = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sl = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.giaxuat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.thanhtien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbltongsl = new System.Windows.Forms.Label();
            this.lbltongtien = new System.Windows.Forms.Label();
            this.btnlammoi = new System.Windows.Forms.Button();
            this.btnxacnhan = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numsl)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbnv);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtsdt);
            this.groupBox1.Controls.Add(this.txtdiachi);
            this.groupBox1.Controls.Add(this.txttenkh);
            this.groupBox1.Controls.Add(this.txtgiaxuat);
            this.groupBox1.Controls.Add(this.numsl);
            this.groupBox1.Controls.Add(this.cbtenlk);
            this.groupBox1.Controls.Add(this.txtmalk);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(30, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(553, 154);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin xuất linh kiện";
            // 
            // cbnv
            // 
            this.cbnv.FormattingEnabled = true;
            this.cbnv.Location = new System.Drawing.Point(372, 122);
            this.cbnv.Name = "cbnv";
            this.cbnv.Size = new System.Drawing.Size(163, 21);
            this.cbnv.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(308, 125);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Nhân viên:";
            // 
            // txtsdt
            // 
            this.txtsdt.Location = new System.Drawing.Point(373, 92);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(162, 20);
            this.txtsdt.TabIndex = 13;
            this.txtsdt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsdt_KeyPress);
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(373, 60);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(162, 20);
            this.txtdiachi.TabIndex = 12;
            // 
            // txttenkh
            // 
            this.txttenkh.Location = new System.Drawing.Point(373, 28);
            this.txttenkh.Name = "txttenkh";
            this.txttenkh.Size = new System.Drawing.Size(162, 20);
            this.txttenkh.TabIndex = 11;
            // 
            // txtgiaxuat
            // 
            this.txtgiaxuat.Location = new System.Drawing.Point(94, 122);
            this.txtgiaxuat.Name = "txtgiaxuat";
            this.txtgiaxuat.Size = new System.Drawing.Size(163, 20);
            this.txtgiaxuat.TabIndex = 10;
            this.txtgiaxuat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtgiaxuat_KeyPress);
            // 
            // numsl
            // 
            this.numsl.Location = new System.Drawing.Point(94, 91);
            this.numsl.Name = "numsl";
            this.numsl.Size = new System.Drawing.Size(79, 20);
            this.numsl.TabIndex = 9;
            // 
            // cbtenlk
            // 
            this.cbtenlk.FormattingEnabled = true;
            this.cbtenlk.Location = new System.Drawing.Point(94, 58);
            this.cbtenlk.Name = "cbtenlk";
            this.cbtenlk.Size = new System.Drawing.Size(163, 21);
            this.cbtenlk.TabIndex = 8;
            this.cbtenlk.SelectedIndexChanged += new System.EventHandler(this.cbtenlk_SelectedIndexChanged);
            // 
            // txtmalk
            // 
            this.txtmalk.Enabled = false;
            this.txtmalk.Location = new System.Drawing.Point(94, 26);
            this.txtmalk.Name = "txtmalk";
            this.txtmalk.Size = new System.Drawing.Size(163, 20);
            this.txtmalk.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(294, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Số điện thoại:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(324, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Địa chỉ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(278, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tên khách hàng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giá xuất:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số lượng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên linh kiện:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã linh kiện:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btntongtien);
            this.groupBox2.Controls.Add(this.btncapnhat);
            this.groupBox2.Controls.Add(this.btnxoa);
            this.groupBox2.Controls.Add(this.btnthem);
            this.groupBox2.Location = new System.Drawing.Point(30, 172);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(373, 74);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tác vụ";
            // 
            // btntongtien
            // 
            this.btntongtien.Location = new System.Drawing.Point(276, 27);
            this.btntongtien.Name = "btntongtien";
            this.btntongtien.Size = new System.Drawing.Size(82, 30);
            this.btntongtien.TabIndex = 3;
            this.btntongtien.Text = "Tính tổng tiền";
            this.btntongtien.UseVisualStyleBackColor = true;
            this.btntongtien.Click += new System.EventHandler(this.btntongtien_Click);
            // 
            // btncapnhat
            // 
            this.btncapnhat.Location = new System.Drawing.Point(190, 27);
            this.btncapnhat.Name = "btncapnhat";
            this.btncapnhat.Size = new System.Drawing.Size(75, 30);
            this.btncapnhat.TabIndex = 2;
            this.btncapnhat.Text = "Cập nhật";
            this.btncapnhat.UseVisualStyleBackColor = true;
            this.btncapnhat.Click += new System.EventHandler(this.btncapnhat_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(104, 27);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 30);
            this.btnxoa.TabIndex = 1;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(18, 27);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 30);
            this.btnthem.TabIndex = 0;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // lvds
            // 
            this.lvds.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.stt,
            this.malk,
            this.tenlk,
            this.sl,
            this.giaxuat,
            this.thanhtien});
            this.lvds.FullRowSelect = true;
            this.lvds.GridLines = true;
            this.lvds.Location = new System.Drawing.Point(30, 252);
            this.lvds.Name = "lvds";
            this.lvds.Size = new System.Drawing.Size(553, 230);
            this.lvds.TabIndex = 2;
            this.lvds.UseCompatibleStateImageBehavior = false;
            this.lvds.View = System.Windows.Forms.View.Details;
            this.lvds.Click += new System.EventHandler(this.lvds_Click);
            // 
            // stt
            // 
            this.stt.Text = "STT";
            // 
            // malk
            // 
            this.malk.Text = "Mã linh kiện";
            this.malk.Width = 90;
            // 
            // tenlk
            // 
            this.tenlk.Text = "Tên linh kiện";
            this.tenlk.Width = 133;
            // 
            // sl
            // 
            this.sl.Text = "Số lượng";
            // 
            // giaxuat
            // 
            this.giaxuat.Text = "Giá xuất";
            this.giaxuat.Width = 108;
            // 
            // thanhtien
            // 
            this.thanhtien.Text = "Thành tiền";
            this.thanhtien.Width = 90;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(399, 493);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Tổng tiền:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(40, 493);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Tổng số lượng:";
            // 
            // lbltongsl
            // 
            this.lbltongsl.AutoSize = true;
            this.lbltongsl.Location = new System.Drawing.Point(124, 493);
            this.lbltongsl.Name = "lbltongsl";
            this.lbltongsl.Size = new System.Drawing.Size(13, 13);
            this.lbltongsl.TabIndex = 5;
            this.lbltongsl.Text = "0";
            // 
            // lbltongtien
            // 
            this.lbltongtien.AutoSize = true;
            this.lbltongtien.Location = new System.Drawing.Point(460, 493);
            this.lbltongtien.Name = "lbltongtien";
            this.lbltongtien.Size = new System.Drawing.Size(39, 13);
            this.lbltongtien.TabIndex = 6;
            this.lbltongtien.Text = "0 VND";
            // 
            // btnlammoi
            // 
            this.btnlammoi.Location = new System.Drawing.Point(482, 174);
            this.btnlammoi.Name = "btnlammoi";
            this.btnlammoi.Size = new System.Drawing.Size(75, 30);
            this.btnlammoi.TabIndex = 4;
            this.btnlammoi.Text = "Làm mới";
            this.btnlammoi.UseVisualStyleBackColor = true;
            this.btnlammoi.Click += new System.EventHandler(this.btnlammoi_Click);
            // 
            // btnxacnhan
            // 
            this.btnxacnhan.Location = new System.Drawing.Point(482, 213);
            this.btnxacnhan.Name = "btnxacnhan";
            this.btnxacnhan.Size = new System.Drawing.Size(92, 30);
            this.btnxacnhan.TabIndex = 7;
            this.btnxacnhan.Text = "Xác nhận xuất";
            this.btnxacnhan.UseVisualStyleBackColor = true;
            this.btnxacnhan.Visible = false;
            this.btnxacnhan.Click += new System.EventHandler(this.btnxacnhan_Click);
            // 
            // frmXuatLK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 516);
            this.Controls.Add(this.btnxacnhan);
            this.Controls.Add(this.btnlammoi);
            this.Controls.Add(this.lbltongtien);
            this.Controls.Add(this.lbltongsl);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lvds);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmXuatLK";
            this.Text = "Xuất linh kiện";
            this.Load += new System.EventHandler(this.frmXuatLK_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numsl)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numsl;
        private System.Windows.Forms.ComboBox cbtenlk;
        private System.Windows.Forms.TextBox txtmalk;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.TextBox txttenkh;
        private System.Windows.Forms.TextBox txtgiaxuat;
        private System.Windows.Forms.Button btntongtien;
        private System.Windows.Forms.Button btncapnhat;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.ListView lvds;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbltongsl;
        private System.Windows.Forms.Label lbltongtien;
        private System.Windows.Forms.Button btnlammoi;
        private System.Windows.Forms.Button btnxacnhan;
        private System.Windows.Forms.ColumnHeader stt;
        private System.Windows.Forms.ColumnHeader malk;
        private System.Windows.Forms.ColumnHeader tenlk;
        private System.Windows.Forms.ColumnHeader sl;
        private System.Windows.Forms.ColumnHeader giaxuat;
        private System.Windows.Forms.ColumnHeader thanhtien;
        private System.Windows.Forms.ComboBox cbnv;
        private System.Windows.Forms.Label label10;
    }
}