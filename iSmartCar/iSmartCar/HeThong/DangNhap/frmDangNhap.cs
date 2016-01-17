using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace iSmartCar
{
    public partial class frmDangNhap : Form
    {
        #region Contructor
        public frmDangNhap()
        {
            InitializeComponent();
            //abcd
        }
        #endregion

        #region Event
        /// <summary>
        /// Hàm xử lý sự kiện nút DangNhap click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnBtnDangNhapMouseClick(object sender, EventArgs e)
        {
            //Kiểm tra dữ liệu hợp lệ
            if (CheckDataValid() == true)
            {
                string tenDangNhap = _txtTaiKhoan.Text;
                string matKhau = _txtMatKhau.Text;

                //Loại bỏ ký tự đặc biệt
                GuiResInfoMng.Instance.RemoveSpecialStr(ref tenDangNhap);
                GuiResInfoMng.Instance.RemoveSpecialStr(ref matKhau);

                //Kiểm tra xem thông tin đăng nhập đúng hay sai
                string sql = string.Format("select count(*) from TaiKhoan where TaiKhoan = N'{0}' and MatKhau = N'{1}'",
                    tenDangNhap, matKhau);
                int tmp = GuiResInfoMng.Instance.ExcuteScalarInt(sql);
                if (tmp == 1)
                {
                    //Thành công
                    MessageBox.Show("Đăng nhập thành công", "iSmartCar");
                }
                else
                {
                    //Thất bại
                    MessageBox.Show("Sai tên đăng nhập hoặc tài khoản", "iSmartCar");
                    _txtTaiKhoan.Focus();
                }
            }
        }
        #endregion

        #region Method
        /// <summary>
        /// Hàm kiểm tra xem người dùng đã nhập đầy đủ dữ liệu hay chưa?
        /// </summary>
        /// <returns></returns>
        private bool CheckDataValid()
        {
            if (_txtTaiKhoan.Text == "") 
            {
                MessageBox.Show("Chưa nhập tên tài khoản", "iSmartCar");
                _txtTaiKhoan.Focus();
                return false;
            }

            if (_txtMatKhau.Text == "")
            {
                MessageBox.Show("Chưa nhập mật khẩu", "iSmartCar");
                _txtMatKhau.Focus();
                return false;
            }
            return true;
        }
        #endregion
    }
}
