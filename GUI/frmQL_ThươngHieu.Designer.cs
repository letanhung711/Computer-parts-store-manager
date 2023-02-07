namespace PhanMem_QuanLyKhoLinhKien
{
    partial class QLThuongHieu
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
            this.btnNew = new System.Windows.Forms.Button();
            this.dtNgaycn = new System.Windows.Forms.DateTimePicker();
            this.dtNgayTao = new System.Windows.Forms.DateTimePicker();
            this.txtTenTH = new System.Windows.Forms.TextBox();
            this.txtMaTH = new System.Windows.Forms.TextBox();
            this.cbNhomLK = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lvThuongHieu = new System.Windows.Forms.ListView();
            this.mathuonghieu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tenthuonghieu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IDnhom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ngaytao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ngaycapnhat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
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
            this.label1.Location = new System.Drawing.Point(303, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thông tin thương hiệu";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNew);
            this.groupBox1.Controls.Add(this.dtNgaycn);
            this.groupBox1.Controls.Add(this.dtNgayTao);
            this.groupBox1.Controls.Add(this.txtTenTH);
            this.groupBox1.Controls.Add(this.txtMaTH);
            this.groupBox1.Controls.Add(this.cbNhomLK);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(52, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(636, 185);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin thương hiệu";
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(539, 126);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 30);
            this.btnNew.TabIndex = 8;
            this.btnNew.Text = "Làm mới";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // dtNgaycn
            // 
            this.dtNgaycn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgaycn.Location = new System.Drawing.Point(456, 81);
            this.dtNgaycn.Name = "dtNgaycn";
            this.dtNgaycn.Size = new System.Drawing.Size(158, 21);
            this.dtNgaycn.TabIndex = 9;
            // 
            // dtNgayTao
            // 
            this.dtNgayTao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayTao.Location = new System.Drawing.Point(456, 41);
            this.dtNgayTao.Name = "dtNgayTao";
            this.dtNgayTao.Size = new System.Drawing.Size(158, 21);
            this.dtNgayTao.TabIndex = 8;
            // 
            // txtTenTH
            // 
            this.txtTenTH.Location = new System.Drawing.Point(128, 123);
            this.txtTenTH.Name = "txtTenTH";
            this.txtTenTH.Size = new System.Drawing.Size(185, 21);
            this.txtTenTH.TabIndex = 7;
            // 
            // txtMaTH
            // 
            this.txtMaTH.Location = new System.Drawing.Point(128, 81);
            this.txtMaTH.Name = "txtMaTH";
            this.txtMaTH.Size = new System.Drawing.Size(115, 21);
            this.txtMaTH.TabIndex = 6;
            // 
            // cbNhomLK
            // 
            this.cbNhomLK.FormattingEnabled = true;
            this.cbNhomLK.Location = new System.Drawing.Point(128, 39);
            this.cbNhomLK.Name = "cbNhomLK";
            this.cbNhomLK.Size = new System.Drawing.Size(185, 23);
            this.cbNhomLK.TabIndex = 5;
            this.cbNhomLK.SelectedIndexChanged += new System.EventHandler(this.cbNhomLK_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(362, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "Ngày cập nhật:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(392, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ngày tạo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tên thương hiệu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã thương hiệu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nhóm linh kiện:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lvThuongHieu);
            this.groupBox2.Location = new System.Drawing.Point(52, 262);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(812, 343);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách thương hiệu";
            // 
            // lvThuongHieu
            // 
            this.lvThuongHieu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.mathuonghieu,
            this.tenthuonghieu,
            this.IDnhom,
            this.ngaytao,
            this.ngaycapnhat});
            this.lvThuongHieu.FullRowSelect = true;
            this.lvThuongHieu.GridLines = true;
            this.lvThuongHieu.Location = new System.Drawing.Point(6, 20);
            this.lvThuongHieu.Name = "lvThuongHieu";
            this.lvThuongHieu.Size = new System.Drawing.Size(800, 317);
            this.lvThuongHieu.TabIndex = 0;
            this.lvThuongHieu.UseCompatibleStateImageBehavior = false;
            this.lvThuongHieu.View = System.Windows.Forms.View.Details;
            this.lvThuongHieu.Click += new System.EventHandler(this.lvThuongHieu_Click);
            // 
            // mathuonghieu
            // 
            this.mathuonghieu.Text = "Mã thương hiệu";
            this.mathuonghieu.Width = 113;
            // 
            // tenthuonghieu
            // 
            this.tenthuonghieu.Text = "Tên thương hiệu";
            this.tenthuonghieu.Width = 228;
            // 
            // IDnhom
            // 
            this.IDnhom.Text = "ID nhóm";
            this.IDnhom.Width = 124;
            // 
            // ngaytao
            // 
            this.ngaytao.Text = "Ngày tạo";
            this.ngaytao.Width = 172;
            // 
            // ngaycapnhat
            // 
            this.ngaycapnhat.Text = "Ngày cập nhật";
            this.ngaycapnhat.Width = 164;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnXoa);
            this.groupBox3.Controls.Add(this.btnUpdate);
            this.groupBox3.Controls.Add(this.btnThem);
            this.groupBox3.Location = new System.Drawing.Point(731, 71);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(133, 185);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tác vụ";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(30, 84);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 30);
            this.btnXoa.TabIndex = 0;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(30, 136);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 30);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(30, 32);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 30);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // QLThuongHieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 609);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QLThuongHieu";
            this.Text = "QLThuongHieu";
            this.Load += new System.EventHandler(this.QLThuongHieu_Load);
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
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.TextBox txtTenTH;
        private System.Windows.Forms.TextBox txtMaTH;
        private System.Windows.Forms.ComboBox cbNhomLK;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ListView lvThuongHieu;
        private System.Windows.Forms.DateTimePicker dtNgaycn;
        private System.Windows.Forms.DateTimePicker dtNgayTao;
        private System.Windows.Forms.ColumnHeader mathuonghieu;
        private System.Windows.Forms.ColumnHeader tenthuonghieu;
        private System.Windows.Forms.ColumnHeader IDnhom;
        private System.Windows.Forms.ColumnHeader ngaytao;
        private System.Windows.Forms.ColumnHeader ngaycapnhat;
    }
}