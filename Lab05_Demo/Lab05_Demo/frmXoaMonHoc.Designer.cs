namespace Lab05_Demo
{
    partial class frmXoaMonHoc
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
            this.lblMonCanXoa = new System.Windows.Forms.Label();
            this.cbXoa = new System.Windows.Forms.ComboBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMonCanXoa
            // 
            this.lblMonCanXoa.AutoSize = true;
            this.lblMonCanXoa.Location = new System.Drawing.Point(103, 103);
            this.lblMonCanXoa.Name = "lblMonCanXoa";
            this.lblMonCanXoa.Size = new System.Drawing.Size(117, 16);
            this.lblMonCanXoa.TabIndex = 0;
            this.lblMonCanXoa.Text = "Chọn môn cần xóa";
            // 
            // cbXoa
            // 
            this.cbXoa.FormattingEnabled = true;
            this.cbXoa.Location = new System.Drawing.Point(262, 100);
            this.cbXoa.Name = "cbXoa";
            this.cbXoa.Size = new System.Drawing.Size(253, 24);
            this.cbXoa.TabIndex = 1;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(348, 165);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // frmXoaMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.cbXoa);
            this.Controls.Add(this.lblMonCanXoa);
            this.Name = "frmXoaMonHoc";
            this.Text = "XoaMonHoc";
            this.Load += new System.EventHandler(this.frmXoaMonHoc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMonCanXoa;
        private System.Windows.Forms.ComboBox cbXoa;
        private System.Windows.Forms.Button btnXoa;
    }
}