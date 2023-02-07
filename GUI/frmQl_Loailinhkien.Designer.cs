namespace PhanMem_QuanLyKhoLinhKien.GUI
{
    partial class frmQl_Loailinhkien
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
            this.dtngaycn = new System.Windows.Forms.DateTimePicker();
            this.dtngaytao = new System.Windows.Forms.DateTimePicker();
            this.txtTenloai = new System.Windows.Forms.TextBox();
            this.txtMaloai = new System.Windows.Forms.TextBox();
            this.cbNhomLK = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lvdanhsachloaiLK = new System.Windows.Forms.ListView();
            this.maloai = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tenloai = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ngaytao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ngaycapnhat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.idnhom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnlammoi = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(106)))), ((int)(((byte)(191)))));
            this.label1.Location = new System.Drawing.Point(295, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin loại linh kiện";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtngaycn);
            this.groupBox1.Controls.Add(this.dtngaytao);
            this.groupBox1.Controls.Add(this.txtTenloai);
            this.groupBox1.Controls.Add(this.txtMaloai);
            this.groupBox1.Controls.Add(this.cbNhomLK);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(38, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 282);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin loại linh kiện";
            // 
            // dtngaycn
            // 
            this.dtngaycn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtngaycn.Location = new System.Drawing.Point(122, 215);
            this.dtngaycn.Name = "dtngaycn";
            this.dtngaycn.Size = new System.Drawing.Size(180, 21);
            this.dtngaycn.TabIndex = 9;
            // 
            // dtngaytao
            // 
            this.dtngaytao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtngaytao.Location = new System.Drawing.Point(122, 172);
            this.dtngaytao.Name = "dtngaytao";
            this.dtngaytao.Size = new System.Drawing.Size(180, 21);
            this.dtngaytao.TabIndex = 8;
            // 
            // txtTenloai
            // 
            this.txtTenloai.Location = new System.Drawing.Point(122, 131);
            this.txtTenloai.Name = "txtTenloai";
            this.txtTenloai.Size = new System.Drawing.Size(180, 21);
            this.txtTenloai.TabIndex = 7;
            // 
            // txtMaloai
            // 
            this.txtMaloai.Location = new System.Drawing.Point(122, 91);
            this.txtMaloai.Name = "txtMaloai";
            this.txtMaloai.Size = new System.Drawing.Size(100, 21);
            this.txtMaloai.TabIndex = 6;
            // 
            // cbNhomLK
            // 
            this.cbNhomLK.FormattingEnabled = true;
            this.cbNhomLK.Location = new System.Drawing.Point(122, 45);
            this.cbNhomLK.Name = "cbNhomLK";
            this.cbNhomLK.Size = new System.Drawing.Size(180, 23);
            this.cbNhomLK.TabIndex = 5;
            this.cbNhomLK.SelectedIndexChanged += new System.EventHandler(this.cbNhomLK_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "Ngày cập nhật:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ngày tạo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tên loại:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã loại:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nhóm linh kiện:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lvdanhsachloaiLK);
            this.groupBox2.Location = new System.Drawing.Point(388, 108);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(470, 433);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách loại linh kiện";
            // 
            // lvdanhsachloaiLK
            // 
            this.lvdanhsachloaiLK.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.maloai,
            this.tenloai,
            this.ngaytao,
            this.ngaycapnhat,
            this.idnhom});
            this.lvdanhsachloaiLK.FullRowSelect = true;
            this.lvdanhsachloaiLK.GridLines = true;
            this.lvdanhsachloaiLK.Location = new System.Drawing.Point(6, 20);
            this.lvdanhsachloaiLK.Name = "lvdanhsachloaiLK";
            this.lvdanhsachloaiLK.Size = new System.Drawing.Size(458, 407);
            this.lvdanhsachloaiLK.TabIndex = 0;
            this.lvdanhsachloaiLK.UseCompatibleStateImageBehavior = false;
            this.lvdanhsachloaiLK.View = System.Windows.Forms.View.Details;
            this.lvdanhsachloaiLK.Click += new System.EventHandler(this.lvdanhsachloaiLK_Click);
            // 
            // maloai
            // 
            this.maloai.Text = "Mã loại";
            this.maloai.Width = 84;
            // 
            // tenloai
            // 
            this.tenloai.Text = "Tên loại";
            this.tenloai.Width = 110;
            // 
            // ngaytao
            // 
            this.ngaytao.Text = "Ngày tạo";
            this.ngaytao.Width = 82;
            // 
            // ngaycapnhat
            // 
            this.ngaycapnhat.Text = "Ngày cập nhật";
            this.ngaycapnhat.Width = 92;
            // 
            // idnhom
            // 
            this.idnhom.Text = "ID nhóm";
            this.idnhom.Width = 85;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSua);
            this.groupBox3.Controls.Add(this.btnXoa);
            this.groupBox3.Controls.Add(this.btnThem);
            this.groupBox3.Location = new System.Drawing.Point(38, 438);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(322, 87);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tác vụ";
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(226, 35);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 30);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Cập nhật";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(126, 35);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 30);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(26, 35);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 30);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnlammoi
            // 
            this.btnlammoi.Location = new System.Drawing.Point(275, 402);
            this.btnlammoi.Name = "btnlammoi";
            this.btnlammoi.Size = new System.Drawing.Size(75, 30);
            this.btnlammoi.TabIndex = 10;
            this.btnlammoi.Text = "Làm mới";
            this.btnlammoi.UseVisualStyleBackColor = true;
            this.btnlammoi.Click += new System.EventHandler(this.btnlammoi_Click);
            // 
            // frmQl_Loailinhkien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 609);
            this.Controls.Add(this.btnlammoi);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmQl_Loailinhkien";
            this.Text = "frmQl_Loailinhkien";
            this.Load += new System.EventHandler(this.frmQl_Loailinhkien_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTenloai;
        private System.Windows.Forms.TextBox txtMaloai;
        private System.Windows.Forms.ComboBox cbNhomLK;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lvdanhsachloaiLK;
        private System.Windows.Forms.ColumnHeader maloai;
        private System.Windows.Forms.ColumnHeader tenloai;
        private System.Windows.Forms.ColumnHeader ngaytao;
        private System.Windows.Forms.ColumnHeader ngaycapnhat;
        private System.Windows.Forms.ColumnHeader idnhom;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnlammoi;
        private System.Windows.Forms.DateTimePicker dtngaycn;
        private System.Windows.Forms.DateTimePicker dtngaytao;
    }
}