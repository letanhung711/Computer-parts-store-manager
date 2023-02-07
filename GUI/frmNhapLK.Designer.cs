namespace PhanMem_QuanLyKhoLinhKien.GUI
{
    partial class frmNhapLK
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
            this.numsl = new System.Windows.Forms.NumericUpDown();
            this.cbnv = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbtenlk = new System.Windows.Forms.ComboBox();
            this.txtgianhap = new System.Windows.Forms.TextBox();
            this.txtmalk = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnlammoi = new System.Windows.Forms.Button();
            this.lvlist = new System.Windows.Forms.ListView();
            this.stt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.malk = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tenlk = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.soluong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gianhap = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.thanhtien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.lbltongtien = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbltsl = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btncapnhat = new System.Windows.Forms.Button();
            this.btntt = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnxacnhan = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numsl)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numsl);
            this.groupBox1.Controls.Add(this.cbnv);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cbtenlk);
            this.groupBox1.Controls.Add(this.txtgianhap);
            this.groupBox1.Controls.Add(this.txtmalk);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(28, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(554, 127);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhập linh kiện";
            // 
            // numsl
            // 
            this.numsl.Location = new System.Drawing.Point(93, 96);
            this.numsl.Name = "numsl";
            this.numsl.Size = new System.Drawing.Size(75, 20);
            this.numsl.TabIndex = 12;
            // 
            // cbnv
            // 
            this.cbnv.FormattingEnabled = true;
            this.cbnv.Location = new System.Drawing.Point(366, 62);
            this.cbnv.Name = "cbnv";
            this.cbnv.Size = new System.Drawing.Size(158, 21);
            this.cbnv.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(301, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Nhân viên:";
            // 
            // cbtenlk
            // 
            this.cbtenlk.FormattingEnabled = true;
            this.cbtenlk.Location = new System.Drawing.Point(93, 62);
            this.cbtenlk.Name = "cbtenlk";
            this.cbtenlk.Size = new System.Drawing.Size(175, 21);
            this.cbtenlk.TabIndex = 9;
            this.cbtenlk.SelectedIndexChanged += new System.EventHandler(this.cbtenlk_SelectedIndexChanged);
            // 
            // txtgianhap
            // 
            this.txtgianhap.Location = new System.Drawing.Point(366, 29);
            this.txtgianhap.Name = "txtgianhap";
            this.txtgianhap.Size = new System.Drawing.Size(161, 20);
            this.txtgianhap.TabIndex = 8;
            this.txtgianhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtgianhap_KeyPress);
            // 
            // txtmalk
            // 
            this.txtmalk.Enabled = false;
            this.txtmalk.Location = new System.Drawing.Point(93, 29);
            this.txtmalk.Name = "txtmalk";
            this.txtmalk.Size = new System.Drawing.Size(175, 20);
            this.txtmalk.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(307, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giá nhập:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số lượng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên linh kiện:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã linh kiện:";
            // 
            // btnlammoi
            // 
            this.btnlammoi.Location = new System.Drawing.Point(469, 156);
            this.btnlammoi.Name = "btnlammoi";
            this.btnlammoi.Size = new System.Drawing.Size(75, 30);
            this.btnlammoi.TabIndex = 10;
            this.btnlammoi.Text = "Làm mới";
            this.btnlammoi.UseVisualStyleBackColor = true;
            this.btnlammoi.Click += new System.EventHandler(this.btnlammoi_Click);
            // 
            // lvlist
            // 
            this.lvlist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.stt,
            this.malk,
            this.tenlk,
            this.soluong,
            this.gianhap,
            this.thanhtien});
            this.lvlist.FullRowSelect = true;
            this.lvlist.GridLines = true;
            this.lvlist.Location = new System.Drawing.Point(28, 228);
            this.lvlist.Name = "lvlist";
            this.lvlist.Size = new System.Drawing.Size(554, 248);
            this.lvlist.TabIndex = 1;
            this.lvlist.UseCompatibleStateImageBehavior = false;
            this.lvlist.View = System.Windows.Forms.View.Details;
            this.lvlist.Click += new System.EventHandler(this.lvlist_Click);
            // 
            // stt
            // 
            this.stt.Text = "STT";
            // 
            // malk
            // 
            this.malk.Text = "Mã linh kiện";
            this.malk.Width = 81;
            // 
            // tenlk
            // 
            this.tenlk.Text = "Tên linh kiện";
            this.tenlk.Width = 120;
            // 
            // soluong
            // 
            this.soluong.Text = "Số lượng";
            this.soluong.Width = 63;
            // 
            // gianhap
            // 
            this.gianhap.Text = "Giá nhập";
            this.gianhap.Width = 116;
            // 
            // thanhtien
            // 
            this.thanhtien.Text = "Thành tiền";
            this.thanhtien.Width = 107;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(422, 490);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Tổng tiền:";
            // 
            // lbltongtien
            // 
            this.lbltongtien.AutoSize = true;
            this.lbltongtien.Location = new System.Drawing.Point(483, 490);
            this.lbltongtien.Name = "lbltongtien";
            this.lbltongtien.Size = new System.Drawing.Size(39, 13);
            this.lbltongtien.TabIndex = 3;
            this.lbltongtien.Text = "0 VND";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 490);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Tổng số lượng:";
            // 
            // lbltsl
            // 
            this.lbltsl.AutoSize = true;
            this.lbltsl.Location = new System.Drawing.Point(128, 490);
            this.lbltsl.Name = "lbltsl";
            this.lbltsl.Size = new System.Drawing.Size(13, 13);
            this.lbltsl.TabIndex = 5;
            this.lbltsl.Text = "0";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btncapnhat);
            this.groupBox2.Controls.Add(this.btntt);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Location = new System.Drawing.Point(28, 156);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(413, 66);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tác vụ";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(116, 22);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 30);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btncapnhat
            // 
            this.btncapnhat.Location = new System.Drawing.Point(213, 22);
            this.btncapnhat.Name = "btncapnhat";
            this.btncapnhat.Size = new System.Drawing.Size(75, 30);
            this.btncapnhat.TabIndex = 1;
            this.btncapnhat.Text = "Cập nhật";
            this.btncapnhat.UseVisualStyleBackColor = true;
            this.btncapnhat.Click += new System.EventHandler(this.btncapnhat_Click);
            // 
            // btntt
            // 
            this.btntt.Location = new System.Drawing.Point(310, 22);
            this.btntt.Name = "btntt";
            this.btntt.Size = new System.Drawing.Size(82, 30);
            this.btntt.TabIndex = 7;
            this.btntt.Text = "Tính tổng tiền";
            this.btntt.UseVisualStyleBackColor = true;
            this.btntt.Click += new System.EventHandler(this.btntt_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(19, 22);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 30);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnxacnhan
            // 
            this.btnxacnhan.Location = new System.Drawing.Point(469, 192);
            this.btnxacnhan.Name = "btnxacnhan";
            this.btnxacnhan.Size = new System.Drawing.Size(113, 30);
            this.btnxacnhan.TabIndex = 8;
            this.btnxacnhan.Text = "Xác nhận nhập";
            this.btnxacnhan.UseVisualStyleBackColor = true;
            this.btnxacnhan.Visible = false;
            this.btnxacnhan.Click += new System.EventHandler(this.btnxacnhan_Click);
            // 
            // frmNhapLK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 516);
            this.Controls.Add(this.btnlammoi);
            this.Controls.Add(this.btnxacnhan);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lbltsl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbltongtien);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lvlist);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmNhapLK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập linh kiện";
            this.Load += new System.EventHandler(this.frmNhapLK_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numsl)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbtenlk;
        private System.Windows.Forms.TextBox txtgianhap;
        private System.Windows.Forms.TextBox txtmalk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView lvlist;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbltongtien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbltsl;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnlammoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btncapnhat;
        private System.Windows.Forms.Button btntt;
        private System.Windows.Forms.Button btnxacnhan;
        private System.Windows.Forms.ColumnHeader stt;
        private System.Windows.Forms.ColumnHeader malk;
        private System.Windows.Forms.ColumnHeader tenlk;
        private System.Windows.Forms.ColumnHeader soluong;
        private System.Windows.Forms.ColumnHeader gianhap;
        private System.Windows.Forms.ColumnHeader thanhtien;
        private System.Windows.Forms.ComboBox cbnv;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numsl;
    }
}