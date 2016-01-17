using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace iSmartCar
{
    public partial class frmDanhSachXe : Form
    {
        #region Field
        /// <summary>
        /// Biến lưu danh sách lỗi
        /// </summary>
        private List<string> _lstErr = new List<string>();

        /// <summary>
        /// Form nhập excel
        /// </summary>
        private frmNhapExcel _frmNhapExcel = null;
        
        #endregion

        public frmDanhSachXe()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Hàm xử lý nút nhập dữ liệu từ file excel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnBtnImportExcelMouseClick(object sender, EventArgs e)
        {
            if (_frmNhapExcel == null || _frmNhapExcel.IsDisposed)
            {
                _frmNhapExcel = new frmNhapExcel();
            }
            else
            {
                _frmNhapExcel.OnImportProcess -= OnImportProcess;
                _frmNhapExcel.OnImportFinish -= OnImportFinish;

                _frmNhapExcel.Dispose();
                _frmNhapExcel = null;
                _frmNhapExcel = new frmNhapExcel();
            }

            _lstErr.Clear();
            _frmNhapExcel.OnImportProcess += OnImportProcess;
            _frmNhapExcel.OnImportFinish += OnImportFinish;

            //_frmNhapExcel.ShowInTaskbar = false;
            _frmNhapExcel.ShowDialog();
        }

        private void OnImportFinish()
        {
            _frmNhapExcel.ShowLog(_lstErr);
        }

        private void OnImportProcess(DataRow dataRow, int index)
        {
            if (index % 2 == 0)
            {
                _lstErr.Add("Lỗi ở dòng " + index);
            }
        }
    }
}
