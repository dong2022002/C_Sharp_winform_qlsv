namespace Lab05_Demo
{
    partial class frmThemMonHoc
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
            this.btnThemMH = new System.Windows.Forms.Button();
            this.lblmh = new System.Windows.Forms.Label();
            this.txtThemMH = new System.Windows.Forms.TextBox();
            this.btnHuyBo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnThemMH
            // 
            this.btnThemMH.Location = new System.Drawing.Point(267, 214);
            this.btnThemMH.Name = "btnThemMH";
            this.btnThemMH.Size = new System.Drawing.Size(82, 28);
            this.btnThemMH.TabIndex = 0;
            this.btnThemMH.Text = "Thêm";
            this.btnThemMH.UseVisualStyleBackColor = true;
            this.btnThemMH.Click += new System.EventHandler(this.btnThemMH_Click);
            // 
            // lblmh
            // 
            this.lblmh.AutoSize = true;
            this.lblmh.Location = new System.Drawing.Point(125, 164);
            this.lblmh.Name = "lblmh";
            this.lblmh.Size = new System.Drawing.Size(85, 16);
            this.lblmh.TabIndex = 1;
            this.lblmh.Text = "Tên môn học";
            // 
            // txtThemMH
            // 
            this.txtThemMH.Location = new System.Drawing.Point(267, 161);
            this.txtThemMH.Name = "txtThemMH";
            this.txtThemMH.Size = new System.Drawing.Size(245, 22);
            this.txtThemMH.TabIndex = 2;
            // 
            // btnHuyBo
            // 
            this.btnHuyBo.Location = new System.Drawing.Point(426, 214);
            this.btnHuyBo.Name = "btnHuyBo";
            this.btnHuyBo.Size = new System.Drawing.Size(75, 28);
            this.btnHuyBo.TabIndex = 3;
            this.btnHuyBo.Text = "hủy bỏ";
            this.btnHuyBo.UseVisualStyleBackColor = true;
            this.btnHuyBo.Click += new System.EventHandler(this.btnHuyBo_Click);
            // 
            // frmThemMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHuyBo);
            this.Controls.Add(this.txtThemMH);
            this.Controls.Add(this.lblmh);
            this.Controls.Add(this.btnThemMH);
            this.Name = "frmThemMonHoc";
            this.Text = "Thêm môn học";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThemMH;
        private System.Windows.Forms.Label lblmh;
        private System.Windows.Forms.TextBox txtThemMH;
        private System.Windows.Forms.Button btnHuyBo;
    }
}