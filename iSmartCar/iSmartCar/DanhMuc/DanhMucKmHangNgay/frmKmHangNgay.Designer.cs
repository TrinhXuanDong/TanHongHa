﻿namespace iSmartCar
{
    partial class frmKmHangNgay
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
            this.panel2 = new System.Windows.Forms.Panel();
            this._btnClose = new System.Windows.Forms.Button();
            this._btnEdit = new System.Windows.Forms.Button();
            this._btnAdd = new System.Windows.Forms.Button();
            this._btnFilterCanel = new System.Windows.Forms.Button();
            this._btnFilter = new System.Windows.Forms.Button();
            this._btnImportExel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this._dataGridView = new iSmartCar.MyDataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this._btnClose);
            this.panel2.Controls.Add(this._btnEdit);
            this.panel2.Controls.Add(this._btnAdd);
            this.panel2.Controls.Add(this._btnFilterCanel);
            this.panel2.Controls.Add(this._btnFilter);
            this.panel2.Controls.Add(this._btnImportExel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 452);
            this.panel2.Margin = new System.Windows.Forms.Padding(5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(862, 50);
            this.panel2.TabIndex = 3;
            // 
            // _btnClose
            // 
            this._btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._btnClose.Image = global::iSmartCar.Properties.Resources.XOA;
            this._btnClose.Location = new System.Drawing.Point(785, 8);
            this._btnClose.Margin = new System.Windows.Forms.Padding(5);
            this._btnClose.Name = "_btnClose";
            this._btnClose.Size = new System.Drawing.Size(59, 35);
            this._btnClose.TabIndex = 0;
            this._btnClose.UseVisualStyleBackColor = true;
            this._btnClose.Click += new System.EventHandler(this.OnBtnCloseClick);
            // 
            // _btnEdit
            // 
            this._btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._btnEdit.Image = global::iSmartCar.Properties.Resources.edit_validated_icon;
            this._btnEdit.Location = new System.Drawing.Point(716, 8);
            this._btnEdit.Margin = new System.Windows.Forms.Padding(5);
            this._btnEdit.Name = "_btnEdit";
            this._btnEdit.Size = new System.Drawing.Size(59, 35);
            this._btnEdit.TabIndex = 0;
            this._btnEdit.UseVisualStyleBackColor = true;
            this._btnEdit.Click += new System.EventHandler(this.OnbtnEditClick);
            // 
            // _btnAdd
            // 
            this._btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._btnAdd.Image = global::iSmartCar.Properties.Resources.Them;
            this._btnAdd.Location = new System.Drawing.Point(647, 8);
            this._btnAdd.Margin = new System.Windows.Forms.Padding(5);
            this._btnAdd.Name = "_btnAdd";
            this._btnAdd.Size = new System.Drawing.Size(59, 35);
            this._btnAdd.TabIndex = 0;
            this._btnAdd.UseVisualStyleBackColor = true;
            this._btnAdd.Click += new System.EventHandler(this.OnBtnAddClick);
            // 
            // _btnFilterCanel
            // 
            this._btnFilterCanel.Image = global::iSmartCar.Properties.Resources.filter_delete_icon;
            this._btnFilterCanel.Location = new System.Drawing.Point(79, 10);
            this._btnFilterCanel.Margin = new System.Windows.Forms.Padding(5);
            this._btnFilterCanel.Name = "_btnFilterCanel";
            this._btnFilterCanel.Size = new System.Drawing.Size(55, 35);
            this._btnFilterCanel.TabIndex = 0;
            this._btnFilterCanel.UseVisualStyleBackColor = true;
            this._btnFilterCanel.Click += new System.EventHandler(this.OntnFilterCanelClick);
            // 
            // _btnFilter
            // 
            this._btnFilter.Image = global::iSmartCar.Properties.Resources.filter_add_icon;
            this._btnFilter.Location = new System.Drawing.Point(16, 10);
            this._btnFilter.Margin = new System.Windows.Forms.Padding(5);
            this._btnFilter.Name = "_btnFilter";
            this._btnFilter.Size = new System.Drawing.Size(55, 35);
            this._btnFilter.TabIndex = 0;
            this._btnFilter.UseVisualStyleBackColor = true;
            this._btnFilter.Click += new System.EventHandler(this.OnBtnFilterClick);
            // 
            // _btnImportExel
            // 
            this._btnImportExel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._btnImportExel.Image = global::iSmartCar.Properties.Resources.Import_icon;
            this._btnImportExel.Location = new System.Drawing.Point(581, 8);
            this._btnImportExel.Margin = new System.Windows.Forms.Padding(5);
            this._btnImportExel.Name = "_btnImportExel";
            this._btnImportExel.Size = new System.Drawing.Size(55, 35);
            this._btnImportExel.TabIndex = 0;
            this._btnImportExel.UseVisualStyleBackColor = true;
            this._btnImportExel.Click += new System.EventHandler(this.BtnImportExelClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this._dataGridView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(862, 502);
            this.panel1.TabIndex = 4;
            // 
            // _dataGridView
            // 
            this._dataGridView.AllowUserToAddRows = false;
            this._dataGridView.AllowUserToDeleteRows = false;
            this._dataGridView.AllowUserToOrderColumns = true;
            this._dataGridView.AllowUserToResizeRows = false;
            this._dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column1,
            this.Column7,
            this.Column2,
            this.Column3,
            this.Column8,
            this.Column9});
            this._dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._dataGridView.Location = new System.Drawing.Point(0, 0);
            this._dataGridView.Margin = new System.Windows.Forms.Padding(5);
            this._dataGridView.MultiSelect = false;
            this._dataGridView.Name = "_dataGridView";
            this._dataGridView.ReadOnly = true;
            this._dataGridView.RowHeadersVisible = false;
            this._dataGridView.Size = new System.Drawing.Size(862, 502);
            this._dataGridView.TabIndex = 0;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Ngày";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Tháng";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Năm";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Biển số xe";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Tên lái xe";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Km Đi";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Km Về";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Km Đi Được";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Km Tua";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // frmKmHangNgay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 502);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmKmHangNgay";
            this.Text = "Km hằng ngày";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MyDataGridView _dataGridView;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button _btnClose;
        private System.Windows.Forms.Button _btnEdit;
        private System.Windows.Forms.Button _btnAdd;
        private System.Windows.Forms.Button _btnFilterCanel;
        private System.Windows.Forms.Button _btnFilter;
        private System.Windows.Forms.Button _btnImportExel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
    }
}