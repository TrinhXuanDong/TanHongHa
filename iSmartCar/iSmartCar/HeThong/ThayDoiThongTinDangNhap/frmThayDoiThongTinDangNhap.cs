using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace iSmartCar
{
    public partial class frmThayDoiThongTinDangNhap : Form
    {
        #region Contructor
        public frmThayDoiThongTinDangNhap()
        {
            InitializeComponent();
        }
        #endregion

        #region Event
        /// <summary>
        /// Hàm xử lý nút thay đổi tài khoản
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnBtnThayDoiMouseClick(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Hàm xử lý nút đóng
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnBtnDongMouseClick(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Method
        private bool CheckDataValid()
        {
            if (_txtMatKhauHienTai.Text == "")
            {
                MessageBox.Show("Chưa nhập mật khẩu hiện tại", "iSmartCar");
                _txtMatKhauHienTai.Focus();
                return false;
            }
            if (_txtTaiKhoan.Text == "")
            {
                MessageBox.Show("Chưa nhập tài khoản mới", "iSmartCar");
                _txtTaiKhoan.Focus();
                return false;
            }
            if (_txtMatKhauMoi.Text == "")
            {
                MessageBox.Show("Chưa nhập mật khẩu mới", "iSmartCar");
                _txtMatKhauMoi.Focus();
                return false;
            }
            if (_txtXacNhanMatKhauMoi.Text == "")
            {
                MessageBox.Show("Chưa nhập xác nhận mật khẩu mới", "iSmartCar");
                _txtXacNhanMatKhauMoi.Focus();
                return false;
            }

            //Kiểm tra mật khẩu hiện tại có đúng ko?
            string matKhauCu = _txtMatKhauHienTai.Text;
            GuiResInfoMng.Instance.RemoveSpecialStr(ref matKhauCu);
            
            //Kiểm tra mật khẩu mới và xác nhận mật khẩu có khớp nhau hay ko?
            return true;
        }
        #endregion
    }
}
