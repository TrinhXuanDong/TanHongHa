﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Xml;
using System.Windows.Forms;
using System.Threading;
using Microsoft.Win32;


namespace iSmartCar
{
    public partial class frmCauHinhCSDL : Form
    {
        public frmCauHinhCSDL()
        {
            InitializeComponent();
        }

        private void frmQuanLyCSDL_Load(object sender, EventArgs e)
        {
            readXML();
        }

        private void btnLuuThongTin_Click(object sender, EventArgs e)
        {
            if (cbMayChu.Text == "")
            {
                MessageBox.Show("Chưa điền thông tin tên máy chủ");
                cbMayChu.Focus();
                return;
            }
            if (txtTenDangNhap.Text == "")
            {
                MessageBox.Show("Chưa điền thông tin tên đăng nhập");
                txtTenDangNhap.Focus();
                return;
            }
            if (txtMatKhau.Text == "")
            {
                MessageBox.Show("Chưa điền thông mật khẩu");
                txtMatKhau.Focus();
                return;
            }
            if (cbTenCSDL.Text == "")
            {
                MessageBox.Show("Chưa điền thông tin tên CSDL");
                cbTenCSDL.Focus();
                return;
            }
            writeToXML();
        }

        private void btnKiemTraKetNoi_Click(object sender, EventArgs e)
        {
            try
            {
                cbTenCSDL.Items.Clear();

                MessageBox.Show("Kết nối thành công, vui lòng chọn tên CSDL");
            }
            catch (Exception err)
            {
                MessageBox.Show("Lỗi: " + err.Message);
                cbMayChu.Focus();
                return;
            }

        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void writeToXML()
        {
            try
            {
                IniFile ini = new IniFile(Application.StartupPath + @"/config.ini");

                ini.IniWriteValue("sqlConfig", "serverName", cbMayChu.Text);
                ini.IniWriteValue("sqlConfig", "userNameDatabase", txtTenDangNhap.Text);
                ini.IniWriteValue("sqlConfig", "passWordsDatabase", txtMatKhau.Text);
                ini.IniWriteValue("sqlConfig", "databaseName", cbTenCSDL.Text);

                MessageBox.Show("Lưu thông tin thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi trong quá trình lưu thông tin: " + ex.Message);
            }
        }
        private bool readXML()
        {
            try
            {
                IniFile ini = new IniFile(Application.StartupPath + @"/config.ini");

                string _serverName = ini.IniReadValue("sqlConfig", "serverName");
                string _databaseName = ini.IniReadValue("sqlConfig", "userNameDatabase");
                string _userNameDatabase = ini.IniReadValue("sqlConfig", "passWordsDatabase");
                string _passWordsDatabase = ini.IniReadValue("sqlConfig", "databaseName");

                if (_serverName == "" && _databaseName == "" && _userNameDatabase == "" && _passWordsDatabase == "")
                    return false;
                cbMayChu.Text = _serverName;
                txtTenDangNhap.Text = _userNameDatabase;
                txtMatKhau.Text = _passWordsDatabase;
                cbTenCSDL.Text = _databaseName;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
