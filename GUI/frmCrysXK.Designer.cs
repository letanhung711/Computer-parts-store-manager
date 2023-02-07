namespace PhanMem_QuanLyKhoLinhKien.GUI
{
    partial class frmCrysXK
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
            this.crysXK = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crysXK
            // 
            this.crysXK.ActiveViewIndex = -1;
            this.crysXK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crysXK.Cursor = System.Windows.Forms.Cursors.Default;
            this.crysXK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crysXK.Location = new System.Drawing.Point(0, 0);
            this.crysXK.Name = "crysXK";
            this.crysXK.Size = new System.Drawing.Size(1170, 517);
            this.crysXK.TabIndex = 0;
            // 
            // frmCrysXK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 517);
            this.Controls.Add(this.crysXK);
            this.Name = "frmCrysXK";
            this.Text = "In phiếu xuất";
            this.Load += new System.EventHandler(this.frmCrysXK_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crysXK;
    }
}