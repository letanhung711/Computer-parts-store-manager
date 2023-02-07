namespace PhanMem_QuanLyKhoLinhKien.GUI
{
    partial class frmCrysNK
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
            this.cryNK = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // cryNK
            // 
            this.cryNK.ActiveViewIndex = -1;
            this.cryNK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cryNK.Cursor = System.Windows.Forms.Cursors.Default;
            this.cryNK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cryNK.Location = new System.Drawing.Point(0, 0);
            this.cryNK.Name = "cryNK";
            this.cryNK.Size = new System.Drawing.Size(1089, 609);
            this.cryNK.TabIndex = 0;
            // 
            // frmCrysNK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 609);
            this.Controls.Add(this.cryNK);
            this.Name = "frmCrysNK";
            this.Text = "In phiếu nhập";
            this.Load += new System.EventHandler(this.frmCrysNK_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer cryNK;
    }
}