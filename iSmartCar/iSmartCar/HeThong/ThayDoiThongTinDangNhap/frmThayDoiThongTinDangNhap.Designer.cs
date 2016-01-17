namespace iSmartCar
{
    partial class frmThayDoiThongTinDangNhap
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this._btnThayDoi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this._txtMatKhauMoi = new System.Windows.Forms.TextBox();
            this._txtTaiKhoan = new System.Windows.Forms.TextBox();
            this._txtMatKhauHienTai = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this._txtXacNhanMatKhauMoi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this._btnDong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::iSmartCar.Properties.Resources.xe_header;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(481, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(350, 270);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "(*)";
            // 
            // _btnThayDoi
            // 
            this._btnThayDoi.Image = global::iSmartCar.Properties.Resources.thong_tin_chung;
            this._btnThayDoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnThayDoi.Location = new System.Drawing.Point(169, 351);
            this._btnThayDoi.Name = "_btnThayDoi";
            this._btnThayDoi.Size = new System.Drawing.Size(105, 26);
            this._btnThayDoi.TabIndex = 4;
            this._btnThayDoi.Text = "Thay đổi";
            this._btnThayDoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._btnThayDoi.UseVisualStyleBackColor = true;
            this._btnThayDoi.Click += new System.EventHandler(this.OnBtnThayDoiMouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 246);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mật khẩu mới";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(351, 214);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "(*)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 190);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tài khoản mới";
            // 
            // _txtMatKhauMoi
            // 
            this._txtMatKhauMoi.Location = new System.Drawing.Point(101, 267);
            this._txtMatKhauMoi.Margin = new System.Windows.Forms.Padding(4);
            this._txtMatKhauMoi.Name = "_txtMatKhauMoi";
            this._txtMatKhauMoi.Size = new System.Drawing.Size(248, 23);
            this._txtMatKhauMoi.TabIndex = 2;
            this._txtMatKhauMoi.UseSystemPasswordChar = true;
            // 
            // _txtTaiKhoan
            // 
            this._txtTaiKhoan.Location = new System.Drawing.Point(101, 211);
            this._txtTaiKhoan.Margin = new System.Windows.Forms.Padding(4);
            this._txtTaiKhoan.Name = "_txtTaiKhoan";
            this._txtTaiKhoan.Size = new System.Drawing.Size(248, 23);
            this._txtTaiKhoan.TabIndex = 1;
            // 
            // _txtMatKhauHienTai
            // 
            this._txtMatKhauHienTai.Location = new System.Drawing.Point(101, 160);
            this._txtMatKhauHienTai.Margin = new System.Windows.Forms.Padding(4);
            this._txtMatKhauHienTai.Name = "_txtMatKhauHienTai";
            this._txtMatKhauHienTai.Size = new System.Drawing.Size(248, 23);
            this._txtMatKhauHienTai.TabIndex = 0;
            this._txtMatKhauHienTai.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(98, 139);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Mật khẩu hiện tại";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(351, 161);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "(*)";
            // 
            // _txtXacNhanMatKhauMoi
            // 
            this._txtXacNhanMatKhauMoi.Location = new System.Drawing.Point(101, 318);
            this._txtXacNhanMatKhauMoi.Margin = new System.Windows.Forms.Padding(4);
            this._txtXacNhanMatKhauMoi.Name = "_txtXacNhanMatKhauMoi";
            this._txtXacNhanMatKhauMoi.Size = new System.Drawing.Size(248, 23);
            this._txtXacNhanMatKhauMoi.TabIndex = 3;
            this._txtXacNhanMatKhauMoi.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(98, 297);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Xác nhận mật khẩu";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(350, 321);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "(*)";
            // 
            // _btnDong
            // 
            this._btnDong.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._btnDong.Image = global::iSmartCar.Properties.Resources.Windows_Close_Program_icon;
            this._btnDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnDong.Location = new System.Drawing.Point(280, 351);
            this._btnDong.Name = "_btnDong";
            this._btnDong.Size = new System.Drawing.Size(67, 26);
            this._btnDong.TabIndex = 5;
            this._btnDong.Text = "Đóng";
            this._btnDong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._btnDong.UseVisualStyleBackColor = true;
            this._btnDong.Click += new System.EventHandler(this.OnBtnDongMouseClick);
            // 
            // frmThayDoiThongTinDangNhap
            // 
            this.AcceptButton = this._btnThayDoi;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this._btnDong;
            this.ClientSize = new System.Drawing.Size(481, 382);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._btnDong);
            this.Controls.Add(this._btnThayDoi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._txtXacNhanMatKhauMoi);
            this.Controls.Add(this._txtMatKhauMoi);
            this.Controls.Add(this._txtMatKhauHienTai);
            this.Controls.Add(this._txtTaiKhoan);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmThayDoiThongTinDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thay đổi thông tin đăng nhập";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button _btnThayDoi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _txtMatKhauMoi;
        private System.Windows.Forms.TextBox _txtTaiKhoan;
        private System.Windows.Forms.TextBox _txtMatKhauHienTai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox _txtXacNhanMatKhauMoi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button _btnDong;
    }
}