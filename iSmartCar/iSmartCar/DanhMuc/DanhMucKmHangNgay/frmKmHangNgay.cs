using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace iSmartCar
{
    public partial class frmKmHangNgay : Form
    {
        private frmNhapExcel _frmNhapExcel = null;
        public List<string> ErrLst; 
        private const int IndexOfCollumKmTua = 8;

        public frmKmHangNgay()
        {
            InitializeComponent();
            LoadData(_dataGridView);
        }

        #region Method

        private void LoadData(DataGridView dataGridView)
        {
            string sql = string.Format("select * from KmHangNgay");
            DataTable dataTable = GuiResInfoMng.Instance.GetDataTable(sql);
            dataGridView.DataSource = dataTable;
        }

        #endregion

        private void BtnImportExelClick(object sender, EventArgs e)
        {
            if(_frmNhapExcel == null || _frmNhapExcel.IsDisposed)
            {
                _frmNhapExcel = new frmNhapExcel();
            }
            else
            {
                _frmNhapExcel.OnImportFinish -= FrmNhapExcelOnOnImportFinish;
                _frmNhapExcel.OnImportProcess -= FrmNhapExcelOnOnImportProcess;

                _frmNhapExcel.Dispose();
                _frmNhapExcel = null;
                _frmNhapExcel = new frmNhapExcel();
            }

            ErrLst.Clear();
            _frmNhapExcel.OnImportFinish += FrmNhapExcelOnOnImportFinish;
            _frmNhapExcel.OnImportProcess += FrmNhapExcelOnOnImportProcess;
            _frmNhapExcel.Show();
        }

        /// <summary>
        /// Xử lý từng dòng lấy từ exel tại đây
        /// </summary>
        /// <param name="dataRow"></param>
        /// <param name="index"></param>
        private void FrmNhapExcelOnOnImportProcess(DataRow dataRow, int index)
        {
            //Xử lý từng dòng exel tại đây
            if(IsValidData(dataRow,index))
            {
                //Insert vao Db
            }
        }

        /// <summary>
        /// Khi import xong
        /// </summary>
        private void FrmNhapExcelOnOnImportFinish()
        {
            _frmNhapExcel.ShowLog(ErrLst);
        }

        private void OnBtnAddClick(object sender, EventArgs e)
        {

        }

        private void OnbtnEditClick(object sender, EventArgs e)
        {

        }

        private void OnBtnCloseClick(object sender, EventArgs e)
        {
            Close();
        }

        private void OnBtnFilterClick(object sender, EventArgs e)
        {
            var frm = new frmFilterKmHangNgay();
            frm.Show();
        }

        private void OntnFilterCanelClick(object sender, EventArgs e)
        {

        }

        #region Kiem tra hop le cua du lieu khi import

        /// <summary>
        /// Hàm chung nhất kiểm tra dữ liệu có hợp lệ không, bao gồm nhiều hàm kiểm tra khác
        /// </summary>
        /// <param name="dataRow"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        private bool IsValidData(DataRow dataRow, int index)
        {
            if(!isNullRow(dataRow))
            {
                ErrLst.Add("Dòng: " +index + " - Trống dữ liệu." );
                return false;
            }

            if (!isFullDataImportant(dataRow))
            {
                ErrLst.Add("Dòng: " + index + " - Thiếu thông tin quan tọng như ngày, tháng năm ...");
            }

            if (!isNullRow(dataRow))
            {
                ErrLst.Add("Dòng: " + index + " - Trống dữ liệu.");
                return false;
            }

            if (!isExist(dataRow))
            {
                ErrLst.Add("Dòng: " + index + " - Đã có trong cơ sở dữ liệu.");
                return false;
            }

            if (!isVaildKmDiWithExel(dataRow))
            {
                ErrLst.Add("Dòng: " + index + " - Km thực tế không khớp với Exel đã nhập.");
                return false;
            }

            if (!isVaildNumber(dataRow))
            {
                ErrLst.Add("Dòng: " + index + " - Dữ liệu ngày, tháng, năm .. không phải là số.");
                return false;
            }
            return true;
        }

        /// <summary>
        /// Kiểm tra dòng có trống dữ liệu hay không
        /// </summary>
        /// <param name="dataRow"></param>
        /// <returns></returns>
        private bool isNullRow(DataRow dataRow)
        {
            var lengthOfRow = dataRow.ItemArray.Length;
            if (lengthOfRow <= 0)
            {
                return false;
            }
            else
            {
                for (var i = 0; i < lengthOfRow; i++)
                {
                    //cot so 8 la KM tua. không có không sao
                    if (true == dataRow[i].Equals("") && i != IndexOfCollumKmTua)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        /// <summary>
        /// Kiểm tra ngày, tháng, năm , biển số xe, km đi... có dữ liệu
        /// </summary>
        /// <param name="dataRow"></param>
        /// <returns></returns>
        private bool isFullDataImportant(DataRow dataRow)
        {
            //Ngay
            if (true == dataRow[0].Equals(""))
            {
                return false;
            }

            //Thang
            if (true == dataRow[1].Equals(""))
            {
                return false;
            }

            //Nam
            if (true == dataRow[2].Equals(""))
            {
                return false;
            }

            //Bien so xe
            if (true == dataRow[3].Equals(""))
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Kiểm tra dữ liệu đã tồn tại trong CSDL chưa
        /// </summary>
        /// <param name="dataRow"></param>
        /// <returns></returns>
        private bool isExist(DataRow dataRow)
        {
            return true;
        }

        /// <summary>
        /// Kiểm tra kiểu dữ liệu số ngày, tháng, năm, km đi… có hợp lệ hay không
        /// </summary>
        /// <param name="DataRow"></param>
        /// <returns></returns>
        private bool isVaildNumber(DataRow DataRow)
        {
            return true;
        }

        /// <summary>
        /// Kiểm tra Km thực tế đi được có khớp với Exel không?
        /// </summary>
        /// <param name="dataRow"></param>
        /// <returns></returns>
        private bool isVaildKmDiWithExel(DataRow dataRow)
        {
            return true;
        }
        #endregion

    }
}
