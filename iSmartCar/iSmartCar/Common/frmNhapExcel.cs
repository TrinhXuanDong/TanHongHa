using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ExcelConnection;

namespace iSmartCar
{
    public partial class frmNhapExcel : Form
    {
        #region Field
        private BackgroundWorker _backGroundWorker = null;
        private DataTable _dataTable = null;
        private int MAX_ROWS = 0;
        #endregion

        #region Property
        #endregion

        #region Delegate
        public delegate void DelegateImportProcess(DataRow dataRow, int index);
        public event DelegateImportProcess OnImportProcess;

        public delegate void DelegateImportFinish();
        public event DelegateImportFinish OnImportFinish;
        #endregion

        #region Contructor
        public frmNhapExcel()
        {
            InitializeComponent();
        }
        #endregion

        #region Event
        private void OnBtnDuyetMouseClick(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                _txtTenFile.Text = open.FileName;
            }
        }

        private void OnBtnBatDauMouseClick(object sender, EventArgs e)
        {
            if (_backGroundWorker == null)
            {
                _backGroundWorker = new BackgroundWorker();
            }
            else
            {
                _backGroundWorker.DoWork -= OnBackGroundWorkerDoWork;
                _backGroundWorker.RunWorkerCompleted -= OnBackGroundWorkerRunWorkerCompleted;
                _backGroundWorker.ProgressChanged -= OnBackGroundWorkerProgressChanged;

                _backGroundWorker.Dispose();
                _backGroundWorker = null;
                _backGroundWorker = new BackgroundWorker();
            }

            _backGroundWorker.WorkerReportsProgress = true;
            _backGroundWorker.DoWork += OnBackGroundWorkerDoWork;
            _backGroundWorker.RunWorkerCompleted += OnBackGroundWorkerRunWorkerCompleted;
            _backGroundWorker.ProgressChanged += OnBackGroundWorkerProgressChanged;

            try
            {
                string sql = "select * from [" + _txtTenSheet.Text + "$]";

                _dataTable = ExcelUtility.Instance.GetDataTable(_txtTenFile.Text, sql);
                
                MAX_ROWS = _dataTable.Rows.Count;
                if (MAX_ROWS != 0)
                {
                    _progressBar.Value = 0;
                    _progressBar.Maximum = MAX_ROWS;

                    //foreach (Control item in this.Controls)
                    //{
                    //    item.Enabled = false;
                    //}

                    _backGroundWorker.RunWorkerAsync();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void OnBackGroundWorkerProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            _progressBar.Value = e.ProgressPercentage;
        }

        private void OnBackGroundWorkerRunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (OnImportFinish != null)
            {
                OnImportFinish();
            }

            foreach (Control item in this.Controls)
            {
                item.Enabled = true;
            }
        }

        private void OnBackGroundWorkerDoWork(object sender, DoWorkEventArgs e)
        {
            for (int q = 0; q < MAX_ROWS; q++)
            {
                if (OnImportProcess != null)
                {
                    OnImportProcess(_dataTable.Rows[q], q + 1);
                }

                _backGroundWorker.ReportProgress(q);
            }
        }

        private void OnBtnDongMouseClick(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Method
        /// <summary>
        /// Hàm kiểm tra xem dữ liệu đã nhập đầy đủ hay chưa
        /// </summary>
        /// <returns></returns>
        private bool CheckDataValid()
        {
            return true;
        }

        public void ShowLog(List<string> listStr)
        {
            _txtThongBao.Clear();
            if (listStr.Count == 0)
            {
                _txtThongBao.Text = "Thành công";
            }
            else
            {
                _txtThongBao.Text = "Đã có một số lỗi xảy ra:\n";

                for (int i = 0; i < listStr.Count; i++)
                {
                    _txtThongBao.Text += listStr[i] + "\n";
                }
            }
        }
        #endregion
    }
}
