namespace iSmartCar
{
    partial class frmNhapExcel
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._progressBar = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this._txtThongBao = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this._btnBatDau = new System.Windows.Forms.Button();
            this._btnDong = new System.Windows.Forms.Button();
            this._txtTenFile = new System.Windows.Forms.TextBox();
            this._btnDuyet = new System.Windows.Forms.Button();
            this._txtTenSheet = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::iSmartCar.Properties.Resources.report_km_everyday;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 301);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label1.Location = new System.Drawing.Point(193, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "NHẬP DỮ LIỆU TỪ FILE EXCEL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên file";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(168, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên sheet";
            // 
            // _progressBar
            // 
            this._progressBar.Location = new System.Drawing.Point(249, 112);
            this._progressBar.Name = "_progressBar";
            this._progressBar.Size = new System.Drawing.Size(287, 23);
            this._progressBar.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(172, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tiến trình";
            // 
            // _txtThongBao
            // 
            this._txtThongBao.BackColor = System.Drawing.Color.Black;
            this._txtThongBao.ForeColor = System.Drawing.Color.Red;
            this._txtThongBao.Location = new System.Drawing.Point(249, 146);
            this._txtThongBao.Name = "_txtThongBao";
            this._txtThongBao.Size = new System.Drawing.Size(287, 125);
            this._txtThongBao.TabIndex = 6;
            this._txtThongBao.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(163, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Thông báo";
            // 
            // _btnBatDau
            // 
            this._btnBatDau.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._btnBatDau.Image = global::iSmartCar.Properties.Resources.ok;
            this._btnBatDau.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnBatDau.Location = new System.Drawing.Point(364, 272);
            this._btnBatDau.Name = "_btnBatDau";
            this._btnBatDau.Size = new System.Drawing.Size(83, 27);
            this._btnBatDau.TabIndex = 8;
            this._btnBatDau.Text = "Bắt đầu";
            this._btnBatDau.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._btnBatDau.UseVisualStyleBackColor = true;
            this._btnBatDau.Click += new System.EventHandler(this.OnBtnBatDauMouseClick);
            // 
            // _btnDong
            // 
            this._btnDong.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._btnDong.Image = global::iSmartCar.Properties.Resources.Windows_Close_Program_icon;
            this._btnDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnDong.Location = new System.Drawing.Point(453, 272);
            this._btnDong.Name = "_btnDong";
            this._btnDong.Size = new System.Drawing.Size(83, 27);
            this._btnDong.TabIndex = 8;
            this._btnDong.Text = "Đóng";
            this._btnDong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._btnDong.UseVisualStyleBackColor = true;
            this._btnDong.Click += new System.EventHandler(this.OnBtnDongMouseClick);
            // 
            // _txtTenFile
            // 
            this._txtTenFile.Location = new System.Drawing.Point(249, 47);
            this._txtTenFile.Name = "_txtTenFile";
            this._txtTenFile.ReadOnly = true;
            this._txtTenFile.Size = new System.Drawing.Size(217, 23);
            this._txtTenFile.TabIndex = 9;
            // 
            // _btnDuyet
            // 
            this._btnDuyet.Image = global::iSmartCar.Properties.Resources.Folder_icon;
            this._btnDuyet.Location = new System.Drawing.Point(501, 47);
            this._btnDuyet.Name = "_btnDuyet";
            this._btnDuyet.Size = new System.Drawing.Size(35, 23);
            this._btnDuyet.TabIndex = 8;
            this._btnDuyet.UseVisualStyleBackColor = true;
            this._btnDuyet.Click += new System.EventHandler(this.OnBtnDuyetMouseClick);
            // 
            // _txtTenSheet
            // 
            this._txtTenSheet.Location = new System.Drawing.Point(249, 82);
            this._txtTenSheet.Name = "_txtTenSheet";
            this._txtTenSheet.Size = new System.Drawing.Size(136, 23);
            this._txtTenSheet.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(472, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "(*)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(391, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "(*)";
            // 
            // frmNhapExcel
            // 
            this.AcceptButton = this._btnBatDau;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this._btnDong;
            this.ClientSize = new System.Drawing.Size(544, 301);
            this.Controls.Add(this.label7);
            this.Controls.Add(this._txtTenSheet);
            this.Controls.Add(this._txtTenFile);
            this.Controls.Add(this._btnDuyet);
            this.Controls.Add(this._btnDong);
            this.Controls.Add(this._btnBatDau);
            this.Controls.Add(this.label5);
            this.Controls.Add(this._txtThongBao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._progressBar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmNhapExcel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Import dữ liệu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar _progressBar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox _txtThongBao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button _btnBatDau;
        private System.Windows.Forms.Button _btnDong;
        private System.Windows.Forms.TextBox _txtTenFile;
        private System.Windows.Forms.Button _btnDuyet;
        private System.Windows.Forms.TextBox _txtTenSheet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}