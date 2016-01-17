namespace iSmartCar
{
    partial class frmCauHinhCSDL
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
            this.cbTenCSDL = new System.Windows.Forms.ComboBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.cbMayChu = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLuuThongTin = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnKiemTraKetNoi = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbTenCSDL
            // 
            this.cbTenCSDL.FormattingEnabled = true;
            this.cbTenCSDL.Location = new System.Drawing.Point(114, 199);
            this.cbTenCSDL.Margin = new System.Windows.Forms.Padding(4);
            this.cbTenCSDL.Name = "cbTenCSDL";
            this.cbTenCSDL.Size = new System.Drawing.Size(264, 24);
            this.cbTenCSDL.TabIndex = 32;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(114, 137);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(4);
            this.txtMatKhau.MaxLength = 50;
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(264, 22);
            this.txtMatKhau.TabIndex = 31;
            this.txtMatKhau.UseSystemPasswordChar = true;
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Location = new System.Drawing.Point(115, 107);
            this.txtTenDangNhap.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenDangNhap.MaxLength = 50;
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(264, 22);
            this.txtTenDangNhap.TabIndex = 30;
            // 
            // cbMayChu
            // 
            this.cbMayChu.FormattingEnabled = true;
            this.cbMayChu.Location = new System.Drawing.Point(115, 75);
            this.cbMayChu.Margin = new System.Windows.Forms.Padding(4);
            this.cbMayChu.Name = "cbMayChu";
            this.cbMayChu.Size = new System.Drawing.Size(264, 24);
            this.cbMayChu.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 203);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 16);
            this.label6.TabIndex = 28;
            this.label6.Text = "Tên CSDL:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 140);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 16);
            this.label5.TabIndex = 27;
            this.label5.Text = "Mật khẩu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 110);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 26;
            this.label4.Text = "Tài khoản:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 79);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 25;
            this.label3.Text = "Máy chủ:";
            // 
            // btnLuuThongTin
            // 
            this.btnLuuThongTin.Image = global::iSmartCar.Properties.Resources.LUU_VA_THEM;
            this.btnLuuThongTin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuuThongTin.Location = new System.Drawing.Point(185, 230);
            this.btnLuuThongTin.Name = "btnLuuThongTin";
            this.btnLuuThongTin.Size = new System.Drawing.Size(106, 28);
            this.btnLuuThongTin.TabIndex = 34;
            this.btnLuuThongTin.Text = "Lưu thông tin";
            this.btnLuuThongTin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuuThongTin.UseVisualStyleBackColor = true;
            this.btnLuuThongTin.Click += new System.EventHandler(this.btnLuuThongTin_Click);
            // 
            // btnDong
            // 
            this.btnDong.Image = global::iSmartCar.Properties.Resources.Windows_Close_Program_icon;
            this.btnDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDong.Location = new System.Drawing.Point(297, 230);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(80, 28);
            this.btnDong.TabIndex = 34;
            this.btnDong.Text = "Đóng";
            this.btnDong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnKiemTraKetNoi
            // 
            this.btnKiemTraKetNoi.Image = global::iSmartCar.Properties.Resources.ok;
            this.btnKiemTraKetNoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKiemTraKetNoi.Location = new System.Drawing.Point(170, 166);
            this.btnKiemTraKetNoi.Name = "btnKiemTraKetNoi";
            this.btnKiemTraKetNoi.Size = new System.Drawing.Size(121, 26);
            this.btnKiemTraKetNoi.TabIndex = 35;
            this.btnKiemTraKetNoi.Text = "Kiểm tra kết nối";
            this.btnKiemTraKetNoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKiemTraKetNoi.UseVisualStyleBackColor = true;
            this.btnKiemTraKetNoi.Click += new System.EventHandler(this.btnKiemTraKetNoi_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::iSmartCar.Properties.Resources.Capture;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(409, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // frmQuanLyCSDL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 264);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnKiemTraKetNoi);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnLuuThongTin);
            this.Controls.Add(this.cbTenCSDL);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtTenDangNhap);
            this.Controls.Add(this.cbMayChu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmQuanLyCSDL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý kết nối đến CSDL";
            this.Load += new System.EventHandler(this.frmQuanLyCSDL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbTenCSDL;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.ComboBox cbMayChu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLuuThongTin;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnKiemTraKetNoi;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}