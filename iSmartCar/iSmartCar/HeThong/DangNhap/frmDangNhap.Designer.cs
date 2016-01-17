namespace iSmartCar
{
    partial class frmDangNhap
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
            this._txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this._txtMatKhau = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this._btnDangNhap = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // _txtTaiKhoan
            // 
            this._txtTaiKhoan.Location = new System.Drawing.Point(122, 161);
            this._txtTaiKhoan.Margin = new System.Windows.Forms.Padding(4);
            this._txtTaiKhoan.MaxLength = 50;
            this._txtTaiKhoan.Name = "_txtTaiKhoan";
            this._txtTaiKhoan.Size = new System.Drawing.Size(248, 23);
            this._txtTaiKhoan.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 140);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tài khoản";
            // 
            // _txtMatKhau
            // 
            this._txtMatKhau.Location = new System.Drawing.Point(122, 217);
            this._txtMatKhau.Margin = new System.Windows.Forms.Padding(4);
            this._txtMatKhau.MaxLength = 50;
            this._txtMatKhau.Name = "_txtMatKhau";
            this._txtMatKhau.Size = new System.Drawing.Size(248, 23);
            this._txtMatKhau.TabIndex = 1;
            this._txtMatKhau.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 196);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mật khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(372, 164);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "(*)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(371, 220);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "(*)";
            // 
            // _btnDangNhap
            // 
            this._btnDangNhap.Image = global::iSmartCar.Properties.Resources.thong_tin_chung;
            this._btnDangNhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnDangNhap.Location = new System.Drawing.Point(185, 248);
            this._btnDangNhap.Name = "_btnDangNhap";
            this._btnDangNhap.Size = new System.Drawing.Size(105, 26);
            this._btnDangNhap.TabIndex = 2;
            this._btnDangNhap.Text = "Đăng nhập";
            this._btnDangNhap.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._btnDangNhap.UseVisualStyleBackColor = true;
            this._btnDangNhap.Click += new System.EventHandler(this.OnBtnDangNhapMouseClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::iSmartCar.Properties.Resources.xe_header;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(481, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmDangNhap
            // 
            this.AcceptButton = this._btnDangNhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(481, 281);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._btnDangNhap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._txtMatKhau);
            this.Controls.Add(this._txtTaiKhoan);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập vào phần mềm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox _txtTaiKhoan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _txtMatKhau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button _btnDangNhap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}